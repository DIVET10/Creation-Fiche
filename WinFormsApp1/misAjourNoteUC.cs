using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class misAjourNoteUC : UserControl
    {
        public misAjourNoteUC()
        {
            InitializeComponent();
        }

        private void loadFileContent()
        {
            List<courMisajourUc> etudiantCourlist = new List<courMisajourUc>();

            //for every lines
            for (int i = 0; i < textFileInfoList("etudiantCoursNote.txt").Count; i++)
            {
                etudiantCourlist.Add(new courMisajourUc());

                string[] data = textFileInfoList("etudiantCoursNote.txt")[i].Split(',');
                etudiantCourlist[i].nomLb.Text = data[0].Trim();
                etudiantCourlist[i].prenomLb.Text = data[1].Trim();
                etudiantCourlist[i].numEtudiantLb.Text = data[2].Trim();
                etudiantCourlist[i].courTitreLb.Text = data[3].Trim();
                etudiantCourlist[i].courCodeLb.Text = data[4].Trim();
                etudiantCourlist[i].courNoteLb.Text = data[5].Trim();

                this.flowLayoutPanel1.Controls.Add(etudiantCourlist[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string projectPath()
        {
            // Get the current working directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // Find the index of the last occurrence of "\bin\"
            int binIndex = currentDirectory.LastIndexOf("\\bin\\", StringComparison.OrdinalIgnoreCase);

            if (binIndex != -1)
            {
                // Extract the path before "\bin\"
                return currentDirectory.Substring(0, binIndex);
            }

            return null;
        }

        private List<string> textFileInfoList(string relativepath)
        {

            // Specify the relative path to the text file
            string relativePath = relativepath;

            // Combine the relative path with the current working directory to get the full path
            string filePath = Path.Combine(projectPath(), relativePath);

            List<string> lines = new List<string>();

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the contents of the file and store them in a List<string>


                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Read each line from the file and add it to the List
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                // Display the contents of the List
                Console.WriteLine("Contents of the List:");

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found: " + filePath);
            }
            return lines;
        }
        private void misAjourNoteUC_Load(object sender, EventArgs e)
        {
            loadFileContent();
        }
    }
}
