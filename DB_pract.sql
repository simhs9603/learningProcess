use HdelUserList;

select * from UserLicenseReport;

--EXEC sp_rename 'UserLicenseReport.[EmpID]', 'PhoneMaker', 'Column';

ALTER TABLE UserLicenseReport ALTER COLUMN Discription nvarchar(1000) ;
