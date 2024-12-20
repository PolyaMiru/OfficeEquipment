drop table Comments
drop table Parts
drop table Request
drop table [Profile]
drop table Model
drop table TechType
drop table [Status]
drop table Access

Create table Access 
(
	id_access int PRIMARY KEY IDENTITY(1,1),
	name_access nvarchar(50) not null
)

Create table [Status] 
(
	id_status int PRIMARY KEY IDENTITY(1,1),
	name_status nvarchar(50) not null
)

Create table TechType
(
	id_type int PRIMARY KEY IDENTITY(1,1),
	name_type nvarchar(50) not null
)

Create table Model
(
	id_model int PRIMARY KEY IDENTITY(1,1),
	id_type int not null,
	name_model nvarchar(100) not null
	CONSTRAINT FK_model_type FOREIGN KEY (id_type) REFERENCES TechType (id_type)
)

Create table [Profile] 
(	
	id_profile int PRIMARY KEY IDENTITY(1,1),
	id_access int not null,
	fio nvarchar(200) not null,
	phone nvarchar(50) not null,
	[login] nvarchar(50) not null,
	[password] nvarchar(200) not null
	CONSTRAINT FK_profile_access FOREIGN KEY (id_access) REFERENCES Access (id_access)
)

Create table Request 
(
	id_request int PRIMARY KEY IDENTITY(1,1),
	id_client int not null,
	id_master int,
	id_status int not null,
	id_model int not null,
	time_start date,
	time_end date,	
	problem nvarchar(max) not null
	CONSTRAINT FK_request_profile FOREIGN KEY (id_master) REFERENCES Profile (id_profile),
	CONSTRAINT FK_request_profile1 FOREIGN KEY (id_client) REFERENCES Profile (id_profile),
	CONSTRAINT FK_request_status FOREIGN KEY (id_status) REFERENCES Status (id_status),
	CONSTRAINT FK_request_model FOREIGN KEY (id_model) REFERENCES Model (id_model)
)

Create table Parts
(
	id_parts int PRIMARY KEY IDENTITY(1,1),
	id_request int not null,
	name_parts nvarchar(100) not null,
	[count] int default 1,
	CONSTRAINT FK_parts_request FOREIGN KEY (id_request) REFERENCES Request (id_request)
)

Create table Comments
(
	id_comment int PRIMARY KEY IDENTITY(1,1),
	id_request int not null,
	[message] nvarchar(max) not null
	CONSTRAINT FK_comment_request FOREIGN KEY (id_request) REFERENCES Request (id_request),
)


insert into Access values 
('Менеджер'),
('Оператор'),
('Мастер'),
('Заказчик')

insert into [Status]  values 
('Новая заявка'),
('Зарегистрированна'),
('В процеесе ремонта'),
('Готова к выдаче')

insert into TechType  values 
('Компьютер'),
('Ноутбук'),
('Принтер'),
('Сканер'),
('Клавиатура'),
('Шредер')

insert into Model  values 
(1, 'DEXP Aquilon O286'),
(1, 'DEXP Atlas H388'),
(2, 'MSI GF76 Katana 11UC-879XRU черный'),
(2, 'MSI Modern 15 B12M-211RU черный'),
(3, 'HP LaserJet Pro M404dn'),
(4, 'FPT BFFB Pro X 2'),
(5, 'Механическая DXC 15'),
(6, 'DDX Pro25 2005')



insert into [Profile]  values 
( 1,'Носов Иван Михайлович','89210563128','login1','pass1'),
( 3,'Ильин Александр Андреевич','89535078985','login2','pass2'),
( 3, 'Никифоров Иван Дмитриевич','89210673849','login3','pass3'),
( 2,'Елисеев Артём Леонидович','89990563748','login4','pass4'),
( 2,'Титов Сергей Кириллович','89994563847','login5','pass5'),
( 4,'Григорьев Семён Викторович','89219567849','login11','pass11'),
( 4,'Сорокин Дмитрий Ильич','89219567841','login12','pass12'),
( 4,'Белоусов Егор Ярославович','89219567842','login13','pass13'),
( 4,'Суслов Михаил Александрович','89219567843','login14','pass14'),
( 3,'Васильев Вячеслав Александрович','89219567844','login15','pass15')

insert into Request values 
(7,2,3,1,'06.06.2023',null,'Перестал работать'),
(8,3,3,2,'05.05.2023',null,'Перестал работать'),
(9,3,4,3,'07.07.2022','01.01.2023','Выключается'),
(8,null,1,4,'02.08.2023',null,'Выключается'),
(9,null,1,5,'02.08.2023',null,'Перестала включаться')

insert into Parts values 
(1,'Кулер для процессора', 1),
(1,'Болты', 1),
(2,'Клавиатура', 1),
(3,'Катридж красный', 1),
(3,'Катридж зеленый', 1),
(3,'Катридж синий', 1)

insert into Comments values
(1,'Интересно...'),
(2,'Будем разбираться!'),
(3,'Сделаем всё на высшем уровне!')

insert into [Profile]  values 
( 2,'Оператор','89210563128','2','2'),
( 1,'Менеджер','89210563128','4','4'),
( 4,'Клиент','89210563128','1','1'),
( 3,'Мастер','89210563128','3','3')