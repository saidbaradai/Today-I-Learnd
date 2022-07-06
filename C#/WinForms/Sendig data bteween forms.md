Define a property

```c#
public static class ControlID {  
    public static string TextData { get; set; }
}
```
In the form2

```c#
private void button1_Click(object sender, EventArgs e)
{  
    ControlID.TextData = txtTextData.Text;   
}
```

Getting the data in form1 and form3


```c#
private void button1_Click(object sender, EventArgs e)
{   
    string text=  ControlID.TextData;   
}
```

