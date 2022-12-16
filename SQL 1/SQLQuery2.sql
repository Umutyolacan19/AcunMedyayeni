select m.Id , m.Adi , m.Soyadi from BaslangicTable as m
--select m.* from BaslangicTable as m

select top(1) Id , Adi as [Adý], Soyadi as [Soyadý] from BaslangicTable
select Id , Adi as [Adý], Soyadi as [Soyadý] from BaslangicTable

select Id, Adi + '' + Soyadi as [Adý Soyadý] from BaslangicTable


