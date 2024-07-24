--טבלה  של אורחים שמחזיקה  קוד זהות ושם פרטי ומשפחה 
CREATE TABLE Guests (id INT  PRIMARY KEY IDENTITY,Name VARCHAR(30));

--טבלה של קטגוריות שמחזיקה קוד זהות ושם של קטגוריה
CREATE TABLE Categories (id INT  PRIMARY KEY IDENTITY,Name VARCHAR(30));

--טבלה של אוכל שמחזיקה קוד זהות עצמי, קוד זהות של קטגוריה, וקוד זהות של האורח
CREATE TABLE Foods (id INT  PRIMARY KEY IDENTITY,
Name VARCHAR(50),
category_id int foreign key  REFERENCES Categories(id),
guests_id int foreign key  REFERENCES Guests(id));


-- בדיקה האם הקטגוריה קיימת ובמקרה שלא להוסיף אותה
declare @name varchar(100) = '' , @answer varchar(100);
IF NOT EXISTS (SELECT name FROM Categories WHERE Name = @name )
BEGIN
    INSERT INTO Categories (name) VALUES (@name);
END
--ELSE
--BEGIN
--    select @answer =  'Guest already exists';
--	select @answer;
--END;


-- בדיקה האם האורח קיים ובמקרה שלא להוסיף אותה
declare @person_name varchar(100) = 'יהודה כהן' , @person_answer varchar(100);
IF NOT EXISTS (SELECT name FROM Guests WHERE Name = @person_name )
BEGIN
    INSERT INTO Guests (name) VALUES (@person_name);
END
--ELSE
--BEGIN
--    select @answer =  'Guest already exists';
--	select @answer;
--END;


-- חיפוש קטגוריה לפי סטרינג מסוים
declare @filter varchar(100);
SELECT name FROM Categories
where name like '%' + @filter + '%'


--הכנסה של קוד הזהות של הקטגוריה ושל האורח לתוך הטבלה של האוכל
DECLARE @food_name VARCHAR(100), @category_name VARCHAR(100), @guest_name VARCHAR(100);
DECLARE @category_code int, @guest_code int;
SELECT @category_code = (SELECT id from Categories where name = @category_name)
SELECT @guest_code = (SELECT id from Guests where name = @guest_name)

if (@category_code is not null and @guest_code is not null )
begin 
     insert into Foods Valuse(@food_name , @category_code, @guest_code) 
end
--שאילתה שתחזיר למשתמש את כל האוכל שהוזמן מאותה הקטגוריה
DECLARE @category_name VARCHAR(100) = '';

SELECT Foods.Name,  COUNT(*) AS Quantity
FROM Foods  As foods 
JOIN Categories ON Foods.category_id = Categories.id
WHERE Categories.Name = @category_name
GROUP BY Foods.Name;

--שאילתה שתחזיר למשתמש סיכום של מה שהוא בחר
DECLARE @category_name2 VARCHAR(100);
DECLARE @guest_name2 VARCHAR(100);

SELECT f.Name , COUNT(*) AS Quantity
FROM Foods  As f
JOIN Categories as c ON f.category_id = c.id 
JOIN Guests as g on g.id =f.guests_id
WHERE c.Name = @category_name2 AND g.Name = @guest_name2
GROUP BY f.Name

--שאילתה שתחזיר למשתמש סיכום של הכל חוץ ממה שהוא בחר
DECLARE @category_name3 VARCHAR(100);
DECLARE @guest_name3 VARCHAR(100);

SELECT f.Name , COUNT(*) AS Quantity
FROM Foods  As f
JOIN Categories as c ON f.category_id = c.id 
JOIN Guests as g on g.id =f.guests_id
WHERE c.Name = @category_name3 AND g.Name != @guest_name3
GROUP BY f.Name

-- הכנסת נתונים לטבלת אורחים
INSERT INTO Guests (Name) VALUES 
('אבי כהן'),
('דנה לוי'),
('מיכאל רוזן'),
('יעל פרץ'),
('רונית שחר');

-- הכנסת נתונים לטבלת קטגוריות
INSERT INTO Categories (Name) VALUES 
('מנה ראשונה'),
('מנה עיקרית'),
('קינוח'),
('דגים'),
('בשר'),
('סלטים'),
('לחמים'),
('מרקים'),
('תוספות'),
('שתייה'),
('ירקות קלויים'),
('פסטות'),
('תפוחי אדמה'),
('חומוס'),
('סושי'),
('מוקפצים'),
('מאפים'),
('פירות'),
('אגוזים'),
('גבינות'),
('דגים מעושנים'),
('פיצה'),
('בורקסים'),
('גלידות'),
('רטבים'),
('קטניות'),
('גרנולה'),
('עוגיות'),
('טורטיות'),
('קפה');


-- הכנסת נתונים לטבלת אוכל
INSERT INTO Foods (Name, category_id, guests_id) VALUES 
('סלט ירקות', 6, 1),
('פילה דג', 4, 2),
('שניצל', 5, 3),
('מרק ירקות', 8, 4),
('עוגת שוקולד', 3, 5),
('פיתה', 7, 1),
('קוסקוס', 9, 2),
('סטייק', 5, 3),
('מרק עוף', 8, 4),
('לימונדה', 10, 5);

