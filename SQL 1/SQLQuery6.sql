--select 'CUST' as [Type] , CustomerID , CompanyName , ContactName , ContactTitle from dbo.Customers
--union all
--select 'SUPP' as [Type] , SuppliersID , ContactName , [Address] from dbo.Suppliers
--order by CompanyName



--select * from
--(select 'CUST' as [Tip] , CompanyName as Unvan , ContactName as Yetkili , ContactTitle as YetkiliUnvan from dbo.Customers

--union all

--select 'SUPP' as [Tip] , CompanyName as Unvan , ContactName as Yetkili , ContactTitle as YetkiliUnvan from dbo.Suppliers) as YeniListe
--where Tip = 'CUST'
--order by Unvan 


--select ProductID , ProductName , (select SUM(o.Quantity) from dbo.OrderDetails as o where o.ProductID=p.ProductID) as [Sipariþ Adedi]
--from dbo.Products as p


--select OrderID as [Sipariþ No] , OrderDate as [Sipariþ Tarihi] , (select SUM(od.UnitPrice) from OrderDetails as od where od.OrderID=o.OrderID) as [Toplam Tutar] from Orders as o


--select Country from dbo.Customers group by Country
--select Country , City from dbo.Customers group by Country , City

--select Country 
--from dbo.Customers
----Join
--where Country ='Brazil'
--group by Country , City
--order by City


--select Country , COUNT(Country) as [Müþteri Sayýsý] from dbo.Customers group by Country


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


--HANGÝ KATEGORÝDEN KAÇ TANE ÜRÜN VAR ? --

--select p.CategoryID , COUNT(p.CategoryName) as UrunSayisi
--from dbo.Products as p
--inner join dbo.Categories as c on c.CategoryID=p.CategoryID
--where c.CategoryName like 'C%'
--group by c.CategoryName
--having COUNT(c.CategoryName)>10
--order by COUNT (c.CategoryName) desc


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


-- KATEGORÝ ADI , SÝPARÝÞ TUTARI , TUTAR ALANINA GÖRE BÜYÜKTEN KÜÇÜÐE SIRALANACAK : --

select c.CategoryName , SUM(o.UnitPrice) as SiparisToplami
from dbo.OrderDetails as o
inner join dbo.Products as p on p.ProductID=o.ProductID
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
group by c.CategoryName
order by SiparisToplami desc 

