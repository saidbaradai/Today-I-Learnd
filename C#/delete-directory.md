```c#
            string root = @"D:\YourFolder";
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true); //true for deleting all sub directories and files
            }

```
