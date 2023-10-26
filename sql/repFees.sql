CREATE PROCEDURE repFees
AS
BEGIN
	SELECT Fee.FeeID, Student.firstName, Student.lastName, Student.gender, Class.className,
	Fee.DOR, Fee.Amount, Months.Months 
	FROM Fee	
	inner join Class on Fee.classID = Class.classID
	inner join Student on Fee.FNameID = Student.studentID
	inner join Months on Fee.MonthID = Months.MonthID	
END