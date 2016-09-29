using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Graph
{
    public class LineGraph
    {
        public float heigth { get; set; }
        public float width { get; set; }

        public LineGraph(float heigth, float width)
        {
            this.heigth = heigth;
            this.width = width;
        }

        // vẽ biểu đồ
        public void DrawLineGraph(Graphics g, float max_value, params PointF[] pointfs)
        {
            PointF[] pointf_processed = ProcessPoints(max_value, pointfs);

            if (pointf_processed != null)
            {
                // vẽ đường
                g.DrawLines(Pens.Blue, pointf_processed);

                // vẽ dấu chấm
                foreach (var p in pointf_processed)
                {
                    g.FillEllipse(Brushes.Red, p.X, p.Y - 1f, 2f, 2f);
                }
            }
        }

        // xử lý số liệu theo tỷ lệ khung vẽ
        public float ProcessValue(float value, float proportion)
        {
            // các giá trị cần thiết
            float h = heigth;// chiều cao
            float w = width;// chiều rộng
            float zero = h - 3f;// đường y = 0
            float value_proportion = 0f;// giá trị cmyk

            // bắt đầu chia tỷ lệ
            if (proportion != 0f)
                value_proportion = zero / proportion;

            // kết thúc đoạn chia tỷ lệ
            return -value * value_proportion + zero;
        }

        // hàm xử lý dữ liệu
        public PointF[] ProcessPoints(float max_value, params PointF[] points_para)
        {
            if (points_para.Count() == 0)
                return null;

            int size = points_para.Count();
            //
            PointF[] points = new PointF[size + 1];

            points[0] = new PointF(0, ProcessValue(points_para[0].Y, max_value));

            for (int i = 0; i < size; i++)
            {
                float x = (i + 1) * (width - 3f) / size;
                float y = ProcessValue(points_para[i].Y, max_value);
                points[i + 1] = new PointF(x, y);
            }
            return points;
        }

        // hàm vẽ các giá trị theo chiều ngang
        public void DrawValueH(Graphics g, float bottom, float left, float right, int size, int increase, string format)
        {
            float w = right - left - 5;
            float proportion = w / size;
            int value = 0;
            for (float i = left; i <= right; i += proportion)
            {
                g.DrawString((value++).ToString(format),
                    new Font(FontFamily.GenericSerif, 7f, FontStyle.Regular),
                    Brushes.Black, new PointF(i - 4, bottom));
            }
        }

        // hàm vẽ các giá trị theo chiều dọc
        public void DrawValueV(Graphics g, float left, float top, float bottom, int size, float increase, string format)
        {
            float h = bottom - top - 6;
            float proportion = h / size;

            float value = 0;

            for (float i = bottom; i >= top; i -= proportion)
            {
                g.DrawString((value).ToString(format),
                    new Font(FontFamily.GenericSerif, 7f, FontStyle.Regular),
                    Brushes.Black, new PointF(left - 26, i - 10));
                value += increase;
            }
        }
    }
}
