--비품대장 테이블 생성 쿼리문
create table EquipmentRegister
(
EQUCode nvarchar(10),
detailName nvarchar(50) not null,
location nvarchar(20),
state nvarchar(15) default N'사용중',
purchasePrice float default 0,
purchaseDate datetime,
note nvarchar(max)

constraint PK_EQUCode primary key(EQUCode),
constraint CK_state check (state in (N'사용중',N'폐기',N'교체요망'))
)
--비품대장 테이블 EQUCode 값을 insert 하기 위해 만든 시퀀스
create sequence dbo.EquipmentNo_SEQ
as int
start with 1
increment by 1
MAXVALUE 9999999
cache;

go

--비품대장에 insert시키는 프로시저
create procedure dbo.InsertEquipment_PROC
@detailName nvarchar(50),
@location nvarchar(20),
@purchasePrice float,
@purchaseDate datetime,
@note nvarchar(max)
as
if @location ='' begin set @location =null end;
if  @note ='' begin set @note =null end;

insert into dbo.EquipmentRegister(EQUCode,detailName,location,purchasePrice,purchaseDate,note) values (
'EQU'+ REPLICATE('0',7  - LEN(next value for dbo.EquipmentNO_SEQ))+ convert(nvarchar, next value for dbo.EquipmentNO_SEQ),
@detailName,
@location,
@purchasePrice,
@purchaseDate,
@note);
