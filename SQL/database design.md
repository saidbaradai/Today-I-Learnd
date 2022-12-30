```sql

# database creating 
CREATE DATABASE TestDB

# database dropping
DROP DATABASE TestDB

# backup database
BACKUP DATABASE TestDB
TO DISK ='filepath.bac'
WITH DIFFERENTIAL

Tip: A differential back up reduces the back up time (since only the changes are backed up).



# create table
CREATE TABLE Book(
id int,
title varchar(20),
price int
)

# Dropping a table
DROP TABLE TestTable

# deleting the content of table 
TRUNCATE TABLE TestTable


# change column name
EXEC sp_rename 'TableName.OldName', 'NewName', 'COLUMN'


```

* Note: You have to have admin privilages to access a path in your PC (you can edit the logg of in the SQL SERVER Properties from the SERVICES)
