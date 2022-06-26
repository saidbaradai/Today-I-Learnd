```c#
using (StreamWriter w = File.AppendText("myFile.txt"))
{
  w.WriteLine("hello");
}
```
