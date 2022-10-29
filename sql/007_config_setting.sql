insert into ExampleDb.config_setting (id, `key`, description, value, created_at) 
values 
(1, 'post_price', 'Đơn giá cho một lần đăng bài', 10000, NOW()),
(2, 'free_post', 'Số lần đăng bài miễn phí cấp cho chủ trọ mới', 5, NOW());