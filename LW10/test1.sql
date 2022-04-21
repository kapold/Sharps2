USE universityDB;

INSERT INTO Addresses(ID, City, C_Index, Street, Home)
	VALUES(1, 'City', 223232, 'stre', 'hom');

INSERT INTO Students(AddressID, Name, Surname, Patronymic, Speciality, Birthday, Course, GroupNumber, Gender, PhoneNumber, ImageSrc)
	VALUES(1, 'Anton', 'Adamovich', 'Maksimovich', 'Spec', '2022-04-20', 2, 7, 'Male', '375298689745', 'lala');
