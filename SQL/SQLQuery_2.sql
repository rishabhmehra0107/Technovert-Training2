USE Task1
GO

/*Basic 'Select' exercises*/
SELECT * FROM Employee;
SELECT firstname,age,salary FROM Employee;
SELECT firstname as Name FROM Employee;
SELECT firstname+' '+lastname as Name FROM Employee;


/*Using 'where' clause*/

SELECT * FROM Employee
WHERE Salary>38000;

SELECT firstname,lastname FROM Employee
where Age<24;

SELECT firstname,lastname,salary FROM Employee
where Title LIKE '%Programmer%';

SELECT lastname FROM Employee
WHERE LastName LIKE '%O%';

SELECT lastname FROM Employee
WHERE FirstName='Kelly';

SELECT * FROM Employee
WHERE LastName LIKE '%Moore';

SELECT * FROM Employee
WHERE Age>=35;


/*Using multiple 'where' clauses*/
SELECT firstname,lastname,age,salary FROM Employee
where Age>24 AND Age<43;

SELECT firstname,title,LastName FROM Employee
WHERE Age IN (28,62) AND Salary>31250;

SELECT * FROM Employee
WHERE Age<=48 AND Salary>=21520;    

SELECT firstname,age FROM Employee
WHERE FirstName LIKE 'John%' AND Salary IN (25000,35000);

/*Using 'Order By' clause*/
SELECT * FROM Employee
ORDER BY Age DESC;

SELECT * FROM Employee
ORDER BY Age;

SELECT * FROM Employee
ORDER BY Salary DESC;

SELECT * FROM Employee
ORDER BY Salary;

SELECT * FROM Employee
WHERE Age>=17
ORDER BY Salary;

SELECT * FROM Employee
WHERE Age<=34
ORDER BY Salary DESC;


/*Miscellaneous( count, sum(), max(), min())*/
SELECT * FROM Employee
ORDER BY LEN(FirstName);

SELECT COUNT(*) as Number_Of_Employees FROM Employee
WHERE Age>45;

SELECT FirstName,LastName,Title,age+5 as Age,salary-250 as Salary FROM Employee;

SELECT COUNT(*) AS Number_Of_Employees FROM Employee
WHERE LastName LIKE '%re' OR LastName LIKE '%ri' OR LastName LIKE '%ks';

SELECT AVG(salary) as Average_Salary FROM Employee; 

SELECT AVG(salary) as Average_Salary FROM Employee
WHERE Title='Fresher';

SELECT AVG(Age) as Average_Age FROM Employee
WHERE Title='Programmer';

SELECT AVG(Salary) as Average_Salary FROM Employee
WHERE Age>=35 AND Age<=50;

SELECT COUNT(*) AS Number_Of_Fresher FROM Employee
WHERE Title='Fresher';

SELECT COUNT(*)*100/(SELECT COUNT(*) FROM Employee) AS Programmers_Percentage FROM Employee
WHERE Title='Programmer';

SELECT SUM(salary) AS Combined_Salary FROM Employee
WHERE Age>=40;

SELECT SUM(salary) AS Combined_Salary FROM Employee
WHERE Title='Fresher' or Title='Programmer';

SELECT SUM(salary) AS Combined_Salary FROM Employee
WHERE Title='Fresher' AND Age>27;


/*Using Sub-Queries ( and usage of 'in' and 'between')*/
SELECT firstname,lastname,age FROM Employee
WHERE Salary<35000 AND Age=(SELECT MAX(Age) FROM Employee);

SELECT firstname+' '+lastname as Youngest_General_Manger FROM Employee
WHERE Age=(SELECT Min(Age) FROM Employee WHERE Title='General Manager') AND Title='General Manager';

SELECT * FROM Employee
WHERE Salary<35000 AND Age=(SELECT MAX(Age) FROM Employee WHERE Title='Fresher');

SELECT firstname,age FROM Employee
WHERE (FirstName LIKE 'John%' OR FirstName LIKE 'Michael%') AND (Salary BETWEEN 17000 AND 26000); 

/*Using 'Group By' and 'Having' clause*/
SELECT Count(Distinct title) as Unique_Title FROM Employee;
SELECT title,COUNT(*) as NumberOfEmployee FROM Employee
GROUP BY Title
ORDER BY COUNT(*);

SELECT title,AVG(Salary) AS Average_Salary_Of_Employees FROM Employee
GROUP BY Title;

SELECT AVG(salary) AS Average_Salary FROM Employee
WHERE Title NOT IN('Fresher');

SELECT Title,AVG(Age) AS Average_Age FROM Employee
GROUP BY Title;

SELECT Title, COUNT(*) AS Number_Of_Employees FROM Employee
WHERE Age BETWEEN 25 AND 40
GROUP BY Title;

SELECT Title,AVG(salary) AS Average_Salary FROM Employee
GROUP BY Title
HAVING AVG(Salary)>=25000;

SELECT Title,SUM(Age) AS Sum_Of_Ages FROM Employee
GROUP BY Title
HAVING SUM(Age)>30;


/*Using 'Update'*/
UPDATE Employee
SET LastName='Moore'
WHERE FirstName='Lisa' AND LastName='Ray';

UPDATE Employee
SET Age=Age-1 , Salary=Salary-5000
WHERE FirstName='Ginger' AND LastName='Finger';

UPDATE Employee
SET Title='Engineer'
WHERE Title='Programmer';

UPDATE Employee
SET Salary=Salary+3500
WHERE Salary<=30000;

UPDATE Employee
SET Salary=Salary-(15/100*Salary)
WHERE Salary>35500