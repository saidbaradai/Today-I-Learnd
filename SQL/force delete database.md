#### First you must alter the database as master user to disconnect other useres from it. then you can DROP it.

```sql
alter database DBname set single_user with rollback immediate DROP DATABASE DBname
```
