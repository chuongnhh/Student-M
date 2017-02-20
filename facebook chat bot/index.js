var login = require("facebook-chat-api");
const fs = require('fs');

var answeredThreads = {};

// Create simple echo bot
login({ email: "chuongnhh@gmail.com", password: "01647931390" }, function callback(err, api) {
    if (err) return console.error(err);

    api.getFriendsList(function (err, data) {
        if (err) return console.error(err);

        // data.forEach(function (item) {
        //     console.log('alternateName: ' + item.alternateName);
        //     console.log('firstName: ' + item.firstName);
        //     console.log('gender: ' + item.gender);
        //     console.log('userID: ' + item.userID);
        //     console.log('isFriend: ' + item.isFriend);
        //     console.log('fullName: ' + item.fullName);
        //     console.log('profilePicture: ' + item.profilePicture);
        //     console.log('type: ' + item.type);
        //     console.log('profileUrl: ' + item.profileUrl);
        //     console.log('vanity: ' + item.vanity);
        //     console.log('isBirthday: ' + item.isBirthday);
        //     console.log('=======================================');
        // })

        // for (var i = 0; i < 1000; i++) {
        //     var yourID = "100008555198066";
        //     var msg = { body: "Tình yêu!!!\r\n- Sẽ ở lại với ai đang cần nó!\r\n- Sẽ quay lại với ai đi tìm nó!\r\n- Và sẽ vô lại với ai coi thường nó....!\r\nChúc em 1 ngày VALENTINE vui vẻ!" };
        //     api.sendMessage(msg, yourID);
        //     console.log('Sending ' + i + '...');
        // }}

        // var tmp = "";
        // for (var i = 0; i < 1000; i++) {
        //     tmp += "🌹";
        // }
        //console.log(tmp.length);
        for (var i = 0; i < 1000; i++) {
            var yourID = "100008555198066";
            var msg = { body: "Chúc em ngủ ngon. Anh yêu em!" };
            api.sendMessage(msg, yourID);
            console.log('Sending ' + i + '...');
        }

        fs.writeFileSync('friends.json', JSON.stringify(data));
        console.log('You have ' + data.length + ' friends.');
    });

    api.listen(function callback(err, message) {
        //var d = new Date();
        //var h = d.getHours();
        if (!answeredThreads.hasOwnProperty(message.threadID)) {
            api.getUserInfo(message.senderID, function (err, ret) {
                if (err) return console.error(err);
                for (var prop in ret) {
                    if (ret.hasOwnProperty(prop) && ret[prop].name) {
                        // api.sendMessage("[Tính năng TỰ ĐỘNG trả lời tin nhắn] \r\nChương ĐANG BẬN, KHÔNG THỂ TRẢ LỜI tin nhắn ngay được. \r\n"
                        //     + ret[prop].firstName + " vui lòng ĐỂ LẠI TIN NHẮN, Chương sẽ TRẢ LỜI ngay khi đọc được nhé.", prop, function () {
                        //         answeredThreads[message.threadID] = true;
                        //     });
                        //console.log(ret[prop].firstName + ' vua gui tin nhan cho ban.\n' + message.body);
                    }
                }
            });
        }
    });
});