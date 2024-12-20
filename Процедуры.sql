
CREATE VIEW request_view
AS 
Select id_request, id_client, id_master,[Status].id_status, TechType.name_type, Model.name_model, problem, [Status].name_status, time_start, time_end
from Request 
inner join[Status] on Request.id_status = [Status].id_status
inner join Model on Request.id_model = Model.id_model 
inner join TechType on Model.id_type = TechType.id_type  

Create proc get_request_by_client  @id_client int AS
select request_view.id_request, name_type, name_model, problem, name_status from request_view  where id_client = @id_client

Create proc get_request_by_master @id_master int AS
select id_request, name_type, name_model, problem, name_status from request_view where id_master = @id_master

Create proc get_request_by_id @id_request int AS
select id_request, name_type, name_model, problem, name_status , fio,  time_start, time_end from request_view left join Profile on request_view.id_master = Profile.id_profile where id_request = @id_request

Create proc get_parts_by_id @id_request int AS
select name_parts, [count] from Parts where id_request = @id_request

Create proc get_request_by_status @name_status nvarchar(50) AS
select id_request, name_type, name_model, problem, name_status from request_view where name_status = @name_status;


Create proc get_request  AS
select id_request, name_type, name_model, problem, name_status, fio, time_start, time_end from request_view left join Profile on request_view.id_master = Profile.id_profile

Create proc get_status  AS
select name_status from [Status] 

Create proc get_master  AS
select id_profile, fio from [Profile] where id_access = 3; 

Create proc get_type  AS
select name_type from TechType; 

Create proc get_comments  AS
select id_request, [message] from Comments; 

Create proc get_model  @name_type nvarchar(50) AS
select name_model from Model inner join TechType on Model.id_type = TechType.id_type where name_type = @name_type; 

Create proc add_request @id_client int,	@name_model nvarchar(100), @problem nvarchar(max) AS
insert into Request values 
(@id_client,null,1,(select id_model from Model where name_model = @name_model),null,null,@problem) 

Create proc add_part @id_request int, @name_parts nvarchar(100), @count int AS
insert into Parts values 
(@id_request,@name_parts,@count) 

 Create proc add_comment @id_request int, @message nvarchar(max) AS
insert into Comments values 
(@id_request,@message) 

Create proc update_request  @id_request int, @name_model nvarchar(100), @problem nvarchar(max) AS
UPDATE Request
SET id_model = (select id_model from Model where name_model = @name_model), problem = @problem WHERE id_request = @id_request

Create proc update_request_operator  @id_request int, @id_profile int, @name_model nvarchar(100), @problem nvarchar(max) AS
UPDATE Request
SET id_master = @id_profile, id_model = (select id_model from Model where name_model = @name_model), problem = @problem, id_status = 2 WHERE id_request = @id_request

Create proc update_request_manager  @id_request int, @id_profile int, @name_model nvarchar(100), @problem nvarchar(max), @time_start date, @time_end date, @name_status nvarchar(50) AS
UPDATE Request
SET id_master = @id_profile, id_model = (select id_model from Model where name_model = @name_model), problem = @problem, id_status = (select id_status from Status where name_status = @name_status), time_end = @time_end, time_start = @time_start WHERE id_request = @id_request

Create proc [login] @login nvarchar(50), @password nvarchar(50) AS
select id_profile, id_access from Profile where [login] = @login and [password] = @password

Create proc start_work  @id_request int, @time_start date AS
UPDATE Request
SET id_status = 3, time_start = @time_start WHERE id_request = @id_request

Create proc end_work  @id_request int, @time_end date AS
UPDATE Request
SET id_status = 4, time_end = @time_end WHERE id_request = @id_request

exec update_request_manager 1, null, 1, 'gggg', 'Готова к выдаче', '01.01.2023','01.01.2024'