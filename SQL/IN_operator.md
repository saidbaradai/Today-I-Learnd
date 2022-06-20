## The usage of IN operator in SQL

#### We use IN operator when we wanna compare an atribute with a list of items

```SQL
SELECT * FROM customer WHERE age= 15 OR age=19 OR age=45
```
#### But we can do the same thing by using the **IN** keyword

```SQL
SELECT * FROM customer WHERE age IN (15,19,45)
```

#### We can also use it with NOT keyword

```SQL
SELECT * FROM customer WHERE age NOT IN (15,19,45)
```


