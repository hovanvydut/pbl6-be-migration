insert into ExampleDb.role (name, description, created_at)
values 
('admin', 'quản lý', NOW()),
('host', 'chủ trọ', NOW()),
('guest', 'người tìm trọ', NOW());