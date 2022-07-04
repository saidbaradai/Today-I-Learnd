```c#


            var command = new SqlCommand();
            command.Connection = cnn;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM [KASKAS_THOS].[dbo].[tsCity]";

            var adaptar = new SqlDataAdapter(command);
            var dataset = new DataSet();
            adaptar.Fill(dataset);

            DataTable names = dataset.Tables[0];



            comboBox1.ValueMember = "CityID";
            comboBox1.DisplayMember = "CityName";
            comboBox1.DataSource = names;

```

# Then  

```c#
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
  
  
  
  
            var command = new SqlCommand();
            command.Connection = cnn;
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM [KASKAS_THOS].[dbo].[tsCounty] WHERE CityID ={comboBox1.SelectedValue}";

            var adaptar = new SqlDataAdapter(command);
            var dataset = new DataSet();
            adaptar.Fill(dataset);

            DataTable ilce = dataset.Tables[0];


            adaptar.Fill(dataset);


   
                comboBox2.ValueMember = "CountyID";
                comboBox2.DisplayMember = "CountyName";
                comboBox2.DataSource = ilce;

  
  
  
  
  
  
  
  
  
  
  
}

```
