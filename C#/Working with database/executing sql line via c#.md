# SqlCommand
We need sql command function to do this.

```c#

            var connectionString = "Server=localhost;Database=test;Trusted_Connection=True;";
            var cnn = new SqlConnection(connectionString);
            var query = "CREATE TABLE simplesql " + "(" + "simple_id int," + "simple_text text" + ")";
            var cmd = new SqlCommand(query,cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Table Created");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }

```
