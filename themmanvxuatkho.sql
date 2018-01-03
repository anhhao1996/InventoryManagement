alter table XUATKHO add MANV nvarchar(50)
alter table XUATKHO add foreign key(MANV) references NHANVIEN(MANV)