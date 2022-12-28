## In the  "Web.config"  file we have to write the connetction string in the following way:

```C#
  <connectionStrings>
    <add name="BlogContext" 
		 connectionString="data source=DESKTOP-RV90A7V\SQLEXPRESS;Initial Catalog=BlogSite;Integrated Security=True" 
		 providerName="System.Data.SqlClient" />
  </connectionStrings>
  
  
  Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
```


 and you have to change the **name**, **data source** and **Initial Catalog** parameters's value.
 
