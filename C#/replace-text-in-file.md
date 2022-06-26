```C#
string text = File.ReadAllText("test.txt");
text = text.Replace("some text", "new value");
File.WriteAllText("test.txt", text);
```
