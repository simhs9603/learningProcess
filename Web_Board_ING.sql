use ;

SELECT * FROM SignUpForm;

--EXEC SP_RENAME 'SignUpForm.[name]','contents','COLUMN';

ALTER TABLE SignUpForm ALTER COLUMN title nvarchar(50) NOT NULL; 
--Sign up 테이블의 타이틀 컬럼을 nvarchar 그리고 NOT NULL 로 변경 

ALTER TABLE SignUpForm ADD ViewCount int NULL;
--조회수 추가 

ALTER TABLE SignUpForm ADD Recommandation int NULL DEFAULT '0';
--추천수 추가 기본값은 0 
