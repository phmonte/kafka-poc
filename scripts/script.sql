-- 1 -- Create database
CREATE DATABASE TesteEF

Use TesteEF
GO

-- 2 -- Create table
CREATE TABLE Person (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(200) NOT NULL,
    Phone VARCHAR(11)
)

-- 3 -- Enable CDC
EXEC sys.sp_cdc_enable_db
GO


-- 4 -- Create CDC for Person table
EXEC sys.sp_cdc_enable_table
@source_schema = N'dbo',
@source_name   = N'Person',
@role_name     = N'Admin',
@supports_net_changes = 1
GO