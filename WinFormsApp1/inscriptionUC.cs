using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class inscriptionUC : UserControl
    {
        public inscriptionUC()
        {
            InitializeComponent();
        }

        private List<courInscriptionUc> courlistUc = new List<courInscriptionUc>();
        private List<string> etudiantCourlist = new List<string>();
        private List<string> etudiantCourCodelist = new List<string>();

        private void prenomEtudiantTb_TextChanged(object sender, EventArgs e)
        {

        }
        //get current path
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

        //return list from textfile
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

        private void writeInfoToFile(string relativepath)
        {
            // Specify the relative file path
            string relativeFilePath = relativepath;

            // Combine the current directory with the relative file path
            string filePath = Path.Combine(projectPath(), relativeFilePath);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < etudiantCourlist.Count; i++)
                {
                    string nom = this.nomEtudiantTb.Text;
                    string prenom = this.prenomEtudiantTb.Text;
                    string numeroEtudiant = this.numeroEtudiantLb.Text;
                    string cours = etudiantCourlist[i];
                    string coursCode = etudiantCourCodelist[i];

                    // Create a string in CSV format
                    string csvLine = $"{nom},{prenom},{numeroEtudiant},{cours},{coursCode}";

                    // Write the CSV line to the file or create a new file if it doesn't exist
                    //File.WriteAllText(filePath, csvLine);
                    writer.WriteLine(csvLine);
                }
            }



            //-------------------
            // Specify the relative file path
            /*string relativeFilePath = "studentCourseList.txt";

            // Combine the project root with the relative file path
            string filePath = Path.Combine(projectRoot, relativeFilePath);

            // Write multiple lines to the file or create a new file if it doesn't exist
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in studentData)
                {
                    writer.WriteLine(line);
                }
            }*/
        }

        private void saveEtudiantCourNoteFile(string relativepath)
        {
            // Specify the relative file path
            string relativeFilePath = relativepath;

            // Combine the current directory with the relative file path
            string filePath = Path.Combine(projectPath(), relativeFilePath);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < etudiantCourlist.Count; i++)
                {
                    string nom = this.nomEtudiantTb.Text;
                    string prenom = this.prenomEtudiantTb.Text;
                    string numeroEtudiant = this.numeroEtudiantLb.Text;
                    string cours = etudiantCourlist[i];
                    string coursCode = etudiantCourCodelist[i];
                    string note = "00.00";

                    // Create a string in CSV format
                    string csvLine = $"{nom},{prenom},{numeroEtudiant},{cours},{coursCode},{note}";

                    // Write the CSV line to the file or create a new file if it doesn't exist
                    //File.WriteAllText(filePath, csvLine);
                    writer.WriteLine(csvLine);
                }
            }
        }

        private void saveStudentListToFile(string relativepath)
        {
            // Specify the relative file path
            string relativeFilePath = relativepath;

            // Combine the current directory with the relative file path
            string filePath = Path.Combine(projectPath(), relativeFilePath);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string numeroEtudiant = this.numeroEtudiantLb.Text;

                // Create a string in CSV format
                string csvLine = $"{numeroEtudiant}";

                // Write the CSV line to the file or create a new file if it doesn't exist
                //File.WriteAllText(filePath, csvLine);
                writer.WriteLine(csvLine);

            }
        }

        private void inscriptionUC_Load(object sender, EventArgs e)
        {
            List<Cours> courlist = new List<Cours>();
            //List<Cours> courCodelist = new List<Cours>();

            // Specify the path to the text file
            //List<string> tempListCode = new List<string
            //courTitreCb
            //courInscriptionUc cour1 = new courInscriptionUc();
            //@"C:\Users\david\Desktop\AQL\WinFormsApp1\coursCode.txt"
            string relativePathCours = "courList.txt";
            string relativePathCode = "coursCode.txt";

            //tempListCode = textFileInfoList(relativePathCode);

            /*for (int i = 0; i < textFileInfoList(relativePathCode).Count; i++)
            {

                courlistUc[i] = new courInscriptionUc();
            }*/

            for (int i = 0; i < textFileInfoList(relativePathCode).Count; ++i)
            {
                //creer une liste des cours
                courlist.Add(new Cours(textFileInfoList(relativePathCode)[i], textFileInfoList(relativePathCours)[i]));

                courlistUc.Add(new courInscriptionUc());
                courlistUc[i].courTitreCb.Text = courlist[i].Titre;
                courlistUc[i].courCodeLb.Text = courlist[i].Code;

                this.flowLayoutPanel1.Controls.Add(courlistUc[i]);
            }

            //auto generate student num
            this.numeroEtudiantLb.Text = new Random().Next(10000, 100000).ToString();

            //this.label1.Text = textFileInfoList(relativePathCours)[1];
        }

        private void soumetrreBtn_Click(object sender, EventArgs e)
        {
            //string relativePathCode = @"C:\Users\david\Desktop\AQL\WinFormsApp1\coursCode.txt";

            for (int i = 0; i < courlistUc.Count; ++i)
            {
                //creer une liste des cours, ajouter un cour if checked
                if (this.courlistUc[i].courTitreCb.Checked)
                {
                    etudiantCourlist.Add(this.courlistUc[i].courTitreCb.Text);
                    etudiantCourCodelist.Add(this.courlistUc[i].courCodeLb.Text);
                }

            }

            //write to file
            if (this.nomEtudiantTb.Text != null || this.prenomEtudiantTb.Text != null || etudiantCourlist.Count != 0)
            {
                /*for(int i = 0; i < etudiantCourlist.Count; ++i)
                {
                    writeInfoToFile("etudiantCoursList.txt");
                }*/
                writeInfoToFile("etudiantCoursList.txt");
                saveStudentListToFile("etudiantList.txt");


                saveEtudiantCourNoteFile("etudiantCoursNote.txt");
                MessageBox.Show("Completed");
                reinitializeInfo();
            }
            else
            {
                MessageBox.Show("Information manquante");
                reinitializeInfo();
            }
        }

        public void reinitializeInfo()
        {
            //reinitialise ========================================
            this.nomEtudiantTb.Text = null;
            this.prenomEtudiantTb.Text = null;
            this.numeroEtudiantLb.Text = new Random().Next(10000, 100000).ToString();

            for (int i = 0; i < courlistUc.Count; ++i)
            {
                //creer une liste des cours, ajouter un cour if checked
                if (this.courlistUc[i].courTitreCb.Checked)
                {
                    this.courlistUc[i].courTitreCb.Checked = false;
                }

            }
        }
    }
}
