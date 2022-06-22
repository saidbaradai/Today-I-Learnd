## When we wanna list a specific number of records from the database.

#### For example this query will sort the   first 50 recored from the employees table.


```sql
SELECT *
FROM employees
LIMIT 50;

```
#### And this query will sort the 5 records after skipping the first 8 records: 

```sql
SELECT *
FROM employees
LIMIT 8, 5;

```




