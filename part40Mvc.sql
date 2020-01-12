Create table tblEmployee
(
 Id int primary key identity,
 FullName nvarchar(100),
 Gender nvarchar(10),
 Age int,
 HireDate DateTime,
 EmailAddress nvarchar(100),
 Salary int,
 PersonalWebSite nvarchar(100)
)