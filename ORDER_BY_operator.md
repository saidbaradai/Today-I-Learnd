## We use the ORDER BY operator when we want to sort the data ordered by a ASC or DESC way.

#### For example this query sort the data by thr first name ASC. 


```sql
SELECT *
FROM employees
ORDER BY first_name;

```
#### And this query will sort the data by thr ferst name ASC then by salary 

```sql
SELECT *
FROM employees
ORDER BY first_name, salary;

```




