





```c#

        private void copy_button_Click(object sender, EventArgs e)
        {
            string sourceDirectoryName = "orginal directory";
            string targetDirectoryName = "the new directory";
            string masterPath = @"C:\Users\MY_USER_NAME\Desktop";

            var sourceDirectoryPath = Path.Combine(masterPath, sourceDirectoryName);
            var targetDirectoryPath = Path.Combine(masterPath, targetDirectoryName);
           

            label1.Text = "copping has been started, please waite ....";

            CopyFiles(sourceDirectoryPath,targetDirectoryPath);
            label1.Text = "copy completed!";


        }

        //Source: stack overflow

        private static  void  CopyFiles(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }



```
