INSERT INTO ExampleDb.user_account (email,password_hashed,password_salt,is_verified,role_id,created_at,updated_at) VALUES
	 ('tranphiphuong2763@gmail.com',0xEC6A53CAD27428BF080DA10132E31B60076F224CA10FBAA9D34320A634AC49C000A88C84746ED790D002C6DFBF1498C9CADD24CE63743B8B4C4F86B23DC76E9B,0x59DE38DFAAFEFE06D8EDD8B7B100C943F3AAD568F3F245FBDAF90DC15A286695C12FB70D95FEF3F22FFC1595417A2BBAE758D6B9D74D8716204F6847C7F5A358B72E1A75BE048E3E34A9980F0828B9E701CE6534E245C5A042D06AEDAAFC96DC54A0BA60D2E7C80594DEAF6A0240077880359C814ACF7E49DAF794987A35D7EE,1,1,'2022-10-17 17:53:06.420409','2022-10-18 15:44:04.069597'),
	 ('ngminhdung1311@gmail.com',0xCD73AEE457FE1DB9C63D36D673E8D2DDA03A7687ABE23E9959558EDFA12D3855F03D38716464403AACC13F9E432A31C3153A625CED4F7FDA192D9EE19DFEAF90,0xCF36DFDFDDC5EA90C6CB5CC99BDECA2C505FED09D5FD5927EBA26DAEF1DAF1D813C95F8E053756A78366110F8168A9DA14A029643740E2DC3FBE9DB400A8E9E3F76477D3478BAB3FA43410BD5D1B9330D37080D9C10590CEFAE7D478E236C5CE23453DB79F50E6765981801ACA0FC70E287CE4DD36BA4416F17CC551CB7E53B6,1,1,'2022-10-18 18:23:08.278941','2022-10-18 18:25:26.037826'),
	 ('ht10082001@gmail.com',0xCC42DAEC7805EFD63530537938D4A60721F2C04130C40B2F18711FABA6439FEEA4F81253AFC48880201F5159816A55D8428A24E02B9D9C36ADB819EAECB9C579,0x7FFE9BB6AD6C44246CC0DF72FD799963D33DBDFF16E9ACB2482826935EE89E4356032FAF3D5685AF02D4187116F8711DC8AB3647BB90B8867C55DC555F35C00D027B01C164E3BA5F4E0149B6170FF114A6AB532449A83CF5CA6A125526563337554A38C2822889B5A48B684604EA9C2049D58DE8633149D088D358AF638D5A96,1,1,'2022-10-19 09:35:43.388548','2022-10-19 09:36:10.353913');

INSERT INTO ExampleDb.user_profile (display_name,phone_number,identity_number,current_credit,address,address_ward_id,user_id,created_at,updated_at,avatar) VALUES
	 ('Phuong Tran','0336615425','0123123123',0.0,'123',1,1,'2022-10-17 17:53:06.717852','2022-10-20 04:28:42.624575',''),
	 ('dungngminh','0702478885','12345678',0.0,'hehe',13,2,'2022-10-18 18:23:08.333149','2022-10-23 19:41:49.377987','https://pbl6.s3.ap-southeast-1.amazonaws.com/scaled_c35262b0-780c-4db6-8e7f-fe04ea1fc5a04957628494433943233.jpg'),
	 ('Truong Minh Phuoc','0382609982','197418191',0.0,'906/10 Ton Duc Thang',6192,5,'2022-10-19 09:35:43.441405',NULL,'');