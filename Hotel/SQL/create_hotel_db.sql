 --CREATE DATABASE Hotel
 --GO

USE Hotel
GO

DROP TABLE order_item
DROP TABLE bill
DROP TABLE booking
DROP TABLE product
DROP TABLE room
DROP TABLE customer
DROP TABLE staff
DROP TABLE manager
DROP TABLE [admin]

CREATE TABLE [admin](
	admin_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	phone VARCHAR(10) NOT NULL  CHECK( LEN(phone) = 10 ),
	[password] VARCHAR(255) NOT NULL,
)
GO

CREATE TABLE [manager](
	manager_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fullname NVARCHAR(255) NOT NULL,
	phone VARCHAR(10) NOT NULL  CHECK( LEN(phone) = 10 ),
	[password] VARCHAR(255) NOT NULL,
	birthdate DATETIME NOT NULL,
	gender VARCHAR(10) NOT NULL DEFAULT 'Nam',
	[address] NVARCHAR(1000),
	created_at DATETIME DEFAULT GETDATE(),
)
GO

CREATE TABLE [staff](
	staff_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fullname NVARCHAR(255) NOT NULL,
	phone VARCHAR(10) NOT NULL  CHECK( LEN(phone) = 10 ),
	[password] VARCHAR(255) NOT NULL  CHECK( LEN([password]) >= 6 ),
	birthdate DATETIME NOT NULL,
	gender NVARCHAR(10) NOT NULL DEFAULT 'Nam',
	[address] NVARCHAR(1000),
	salary BIGINT NOT NULL,
	is_labor BIT DEFAULT 1,
	is_reception BIT DEFAULT 0,
	created_at DATETIME DEFAULT GETDATE(),
)
GO   

CREATE TABLE [customer](
	customer_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fullname NVARCHAR(255) NOT NULL,
	phone VARCHAR(10) NOT NULL, CHECK( LEN(phone) = 10 ),
	identify VARCHAR(20) NOT NULL,
	pic VARCHAR(MAX),
	created_by INT FOREIGN KEY REFERENCES [staff](staff_id),
	created_at DATETIME DEFAULT GETDATE(), 
)
GO

CREATE TABLE [room] (
	room_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[name] NVARCHAR(255) NOT NULL,
	[desc] NVARCHAR(500),
	price_per_hour BIGINT NOT NULL,
)
GO

CREATE TABLE [booking](
	booking_id INT IDENTITY(1,1) PRIMARY KEY,
	[desc] VARCHAR(500),
	created_at DATETIME DEFAULT GETDATE(),
	expire_at DATETIME NOT NULL, 
	key_code VARCHAR(255) NOT NULL,
	room_id INT FOREIGN KEY REFERENCES [room](room_id),
	customer_id INT FOREIGN KEY REFERENCES [customer](customer_id),
	created_by INT FOREIGN KEY REFERENCES [staff](staff_id),
)
GO

CREATE TABLE product(
	product_id INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(255) NOT NULL,
	price BIGINT NOT NULL,
	stock INT NOT NULL, CHECK (stock >= 0),
	unit NVARCHAR(30) NOT NULL,
	created_by INT FOREIGN KEY REFERENCES [manager](manager_id) NOT NULL,
	created_at DATETIME DEFAULT GETDATE(),
	updated_at DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE order_item (
	order_item_id INT IDENTITY(1,1) PRIMARY KEY ,
	booking_id INT FOREIGN KEY REFERENCES booking(booking_id) NOT NULL,
	product_id INT FOREIGN KEY REFERENCES product(product_id) NOT NULL,
	quantity VARCHAR(10) NOT NULL, CHECK (quantity > 0),
	created_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE bill(
	booking_id INT FOREIGN KEY REFERENCES [booking](booking_id) NOT NULL,
	total_price BIGINT NOT NULL, CHECK(total_price > 0),
	[desc] VARCHAR(500),
	created_at DATETIME DEFAULT GETDATE(),
	PRIMARY KEY (booking_id)
)
GO

--------------------------- TRIGGERS ----------------------------------
            --------------------------------------

CREATE OR ALTER TRIGGER check_stock_product
ON [product]
FOR INSERT, UPDATE
AS
BEGIN
     DECLARE @error_counts INT;
	 SET @error_counts = 0;
	 SELECT @error_counts = COUNT(*)
	 FROM inserted
	 WHERE inserted.stock < 0

	 IF (@error_counts > 0)
	 BEGIN
		RAISERROR(N'Hàng tồn bắt buộc phát lớn hơn hoặc bằng 0!', 16, 1)
		ROLLBACK;
	 END
END
GO


					-----------------------------------
----------------------------------- INT DATA -----------------------------------
					-----------------------------------

------- ADMIN
INSERT INTO [admin] (phone, [password]) VALUES ('0123456789', '123456')

------- Manager
INSERT INTO manager (fullname, phone, password, birthdate, gender, address) VALUES (N'Triệu Hữu Khôi', '0123456788', '123456', '2002-1-1', 'Nam', 'Thu Duc, Ho Chi Minh')
INSERT INTO manager (fullname, phone, password, birthdate, gender, address) VALUES (N'Nhâm Việt Hải', '0123456789', '123456', '2002-1-1', 'Nam', 'Thu Duc, Ho Chi Minh')

------- Staff.Reception
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Nguyễn Văn A', '0000000001', '123456', '2002-1-1', 'Nam', 'Thu Duc, Ho Chi Minh', 8000000, 0, 1)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Lý Trường An', '0000000002', '123456', '2002-1-1', 'Nam', 'Quan 1, Ho Chi Minh', 8000000, 0, 1)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Thào Thúy Hà', '0000000003', '123456', '2002-1-1', N'Nữ', 'Quan 2, Ho Chi Minh', 8000000, 0, 1)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Dư Thùy Vân', '0000000004', '123456', '2002-1-1', N'Nữ', 'Thu Duc, Ho Chi Minh', 8000000, 0, 1)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Admin test', '0123456789', '123456', '2002-1-1', N'Nữ', 'Thu Duc, Ho Chi Minh', 8000000, 0, 1)

------- Staff.Labor
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Thôi Diễm Khuê', '0000000005', '123456', '2002-1-1', N'Nữ', 'Quan 3, Ho Chi Minh', 8000000, 1, 0)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Ngọ Xuân Lan', '0000000006', '123456', '2002-1-1', N'Nữ', 'Quan 4, Ho Chi Minh', 8000000, 1, 0)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Quàng Hương Nhi', '0000000007', '123456', '2002-1-1', N'Nữ', 'Quan 5, Ho Chi Minh', 8000000, 1, 0)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Chúng Bạch Vân', '0000000008', '123456', '2002-1-1', N'Nữ', 'Quan 6, Ho Chi Minh', 8000000, 1, 0)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Phí Bảo Hân', '0000000009', '123456', '2002-1-1', N'Nữ', 'Quan 7, Ho Chi Minh', 8000000, 1, 0)
INSERT INTO staff (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception) VALUES (N'Hoa Thiên Di', '0000000010', '123456', '2002-1-1', N'Nữ', 'Quan 8, Ho Chi Minh', 8000000, 1, 0)

------- ROOM
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 101', N'Tầng 1', 40000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 102', N'Tầng 1', 40000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 103', N'Tầng 1', 40000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 104', N'Tầng 1', 40000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 105', N'Tầng 1', 40000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 201', N'Tầng 2', 30000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 202', N'Tầng 2', 30000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 203', N'Tầng 2', 30000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 204', N'Tầng 2', 30000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 205', N'Tầng 2', 30000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 301', N'Tầng 3', 20000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 302', N'Tầng 3', 20000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 303', N'Tầng 3', 20000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 304', N'Tầng 3', 20000)
INSERT INTO room (name, [desc], price_per_hour) VALUES (N'Phòng 305', N'Tầng 3', 20000)

------ PRODUCT
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Gỏi ngó sen tôm thịt', 192000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Bó xôi xào tỏi', 160000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Trứng chiên thịt bằm', 122000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Cá điêu hồng sốt chanh ớt', 439000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Thịt kho củ cải', 144000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Canh khổ qua thịt nạc', 179000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Cơm trắng, tráng miệng, trà đá', 100000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Gỏi củ hủ dừa tôm thịt', 92000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Cải ngọt xào nấm đông cô', 10000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Trứng chiên hành tây', 222000, 100, N'Đĩa', 1)
INSERT INTO product (name, price, stock, unit, created_by) VALUES (N'Thịt kho đậu hủ', 195000, 100, N'Đĩa', 1)

------ CUSTOMER
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'An Thế Anh', '1000000001', '0123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Thế Hữu Bảo', '1000000002', '1123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Khâu Vinh Diệu', '1000000003', '2123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Hà Thành Lợi', '1000000004', '3123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Chế Phúc Tâm', '1000000005', '4123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Kim Lâm Trường', '1000000006', '5123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Thạch Chí Thành', '1000000007', '6123456789', 1)
INSERT INTO [customer] (fullname, phone, identify, created_by) VALUES (N'Lãnh Bích Chiêu', '1000000008', '7123456789', 1)
