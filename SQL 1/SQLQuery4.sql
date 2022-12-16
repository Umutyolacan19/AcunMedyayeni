--select * from Kategoriler
--select * from Kitaplar
--select * from Yazarlar

--insert into dbo.Kategoriler values ('Korku')
--insert into dbo.Kitaplar values ('O','1256','Stephen King','4')
--insert into dbo.Yazarlar values ('Dan Brown')


select k.*, ka.KategoriAdi
from dbo.Kitaplar as k
inner join dbo.Kategoriler as ka on ka.KategoriID=k.KategoriID

--select k.*, ka.KategoriAdi
--from dbo.Kitaplar as k
--Right join dbo.Kategoriler as ka on ka.KategoriID=k.KategoriID

--select k.*, ka.KategoriAdi
--from dbo.Kitaplar as k
--full outer join dbo.Kategoriler as ka on ka.KategoriID=k.KategoriID


--update dbo.Kitaplar set Yazar=NULL

select * k.KitapAdi, s.SayfaSayisi, y.YazarAdi
from dbo.Kitaplar as k
inner join dbo.Yazarlar as y on y.YazarID=k.YazarID
inner join dbo.Kategoriler as ka on ka.KategoriID=k.KategoriID
