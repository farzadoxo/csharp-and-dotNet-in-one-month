SELECT p.Name AS 'نام شرکت', COUNT(u.Id) AS 'تعداد واحد ها'
FROM Projects AS p
JOIN Units AS u
ON  u.ProjectId = p.Id
GROUP BY p.Name

-------------------------------------------------------------------------------

SELECT * FROM Units
WHERE Units.ProjectId = '12d955e4-5308-46b5-8bfe-0190d6999da0'

-------------------------------------------------------------------------------

SELECT p.Name AS 'نام شرکت' , COUNT(r.Id) AS 'تعداد رزیدنت ها'
FROM Projects AS p
JOIN ResidentProjects AS rp
ON p.Id = rp.ProjectId
JOIN Residents AS r
ON r.Id = rp.ResidentId
GROUP BY P.Name

-------------------------------------------------------------------------------

SELECT p.Name AS 'نام پروژه', COUNT(pl.Id) AS 'تعداد پلاک ها '
FROM Projects AS p
JOIN Units AS u
ON P.Id = u.ProjectId
JOIN Plates AS pl
ON pl.UnitId = u.Id
GROUP BY P.Name

-------------------------------------------------------------------------------

SELECT u.Number AS 'شماره واحد' , COUNT(r.Id) AS 'تعداد رزیدنت ها'
FROM Units AS u
JOIN ResidentUnits AS ru
ON u.Id = ru.UnitId
JOIN Residents AS r
ON ru.ResidentId = r.Id
GROUP BY u.Number

-------------------------------------------------------------------------------

SELECT u.Number AS 'شماره واحد' , COUNT(pl.Id) AS 'تعداد پلاک ها'
FROM Units AS u
JOIN Plates AS pl
ON u.Id = pl.UnitId
GROUP BY u.Number


-------------------------------------------------------------------------------

SELECT r.FirstName , COUNT(p.Id) AS 'تعداد پلاک'
FROM Residents AS r
JOIN ResidentUnits AS ru
ON r.Id = ru.ResidentId
JOIN Plates as p
ON P.ResidentId = ru.ResidentId
GROUP BY r.FirstName
