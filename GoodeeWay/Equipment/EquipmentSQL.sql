--비품대장 테이블 생성 쿼리문
create table EquipmentRegister
(
EQUCode nvarchar(10),
detailName nvarchar(50) not null,
location nvarchar(20),
state nvarchar(15) default '사용중',
purchasePrice float default 0,
purchaseDate datetime,

constraint PK_EQUCode primary key(EQUCode),
constraint CK_state check (state in ('사용중','폐기','교체요망'))
)