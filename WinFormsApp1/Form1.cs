namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(UcRepos.mainUc);

            UcRepos.mainUc.Controls.Add(UcRepos.inscription);
            UcRepos.mainUc.Controls.Add(UcRepos.misAjourNote);
            UcRepos.mainUc.Controls.Add(UcRepos.informationEtudiant);
            UcRepos.mainUc.Controls.Add(UcRepos.acceuilEcran);

            UcRepos.inscription.Visible = false;
            UcRepos.misAjourNote.Visible = false;
            UcRepos.informationEtudiant.Visible = false;
            UcRepos.acceuilEcran.Visible = true;

            UcRepos.mainUc.Visible = true;


            //generate cours


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}