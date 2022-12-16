--select * from [dbo].[UrunKategori_vw]


--- var olan view i güncellemek için alter kullanýlýr. ---

--create view dbo.KategoriSatisTutarlari
alter view dbo.KategoriSatisTutarlari
as

select c.CategoryName , SUM(o.UnitPrice) as SiparisToplami
from dbo.OrderDetails as o
inner join dbo.Products as p on p.ProductID=o.ProductID
inner join dbo.Categories as c on c.CategoryID=P.CategoryID
group by c.CategoryName


select * from dbo.KategoriSatisTutarlari order by SiparisToplami