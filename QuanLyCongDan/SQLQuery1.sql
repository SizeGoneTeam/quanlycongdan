select * from TamTruTamVang A, CCCD B where A.ID_CongDan = B.ID_CongDan and B.SoCCCD=789012345678
select * from TamTruTamVang
SELECT cast(ID_CongDan as nvarchar) FROM CCCD WHERE SoCCCD like 789012345678
SELECT * FROM CCCD WHERE SoCCCD LIKE '789012345678'
delete from TamTruTamVang where ID_CongDan=8
select * from TamTruTamVang where ID_CongDan = '8'