USE master;
GO
SELECT session_id FROM sys.dm_exec_sessions WHERE database_id = DB_ID('GroepsReizenDB');
GO
DROP DATABASE GroepsreizenDb;