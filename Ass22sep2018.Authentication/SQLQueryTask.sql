/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [Auth1].[dbo].[AspNetRoles]

  use Auth1
  select * from dbo.AspNetRoles
  select * from dbo.AspNetUserClaims
  select * from AspNetUserClaims
    select * from AspNetUserLogins
	    select * from AspNetUserroles
		    select * from aspnetusers
			

insert into   AspNetRoles(Id,Name) values(1,'Product');
insert into   AspNetRoles(Id,Name) values(2,'Orders');
insert into   AspNetRoles(Id,Name) values(3,'User');
insert into   AspNetUserroles(UserId,RoleId) values('de203336-7b8c-41ca-94c8-8b0f2c8e1826',3);
insert into   AspNetUserroles(UserId,RoleId) values('34cc77da-af4f-44e5-b144-97595c171088',1);
insert into   AspNetUserroles(Id,Name) values(2,'Orders');
insert into   AspNetUserroles(UserId,RoleId) values('44d0484c-3d7c-4a7d-94aa-b5ee4256f3cd',2);
insert into   AspNetUserroles(UserId,RoleId) values('62772ab7-7e08-4cba-8c3d-bfe99cedc70f',2);
insert into   AspNetUserroles(UserId,RoleId) values('c5ccd7f6-ac33-40e5-92c3-31a7a2997af3',1);
insert into   AspNetUserroles(UserId,RoleId) values('4e486daa-3047-4b7d-982a-95b4c23b5b49',1);
insert into   AspNetUserroles(UserId,RoleId) values('24d8a24b-18f2-48e4-ac42-696e5f58de24',1);

Create table Products(ProductId int primary key identity(1,1) ,PName nvarchar(50),Price float,ImageUrl nvarchar(100),Description nvarchar(500),BrandId int foreign key(BrandId) references Brands (BrandId)  )
select * from Products
drop table products

Create table Brands(BrandId int primary key  ,BrandName nvarchar(50)) 
select * from Brands
insert into Brands(BrandId,BrandName) values(1,'samsumg')
insert into Brands(BrandId,BrandName) values(2,'Iphone')
insert into Brands(BrandId,BrandName) values(3,'mi')
insert into Brands(BrandId,BrandName) values(4,'motrola')
insert into Brands(BrandId,BrandName) values(5,'others')


select price from Products group by Pname







--drop table products
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('OnePlus6',40000,'Content/bgr-oneplus-5t-1.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',5);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('MiA1',15000,'Content/Redmi-Black-A1-64-MB-SDL171943867-3-1f01f.jpeg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',3);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('samsung',10000,'Content/final-samsung.jpg.optimal.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',1);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('HTB',4000,'Content/HTB1EtU0SXXXXXaUaXXXq6xXFXXXT.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',5);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('IphoneX',85000,'Content/iphone-x-with-different-views-in-realistic-style_23-2147849865.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',2);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('SonyXperia',35000,'Content/sony-xperia-xa1-ultra-2017-3.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',5);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('XperiaSolo',25000,'Content/Xperia%20Solo.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',5);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('JioMobile',4000,'Content/81d30942bb844851b88d30aea956ab4a7ab83852_rsz_qty_70_900x900.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',5);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('samsungchamp',7000,'Content/20171119203153.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',1);
insert into products(Pname,Price,ImageUrl,Description,BrandId) values('Motrola',17000,'Content/1523355424572.jpg','6GB RAM, 64GB Internal Memory, Dual Nano SIM and Many More Features. Order Now! Exclusive Cashbacks. Low Prices. Pay on Delivery. No Cost EMI Available. Easy Returns. Huge Selection. 100% Purchase Protection. Great Value for Money.',4);



alter procedure cartproc 
(@ProductId int,@PName nvarchar(50),@Price float ,@ImageUrl nvarchar(100),@Description nvarchar(500),@BrandId int ,@Action VARCHAR(10))
as begin
set nocount on;
--select
if @Action= 'SELECT'
begin
select * from Products
end

---Insert
if @Action= 'INSERT'
begin
insert into Products(Pname,Price,ImageUrl,Description,BrandId) values(@PName,@Price,@ImageUrl,@Description,@BrandId)
end
----Update
if @Action='UPDATE'
begin
Update Products set Pname =@PName,Price=@Price,ImageUrl=@ImageUrl,Description=@Description,BrandId=@BrandId where
ProductId= @ProductId
end
--delete
if @Action='Delete'
begin
 DELETE FROM Products WHERE ProductId = @ProductId
 end
 end




