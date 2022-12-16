--Ürünün adý , tedarikçisi , kategorisinin adý , stok miktarý : ? --

--select p.ProductName , s.CompanyName , c.CategoryName , p.UnitsInStock
--from [dbo].[Products] as p
--inner join dbo.Suppliers as s on s.SupplierID=p.SupplierID
--inner join dbo.Categories as c on c.CategoryID=p.CategoryID
--where p.UnitsInStock < 10 and c.CategoryName = 'Condiments'
--order by p.ProductName

select p.ProductName , s.CompanyName , c.CategoryName , p.UnitsInStock
from [dbo].[Products] as p
inner join dbo.Suppliers as s on s.SupplierID=p.SupplierID
left  join dbo.Categories as c on c.CategoryID=p.CategoryID