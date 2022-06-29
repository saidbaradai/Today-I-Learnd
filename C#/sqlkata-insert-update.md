```c#


             //Open Connection with the database
            var dataSource = "DESKTOP-RV90A7V\\SQLEXPRESS";
            var dbName = "StarWar";
            string connectionString = $"Data source={dataSource};Initial Catalog={dbName};Integrated Security =true;";
            var cnn =new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                MessageBox.Show("OK");
            }
            catch (Exception)
            {
                cnn.Close();
                MessageBox.Show("EROR ");
                throw;
            }

            //SQLkata
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(cnn,compiler);


            //Update
            var command = db.Query("Authors").Where("Id", 6).Update(new {
            Name="JAMAA!"
            });

            //Insert
             db.Query("Authors").Insert(new
            {
                
                Name = "JAMAA3",
                Description="SAID"
            });



```
