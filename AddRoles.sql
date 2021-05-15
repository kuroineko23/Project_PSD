DBCC CHECKIDENT ('[Roles]', RESEED, 0)
GO
insert into dbo.Roles(Name) values ('Seller'),('Member')
