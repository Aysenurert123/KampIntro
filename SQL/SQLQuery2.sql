--Select
--ANSI
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive--> büyük küçük harf duyarlı  

Select * from Products where categoryId=1 or categoryId=3

-- <> farklı

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products order by UnitPrice asc  --ascending--> artan küçükten büyüğe

select * from Products order by UnitPrice desc  --descending--> düşen büyükten küçüğe

select * from Products where categoryId=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryId = 2

--Hangi kategoride kaç farklı ürün var?

select categoryID, count(*) from products group by CategoryID

--ürün sayısı 10 dan az olan kategorileri listele?

select categoryID, count(*) from products group by CategoryID having count(*)<10

select categoryID, count(*) from products where UnitPrice>20
group by CategoryID having count(*)<10

--join(birleştirmek)

select * 
from Products inner join Categories on 
Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on 
Products.CategoryID = Categories.CategoryID


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on 
Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- DTO Data Transformation Object

--inner join sadece eşleşen kayıtları getirir

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

--2155 tane

select * from [Order Details]

--Hiç satış yapamadığımız ürünleri getirmek için (eşleşmeyen)
--left solda olup sağda olmayanları da getir

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c inner join Orders o 
on c.CustomerID=o.CustomerID

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID

--sisteme kayıt olmuş ama ürün almamış kampanya uygulanacak kişiler

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null 

--müşterilerde olup siparişleride olmayan olduğu için birşey gelmez

select * from Customers c right join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

