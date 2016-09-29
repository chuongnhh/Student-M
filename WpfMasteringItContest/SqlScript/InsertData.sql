use Db_MITContest
go
--===================================
insert into HeThi values(N'Khối Chuyên')
insert into HeThi values(N'Khối Không Chuyên')

--====================================

insert into DoiThi values(1,'Songoku','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(1,'ChiChi','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(1,'SonGohan','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(1,'Videl','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(1,'SonGoten','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')

insert into DoiThi values(2,'Vegeta','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(2,'Trunks','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(2,'Bulma','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(2,'FatBuu','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')
insert into DoiThi values(2,'Krillin','xxxxx', 'xxxxx','xxxxx','xxxxxx','xxxxxx')

--====================================
insert into TroChoi values(N'Khởi Động', 15, 1)
insert into TroChoi values(N'Vận Động-Lắp Ghép Chương Trình', 300, 1)
insert into TroChoi values(N'Truyền Tin', 360, 1)
insert into TroChoi values(N'Lập Trình Tiếp Sức', 450, 1)
insert into TroChoi values(N'Đá Lưu Luân', 1000, 1)

insert into TroChoi values(N'Khởi Động', 15, 2)
insert into TroChoi values(N'Vận Động-Ngọn Tháp Trí Tuệ', 15, 2)
insert into TroChoi values(N'Tốc Độ', 15, 2)
insert into TroChoi values(N'Đá Lưu Luân', 1000, 2)

--====================================
insert into CauHoi values(N'Câu 1', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'A',1)
insert into CauHoi values(N'Câu 2', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'D',1)
insert into CauHoi values(N'Câu 3', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'C',1)

insert into CauHoi values(N'Luật Thi Vòng Vận Động - Lắp Ghép Chương Trình',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',2)
insert into CauHoi values(N'Luật Thi Vòng Truyền Tin',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',3)
insert into CauHoi values(N'Luật Thi Vòng Lập Trình Tiếp Sức',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',4)
insert into CauHoi values(N'Luật Thi Vòng Đá Lưu Luân',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',5)



insert into CauHoi values(N'Câu 1', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'A',6)
insert into CauHoi values(N'Câu 2', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'D',6)
insert into CauHoi values(N'Câu 3', N'What is Entity Framework?',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'Entity framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.',
'C',6)

insert into CauHoi values(N'Luật Thi Vòng Vận Động - Ngọn Tháp Trí Tuệ',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',7)
insert into CauHoi values(N'Luật Thi Vòng Tốc Độ',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',8)
insert into CauHoi values(N'Luật Thi Vòng Đá Lưu Luân',
'The Microsoft ADO.NET Entity Framework is an Object/Relational Mapping (ORM) framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code that developers usually need to write. Using the Entity Framework, developers issue queries using LINQ, then retrieve and manipulate data as strongly typed objects. The Entity Framework is ORM implementation provides services like change tracking, identity resolution, lazy loading, and query translation so that developers can focus on their application-specific business logic rather than the data access fundamentals.',
'','','','','',9)



