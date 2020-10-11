USE master;
GO
DROP DATABASE IF EXISTS CS;
GO

CREATE DATABASE CS;
GO

USE CS;
CREATE TABLE Stu (
-- 学生信息
	sno VARCHAR(20) NOT NULL PRIMARY KEY, 
	sname VARCHAR(40) NOT NULL, 
	sex VARCHAR(10) NOT NULL,
	birth DATE,
	sdept VARCHAR(40) NOT NULL,
);


CREATE TABLE Cou (
-- 课程信息
	cno VARCHAR(20) NOT NULL PRIMARY KEY,
	cname VARCHAR(40) NOT NULL,
	credit INT NOT NULL,
	start_week INT NOT NULL, -- 第几周到第几周
	end_week INT NOT NULL ,
	CHECK (end_week >= start_week),

	day_week INT NOT NULL, -- 周几上课

	start_time INT NOT NULL,
	end_time INT NOT NULL,	-- 上课时间和下课时间
	CHECK (end_time >= start_time),

	tno INT NOT NULL,
	tname VARCHAR(40) NOT NULL, 
);

CREATE TABLE SC (
-- 学生选课信息
	sno VARCHAR(20) NOT NULL,
	cno VARCHAR(20) NOT NULL,
	sta INT NOT NULL,
	-- 记录选课状态, 0为临时保存，1为确认提交
);


INSERT INTO Stu VALUES (1120189999, '狂徒张三', '男', '2000-10-01', '计算机科学与技术');
INSERT INTO Stu VALUES (1120188888, 'GG', '男', '2000-10-2', '计算机科学与技术');
INSERT INTO Stu VALUES (1, '张总', '男', '2000-10-3', '计算机科学与技术');

INSERT INTO Cou VALUES (22021101, '操作系统', 3, 1, 12, 2, 3,5, 000562, '阿信');
INSERT INTO Cou VALUES (22021102, '面向对象', 4, 1, 12, 3, 3,5, 000562, '阿信');
INSERT INTO Cou VALUES (22021103, '组合数学', 5, 1, 12, 4, 3,5, 000562, '阿信');

INSERT INTO SC VALUES (1120189999,22021101, 1);

