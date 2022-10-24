insert into ExampleDb.role (id, name, description, created_at)
values 
(1, 'admin', 'quản lý', NOW()),
(2, 'host', 'chủ trọ', NOW()),
(3, 'guest', 'người tìm trọ', NOW());