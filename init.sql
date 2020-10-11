USE master;
GO
DROP DATABASE IF EXISTS CS;
GO

CREATE DATABASE CS;
GO

USE CS;
CREATE TABLE Stu (
-- ѧ����Ϣ
	sno VARCHAR(20) NOT NULL PRIMARY KEY, 
	sname VARCHAR(40) NOT NULL, 
	sex VARCHAR(10) NOT NULL,
	birth DATE,
	sdept VARCHAR(40) NOT NULL,
);


CREATE TABLE Cou (
-- �γ���Ϣ
	cno VARCHAR(20) NOT NULL PRIMARY KEY,
	cname VARCHAR(40) NOT NULL,
	credit INT NOT NULL,
	start_week INT NOT NULL, -- �ڼ��ܵ��ڼ���
	end_week INT NOT NULL ,
	CHECK (end_week >= start_week),

	day_week INT NOT NULL, -- �ܼ��Ͽ�

	start_time INT NOT NULL,
	end_time INT NOT NULL,	-- �Ͽ�ʱ����¿�ʱ��
	CHECK (end_time >= start_time),

	tno INT NOT NULL,
	tname VARCHAR(40) NOT NULL, 
);

CREATE TABLE SC (
-- ѧ��ѡ����Ϣ
	sno VARCHAR(20) NOT NULL,
	cno VARCHAR(20) NOT NULL,
	sta INT NOT NULL,
	-- ��¼ѡ��״̬, 0Ϊ��ʱ���棬1Ϊȷ���ύ
);


INSERT INTO Stu VALUES (1120189999, '��ͽ����', '��', '2000-10-01', '�������ѧ�뼼��');
INSERT INTO Stu VALUES (1120188888, 'GG', '��', '2000-10-2', '�������ѧ�뼼��');
INSERT INTO Stu VALUES (1, '����', '��', '2000-10-3', '�������ѧ�뼼��');

INSERT INTO Cou VALUES (22021101, '����ϵͳ', 3, 1, 12, 2, 3,5, 000562, '����');
INSERT INTO Cou VALUES (22021102, '�������', 4, 1, 12, 3, 3,5, 000562, '����');
INSERT INTO Cou VALUES (22021103, '�����ѧ', 5, 1, 12, 4, 3,5, 000562, '����');

INSERT INTO SC VALUES (1120189999,22021101, 1);

