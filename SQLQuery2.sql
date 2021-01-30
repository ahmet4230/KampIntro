--select 
select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where City = 'Berlin'

--where koşul ifadesi.
select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice desc
--^ kategori ıd'si 1 olanlar ve fiyatı düşenleri sırala.
--select "order by" sırala demek. --asc artan , desc düşen komutu.

select COUNT(*) Toplam_Urun from Products where CategoryID = 2
-- Count listede bulunan tüm ürünleri tek satır ve tek sütunda sayar.
select count (*) from Products 

select CategoryID , count(*) from Products where UnitPrice>20 group by CategoryID having count (*)<10
--^^ kategori ıd seç sırala , ürünlerden , kategori ıd ye göre grupla Unit price 20 den büyük kategori ıd içinde 10 ' dan küçük olanları sırala.

select products.ProductID , Products.ProductName ,Products.CategoryID , Products.UnitPrice , Categories.CategoryID
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID	
where Products.UnitPrice <10
-- inner join eşleşen dataları birleşirmek için kullanılır.

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
-- ürünlerdeki ürün ıd ile sipariş detaylı lsitedeki aynı verileri eşitle

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
-- nulları sadece pk ya uygularız.




