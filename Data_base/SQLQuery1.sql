/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   NAME                 varchar(25)          null,
   ADDRESS              varchar(45)          null,
   BANK_CODE            numeric              not null,
   ADMIN_CODE           numeric              null,
   constraint PK_BANK primary key (BANK_CODE)
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCH_NUMBER        numeric              not null,
   BANK_CODE            numeric              null,
   ADDRESS              varchar(45)          null,
   ADMIN_CODE           numeric              null,
   SSN                  numeric              null,
   EMPID                numeric              null,
   constraint PK_BRANCH primary key (BRANCH_NUMBER)
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   NAME                 varchar(25)          null,
   PHONE                numeric              null,
   SSN                  numeric              not null,
   EMPID                numeric              null,
   BRANCH_NUMBER        numeric              null,
   ADDRESS              varchar(45)          null,
   constraint PK_CUSTOMER primary key (SSN)
)
go

/*==============================================================*/
/* Table: EMPLOYER                                              */
/*==============================================================*/
create table EMPLOYER (
   EMPID                numeric              not null,
   NAME                 varchar(25)          null,
   POSITION             varchar(25)          null,
   constraint PK_EMPLOYER primary key (EMPID)
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOAN_NUM             numeric              not null,
   BRANCH_NUMBER        numeric              null,
   LOAN_TYPE            varchar(25)          null,
   LOAN_AMOUNT          numeric              null,
   EMPID                numeric              null,
   SSN                  numeric              null,
   constraint PK_LOAN primary key (LOAN_NUM)
)
go


/*############################################################*/
/* Add the primary keys and forign keys*/
/*############################################################*/

alter table ACCOUNT
   add constraint FK_ACCOUNT_REFERENCE_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BANK
   add constraint FK_BANK_REFERENCE_ADMIN foreign key (ADMIN_CODE)
      references ADMIN (ADMIN_CODE)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_BANK foreign key (BANK_CODE)
      references BANK (BANK_CODE)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_ADMIN foreign key (ADMIN_CODE)
      references ADMIN (ADMIN_CODE)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_REFERENCE_EMPLOYER foreign key (EMPID)
      references EMPLOYER (EMPID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_REFERENCE_BRANCH foreign key (BRANCH_NUMBER)
      references BRANCH (BRANCH_NUMBER)
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_BRANCH foreign key (BRANCH_NUMBER)
      references BRANCH (BRANCH_NUMBER)
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_EMPLOYER foreign key (EMPID)
      references EMPLOYER (EMPID)
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go



ALTER TABLE EMPLOYER
add password varchar(50) NOT NULL

ALTER TABLE CUSTOMER
add password varchar(50)

ALTER TABLE LOAN
add Status varchar(10) Default 'pending'

select * from CUSTOMER
select * from ADMIN
select * from EMPLOYER
select * from BANK
select * from BRANCH
select * from ACCOUNT
select * from LOAN


select balance from account where ssn = 45

insert into LOAN(LOAN_NUM, BRANCH_NUMBER, LOAN_TYPE, LOAN_AMOUNT,EMPID, SSN) values(3,1,'Commercial',900000,1,3)
insert into BRANCH values(5,1,'Cr7',123,1,1)
insert into CUSTOMER values('Yousef',01236545654,77,1,1,'test city','Zxc123')

Update LOAN
SET Status = 'pending'
WHERE LOAN_NUM = 3

Update CUSTOMER
SET EMPID = 1
WHERE SSN = 1

select * from loan where Status = 'pending'

Update customer set name = '3alawy', phone = 01236547896, address = '7abiby', password = 123 where ssn = 45

SELECT L.*, C.name as Customer_Name, E.NAME as Employee_Name
FROM LOAN AS L 
JOIN CUSTOMER AS C ON L.SSN = C.SSN
JOIN EMPLOYER as E ON E.EMPID = L.EMPID