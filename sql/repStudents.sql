CREATE PROCEDURE repStudents
AS
BEGIN
	SELECT Student.studentID, Student.firstName, Student.lastName, Student.email, Student.mobile, Student.gender,
	Student.dob, Student.dor, Class.className, Country.countryName, County.countyName, Town.townName 
	FROM Student
	inner join Class on Student.classID = Class.classID
	inner join Country on Student.countryID = Country.countryID
	inner join County on Student.countyID = County.countyID
	inner join Town on Student.townID = Town.townID
END