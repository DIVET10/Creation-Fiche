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
    public partial class informationCoursEtudiantUC : UserControl
    {
        public informationCoursEtudiantUC()
        {
            InitializeComponent();
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

        private void informationCoursEtudiantUC_Load(object sender, EventArgs e)
        {
            //will help to iterate data accurately line by line
            //int dataIndex = 0;
            List<CoursUC> etudiantCourlist = new List<CoursUC>();

            //for every lines
            for (int i = 0; i < textFileInfoList("etudiantCoursNote.txt").Count; i++)
            {
                etudiantCourlist.Add(new CoursUC());

                string[] data = textFileInfoList("etudiantCoursNote.txt")[i].Split(',');
                etudiantCourlist[i].nomLb.Text = data[0].Trim();
                etudiantCourlist[i].prenomLb.Text = data[1].Trim();
                etudiantCourlist[i].numEtudiantLb.Text = data[2].Trim();
                etudiantCourlist[i].courTitreLb.Text = data[3].Trim();
                etudiantCourlist[i].courCodeLb.Text = data[4].Trim();
                etudiantCourlist[i].courNoteLb.Text = data[5].Trim();

                this.flowLayoutPanel1.Controls.Add(etudiantCourlist[i]);
            }

            //==========================================================

            /*using (StreamReader reader = new StreamReader(projectPath()))
            {
                while (!reader.EndOfStream)
                {
                    // Read a line from the file
                    string line = reader.ReadLine();

                    if (line != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split(',');

                        // Process or display the fields
                        for (int i = 0; i < fields.Length; i++)
                        {
                            Console.Write($"{fields[i]}\t");

                            switch (i)
                            {
                                case 0:
                                    etudiantCourlist[i].nomLb.Text = fields[i];
                                    break;
                                case 1:
                                    etudiantCourlist[i].prenomLb.Text = fields[i];
                                    break;
                                case 2:
                                    etudiantCourlist[i].numEtudiantLb.Text = fields[i];
                                    break;
                                case 3:
                                    etudiantCourlist[i].courTitreLb.Text = fields[i];
                                    break;
                                case 4:
                                    etudiantCourlist[i].courCodeLb.Text = fields[i];
                                    break;
                                case 5:
                                    etudiantCourlist[i].courNoteLb.Text = fields[i];
                                    break;
                            }
                        }

                        Console.WriteLine(); // Move to the next line for the next record
                    }
                }
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
