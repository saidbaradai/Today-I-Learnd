#### First we write some dataint a json file:

```json
[
  {
    "Name": "SAID BARADAI",
    "Age": 24,
    "Isprogrammer": true
  },
    {
      "Name": "BILAL ABBAS",
      "Age": 23,
      "Isprogrammer": false
    },
    {
      "Name": "AHMET KARA",
      "Age": 25,
      "Isprogrammer": true
    }
    
  
]

```
#### Then we can read it like this 
```c#
        using Newtonsoft.Json;

        private void button1_Click(object sender, EventArgs e)
        {
            var file = @"C:\Users\saeed\source\repos\Test-Static\json2.json";

            StreamReader streamReader = new StreamReader(file);
            string jsonString = streamReader.ReadToEnd();
            var mas = JsonConvert.DeserializeObject<List<Item>>(jsonString);

            foreach (var item in mas)
                richTextBox1.AppendText("Name: " + item.name + " Age: " + item.Age + "\n");

        }

        public class Item
        {
            public int Age;
            public string? name;
            public bool Isprogrammer;
        }
```

##### I used  Newtonsoft.Json library
