

You can create a new db then use the "Restore Wizard" enabling the Overwrite option or:

View the contents of the backup file:
```sql
RESTORE FILELISTONLY FROM DISK='c:\your.bak'
```
note the logical names of the .mdf & .ldf from the results, then:
```sql
RESTORE DATABASE MyTempCopy FROM DISK='c:\your.bak'
WITH 
   MOVE 'LogicalNameForTheMDF' TO 'c:\MyTempCopy.mdf',
   MOVE 'LogicalNameForTheLDF' TO 'c:\MyTempCopy_log.ldf'
   ```
This will create the database MyTempCopy with the contents of your.bak.

(Don't create the MyTempCopy, it's created during the restore)

[source](https://stackoverflow.com/questions/6267273/how-to-restore-to-a-different-database-in-sql-server)
