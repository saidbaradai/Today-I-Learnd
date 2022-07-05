## Basic connection string to MSSQL server via C#

>Note: you need to chang the parameters
```c#
static void Main(string[] args)
        {
            //server name
            string data_source = "DESKTOP-RV90A7V\\SQLEXPRESS";
            //database name
            string initial_catalog = "StarWar";

            var connetionString = $"Data Source={data_source};Initial Catalog={initial_catalog};Integrated Security=True";

            var cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(cnn, compiler);


        }

```
