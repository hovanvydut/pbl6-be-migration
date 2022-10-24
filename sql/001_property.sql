insert into ExampleDb.property_group (id, display_name, created_at)
values 
(1, 'Các địa điểm gần đó', NOW()),
(2, 'Các tiện ích khác', NOW()),
(3, 'Đối tượng cho thuê', NOW());

insert into ExampleDb.property (id, display_name, property_group_id ,created_at)
values
(1, 'Chợ, siêu thị, tạp hoá', 1, NOW()),
(2, 'Hiệu thuốc', 1, NOW()),
(3, 'Trường đại học', 1, NOW()),
(4, 'Biển', 1, NOW()),
(5, 'Cafe, trà sữa', 1, NOW()),
(6, 'Uỷ ban, công an', 1, NOW()),
(7, 'Bệnh viện', 1, NOW()),
(8, 'Công viên, bến xe', 1, NOW()),
(9, 'Sửa xe', 1, NOW()),

(10, 'Cho nam nữ ở chung', 2, NOW()),
(11, 'Cho nuôi thú cưng', 2, NOW()),
(12, 'Có sẵn nội thức', 2, NOW()),
(13, 'Có máy lạnh', 2, NOW()),
(14, 'Có máy giặt sấy', 2, NOW()),
(15, 'Có ban công', 2, NOW()),
(16, 'Có sân phơi quần áo', 2, NOW()),
(17, 'Có sân thượng', 2, NOW()),
(18, 'Có chỗ đỗ xe', 2, NOW()),
(19, 'Có camera', 2, NOW()),
(20, 'Có bảo vệ', 2, NOW()),
(21, 'Có phòng vệ sinh trong', 2, NOW()),
(22, 'Có gác lửng', 2, NOW()),
(23, 'Có nước nóng lạnh', 2, NOW()),
(24, 'Có khoá cổng riêng', 2, NOW()),
(25, 'Không quy định giờ giấc', 2, NOW()),
(26, 'Cho thuê ngắn hạn', 2, NOW()),

(27, 'Nam', 3, NOW()),
(28, 'Nữ', 3, NOW()),
(29, 'Giới tính khác', 3, NOW()),
(30, 'Sinh viên', 3, NOW()),
(31, 'Người đi làm', 3, NOW()),
(32, 'Gia đình', 3, NOW()),
(33, 'Không quy định', 3, NOW());
