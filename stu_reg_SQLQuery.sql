Create database StudentRegistaion

CREATE TABLE StuReg(
    StudentName VARCHAR(100) NOT NULL,
    StudentCode VARCHAR(20) PRIMARY KEY,
    Department VARCHAR(50),
    Gender VARCHAR(10),
    EmailID VARCHAR(100) UNIQUE,
    DOB DATE
);


insert into StuReg values('Bhuvanesh','001','IT','Male','bhuvan0890@gmail.com', '2000-03-28')
insert into StuReg values ('jeeva','002','Flutter','Male','jeevakv37@gmail.com', '2000-03-30')



select * from StuReg

DELETE FROM StuReg
WHERE StudentCode = 2;
