SELECT * FROM dbo.Tbl_Admin WHERE username = 'admin' AND password = 'admin123';
INSERT INTO dbo.Tbl_Admin  VALUES ('1','admin','admin123');
SELECT * FROM dbo.Tbl_AddUsers;
DELETE FROM dbo.Tbl_AddUsers WHERE EmployeeID = '12';