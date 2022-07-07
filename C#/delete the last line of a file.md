```c#
           var lines = File.ReadAllLines(textBox2.Text);
            File.WriteAllLines(textBox2.Text, lines.Take(lines.Length - 1).ToArray());
```
