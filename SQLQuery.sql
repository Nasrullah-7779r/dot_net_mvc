CREATE TABLE Member (
    EmployeeCode NVARCHAR(255) Primary key,
	FirstName NVARCHAR(255),
    LastName NVARCHAR(255),
    Experience NVARCHAR(255),
    Department NVARCHAR(255),
    City NVARCHAR(255),
    Email NVARCHAR(255),
    ContactNumber NVARCHAR(20),
    Gender NVARCHAR(10),
    EmployeeType NVARCHAR(50)
);

select * from Member
delete from Member

EXEC sp_rename 'Member.Experience', 'Experties', 'COLUMN';

/*drop table Member*/

SELECT EmployeeCode, FirstName, LastName, Experties, Department  FROM Member