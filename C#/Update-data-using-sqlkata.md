```c#

            var connetionString = $@"Data Source=DESKTOP-000000\SQLEXPRESS;Initial Catalog=DBName;Integrated Security=True";
            var cnn2 = new SqlConnection(connetionString);
            var db = new QueryFactory(cnn2, new SqlServerCompiler());
            // mybe we will need to use cnn.Open();

            int affected = db.Query("Books").Where("Id", 3).Update(new
            {
                Book_pages = Convert.ToInt32(ISPNtextBox.Text),
                ISPN = Convert.ToInt32(ISPNtextBox.Text)
            });


            MessageBox.Show("Data in Books has been updated sucessfully "+affected);
            
            cnn2.Close();

```
