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
    public partial class acceuilUc : UserControl
    {
        public acceuilUc()
        {
            InitializeComponent();
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

        private void connexionBt_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            for (int i = 0; i < textFileInfoList("etudiantList.txt").Count; i++)
            {
                if (textFileInfoList("etudiantList.txt")[i] == numEtudiantTb.Text)
                {
                    isFound = true;
                }
            }
            //show info if student is found
            if (isFound)
            {
                UcRepos.acceuilEcran.Visible = false;
                UcRepos.misAjourNote.Visible = false;
                UcRepos.inscription.Visible = false;
                UcRepos.informationEtudiant.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UcRepos.acceuilEcran.Visible = false;
            UcRepos.informationEtudiant.Visible = false;
            UcRepos.misAjourNote.Visible = false;
            UcRepos.inscription.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            for (int i = 0; i < textFileInfoList("etudiantList.txt").Count; i++)
            {
                if (textFileInfoList("etudiantList.txt")[i] == numEtudiantTb.Text)
                {
                    isFound = true;
                }
            }
            //show info if student is found
            if (isFound)
            {
                UcRepos.acceuilEcran.Visible = false;
                UcRepos.informationEtudiant.Visible = false;
                UcRepos.inscription.Visible = false;
                UcRepos.misAjourNote.Visible = true;
            }
        }
    }
}
