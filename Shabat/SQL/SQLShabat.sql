--����  �� ������ �������  ��� ���� ��� ���� ������ 
CREATE TABLE Guests (id INT  PRIMARY KEY IDENTITY,Name VARCHAR(30));

--���� �� �������� ������� ��� ���� ��� �� �������
CREATE TABLE Categories (id INT  PRIMARY KEY IDENTITY,Name VARCHAR(30));

--���� �� ���� ������� ��� ���� ����, ��� ���� �� �������, ���� ���� �� �����
CREATE TABLE Foods (id INT  PRIMARY KEY IDENTITY,
Name VARCHAR(50),
category_id int foreign key  REFERENCES Categories(id),
guests_id int foreign key  REFERENCES Guests(id));


-- ����� ��� �������� ����� ������ ��� ������ ����
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


-- ����� ��� ����� ���� ������ ��� ������ ����
declare @person_name varchar(100) = '����� ���' , @person_answer varchar(100);
IF NOT EXISTS (SELECT name FROM Guests WHERE Name = @person_name )
BEGIN
    INSERT INTO Guests (name) VALUES (@person_name);
END
--ELSE
--BEGIN
--    select @answer =  'Guest already exists';
--	select @answer;
--END;


-- ����� ������� ��� ������ �����
declare @filter varchar(100);
SELECT name FROM Categories
where name like '%' + @filter + '%'


--����� �� ��� ����� �� �������� ��� ����� ���� ����� �� �����
DECLARE @food_name VARCHAR(100), @category_name VARCHAR(100), @guest_name VARCHAR(100);
DECLARE @category_code int, @guest_code int;
SELECT @category_code = (SELECT id from Categories where name = @category_name)
SELECT @guest_code = (SELECT id from Guests where name = @guest_name)

if (@category_code is not null and @guest_code is not null )
begin 
     insert into Foods Valuse(@food_name , @category_code, @guest_code) 
end
--������ ������ ������ �� �� ����� ������ ����� ��������
DECLARE @category_name VARCHAR(100) = '';

SELECT Foods.Name,  COUNT(*) AS Quantity
FROM Foods  As foods 
JOIN Categories ON Foods.category_id = Categories.id
WHERE Categories.Name = @category_name
GROUP BY Foods.Name;

--������ ������ ������ ����� �� �� ���� ���
DECLARE @category_name2 VARCHAR(100);
DECLARE @guest_name2 VARCHAR(100);

SELECT f.Name , COUNT(*) AS Quantity
FROM Foods  As f
JOIN Categories as c ON f.category_id = c.id 
JOIN Guests as g on g.id =f.guests_id
WHERE c.Name = @category_name2 AND g.Name = @guest_name2
GROUP BY f.Name

--������ ������ ������ ����� �� ��� ��� ��� ���� ���
DECLARE @category_name3 VARCHAR(100);
DECLARE @guest_name3 VARCHAR(100);

SELECT f.Name , COUNT(*) AS Quantity
FROM Foods  As f
JOIN Categories as c ON f.category_id = c.id 
JOIN Guests as g on g.id =f.guests_id
WHERE c.Name = @category_name3 AND g.Name != @guest_name3
GROUP BY f.Name

-- ����� ������ ����� ������
INSERT INTO Guests (Name) VALUES 
('��� ���'),
('��� ���'),
('����� ����'),
('��� ���'),
('����� ���');

-- ����� ������ ����� ��������
INSERT INTO Categories (Name) VALUES 
('��� ������'),
('��� ������'),
('�����'),
('����'),
('���'),
('�����'),
('�����'),
('�����'),
('������'),
('�����'),
('����� ������'),
('�����'),
('����� ����'),
('�����'),
('����'),
('�������'),
('�����'),
('�����'),
('������'),
('������'),
('���� �������'),
('����'),
('�������'),
('������'),
('�����'),
('������'),
('������'),
('������'),
('�������'),
('���');


-- ����� ������ ����� ����
INSERT INTO Foods (Name, category_id, guests_id) VALUES 
('��� �����', 6, 1),
('���� ��', 4, 2),
('�����', 5, 3),
('��� �����', 8, 4),
('���� ������', 3, 5),
('����', 7, 1),
('������', 9, 2),
('�����', 5, 3),
('��� ���', 8, 4),
('�������', 10, 5);

