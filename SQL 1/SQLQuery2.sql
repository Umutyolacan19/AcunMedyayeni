select m.Id , m.Adi , m.Soyadi from BaslangicTable as m
--select m.* from BaslangicTable as m

select top(1) Id , Adi as [Ad�], Soyadi as [Soyad�] from BaslangicTable
select Id , Adi as [Ad�], Soyadi as [Soyad�] from BaslangicTable

select Id, Adi + '' + Soyadi as [Ad� Soyad�] from BaslangicTable


