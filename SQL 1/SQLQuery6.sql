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


--select ProductID , ProductName , (select SUM(o.Quantity) from dbo.OrderDetails as o where o.ProductID=p.ProductID) as [Sipari� Adedi]
--from dbo.Products as p


--select OrderID as [Sipari� No] , OrderDate as [Sipari� Tarihi] , (select SUM(od.UnitPrice) from OrderDetails as od where od.OrderID=o.OrderID) as [Toplam Tutar] from Orders as o


--select Country from dbo.Customers group by Country
--select Country , City from dbo.Customers group by Country , City

--select Country 
--from dbo.Customers
----Join
--where Country ='Brazil'
--group by Country , City
--order by City


--select Country , COUNT(Country) as [M��teri Say�s�] from dbo.Customers group by Country


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


--HANG� KATEGOR�DEN KA� TANE �R�N VAR ? --

--select p.CategoryID , COUNT(p.CategoryName) as UrunSayisi
--from dbo.Products as p
--inner join dbo.Categories as c on c.CategoryID=p.CategoryID
--where c.CategoryName like 'C%'
--group by c.CategoryName
--having COUNT(c.CategoryName)>10
--order by COUNT (c.CategoryName) desc


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


-- KATEGOR� ADI , S�PAR�� TUTARI , TUTAR ALANINA G�RE B�Y�KTEN K����E SIRALANACAK : --

select c.CategoryName , SUM(o.UnitPrice) as SiparisToplami
from dbo.OrderDetails as o
inner join dbo.Products as p on p.ProductID=o.ProductID
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
group by c.CategoryName
order by SiparisToplami desc 

