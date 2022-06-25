





```c#

        private void copy_button_Click(object sender, EventArgs e)
        {
            label1.Text = "copping has been started, please waite ....";

            if (newDiractoryName.Text.Trim()!="")
            {
                CopyFiles(newDiractoryName.Text);
            }

            else
            {
                MessageBox.Show("Please enter a valid name");
            }
                
            label1.Text = "copy completed!";


        }


        private static  void  CopyFiles(string newDirectoryName)
        {
            string sourceDirectoryName = "sad";
            string targetDirectoryName = newDirectoryName;
            string masterPath = @"C:\Users\orange\Desktop";

            var sourcePath = Path.Combine(masterPath, sourceDirectoryName);
            var targetPath = Path.Combine(masterPath, targetDirectoryName);

            //Now Create all of the directories
            try
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error acoured!");
            }

            //Copy all the files & Replaces any files with the same name
            try
            {
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error acoured!");
            }
            
        }



```
