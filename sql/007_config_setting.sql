insert into ExampleDb.config_setting (id, `key`, description, value, created_at) 
values 
(1, 'post_price', 'Đơn giá cho một lần đăng bài', 10000, NOW()),
(2, 'free_post', 'Số lần đăng bài miễn phí cấp cho chủ trọ mới', 5, NOW()),
(3, 'uptop_price', 'Đơn giá đưa tin lên mục ưu tiên trong 1 ngày', 15000, NOW()),
(4, 'max_priority_post', 'Số bài đăng ưu tiên tối đa trong 1 khu vực', 5, NOW()),
(5, 'priority_in_search', 'Số bài đăng ưu tiên hiển thị tối đa trong 1 trang tìm kiếm', 5, NOW());