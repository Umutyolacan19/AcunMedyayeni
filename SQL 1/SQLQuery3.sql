--select * from [dbo].[Customers] where CompanyName like 'A%'
--select * from [dbo].[Customers] where CompanyName like 'AN%'
--select * from [dbo].[Customers] where CompanyName like '%AN%'
--select * from [dbo].[Customers] where City like '%on'

--select * from Customers where CompanyName='Around the Horn'

--select * from Customers where Country <> 'UK' and PostalCode='44000'

--select * from Customers where PostalCode='44000' or PostalCode='67000' -- postal kodu aral���
--select * from Customers where PostalCode in ('44000','67000') -- postal kodu '' olan
--select * from Customers where PostalCode not in ('44000','67000') --postal kodu '' olmayan

--select * from Products where UnitsInStock < 10 -- stok miktar� b�y�k
--select * from Products where UnitsInStock < '10' 
--select * from Products where UnitsInStock > 10 -- stok miktar� k���k
--select * from Products where UnitsInStock <= 10 --stok miktar� b�y�k e�it
--select * from Products where UnitsInStock between 10 and 30 --stok miktar� aral�k
--select * from Products where UnitsInStock > 10 and UnitsInStock <=30 --stok miktar� aral�k

--select * from Products where Discontinued = 1 and UnitPrice > 50


--select * from Products order by UnitPrice
--select * from Products where UnitPrice > 5 order by UnitPrice
--select * from Products where UnitPrice > 5 order by UnitPrice asc
--select * from Products where UnitPrice > 5 order by UnitPrice desc

--select * from Products where UnitPrice > 5 order by ProductName asc
--select * from Products where UnitPrice > 5 order by ProductName desc

--select * from Products where UnitPrice > 5 order by CategoryID , UnitPrice desc

--select * from Orders where ShipRegion is null
--select * from Orders where ShipRegion is not null

--select top 5 * from dbo.Products where CategoryID = 8 and UnitsInStock < 50 order by ProductName asc

--select top 10 * from dbo.Products order by UnitPrice 