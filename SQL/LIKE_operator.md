## We use the LIKE operator when we are loking for a specefic charechter or word in an item.

#### For example this query will return all the names that starts with 'a' or 'A'. 


```sql
SELECT *
FROM employees
WHERE first_name LIKE "a%";

```
#### And this query will return all the phone numbers that contains 22. 

```sql
SELECT *
FROM employees
WHERE phone_number LIKE "%22%";

```



#### And  here will return all the the names that starts with 'a' and end ends with 't' and has 5 charechter long. 

```sql
SELECT *
FROM employees
WHERE first_name LIKE "a___t";

```
