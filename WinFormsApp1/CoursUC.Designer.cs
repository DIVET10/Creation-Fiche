namespace WinFormsApp1
{
    partial class CoursUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nomLb = new Label();
            prenomLb = new Label();
            numEtudiantLb = new Label();
            courTitreLb = new Label();
            courNoteLb = new Label();
            courCodeLb = new Label();
            SuspendLayout();
            // 
            // nomLb
            // 
            nomLb.AutoSize = true;
            nomLb.Location = new Point(17, 11);
            nomLb.Margin = new Padding(2, 0, 2, 0);
            nomLb.Name = "nomLb";
            nomLb.Size = new Size(32, 15);
            nomLb.TabIndex = 14;
            nomLb.Text = "nom";
            // 
            // prenomLb
            // 
            prenomLb.AutoSize = true;
            prenomLb.Location = new Point(157, 11);
            prenomLb.Margin = new Padding(2, 0, 2, 0);
            prenomLb.Name = "prenomLb";
            prenomLb.Size = new Size(49, 15);
            prenomLb.TabIndex = 13;
            prenomLb.Text = "prenom";
            // 
            // numEtudiantLb
            // 
            numEtudiantLb.AutoSize = true;
            numEtudiantLb.Location = new Point(318, 11);
            numEtudiantLb.Margin = new Padding(2, 0, 2, 0);
            numEtudiantLb.Name = "numEtudiantLb";
            numEtudiantLb.Size = new Size(76, 15);
            numEtudiantLb.TabIndex = 12;
            numEtudiantLb.Text = "numEtudiant";
            // 
            // courTitreLb
            // 
            courTitreLb.AutoSize = true;
            courTitreLb.Location = new Point(454, 11);
            courTitreLb.Margin = new Padding(2, 0, 2, 0);
            courTitreLb.Name = "courTitreLb";
            courTitreLb.Size = new Size(54, 15);
            courTitreLb.TabIndex = 11;
            courTitreLb.Text = "courTitre";
            // 
            // courNoteLb
            // 
            courNoteLb.AutoSize = true;
            courNoteLb.Location = new Point(713, 11);
            courNoteLb.Margin = new Padding(2, 0, 2, 0);
            courNoteLb.Name = "courNoteLb";
            courNoteLb.Size = new Size(34, 15);
            courNoteLb.TabIndex = 10;
            courNoteLb.Text = "00.00";
            // 
            // courCodeLb
            // 
            courCodeLb.AutoSize = true;
            courCodeLb.Location = new Point(592, 11);
            courCodeLb.Margin = new Padding(2, 0, 2, 0);
            courCodeLb.Name = "courCodeLb";
            courCodeLb.Size = new Size(59, 15);
            courCodeLb.TabIndex = 9;
            courCodeLb.Text = "courCode";
            // 
            // CoursUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(nomLb);
            Controls.Add(prenomLb);
            Controls.Add(numEtudiantLb);
            Controls.Add(courTitreLb);
            Controls.Add(courNoteLb);
            Controls.Add(courCodeLb);
            Margin = new Padding(2);
            Name = "CoursUC";
            Size = new Size(760, 37);
            Load += CoursUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nomLb;
        public Label prenomLb;
        public Label numEtudiantLb;
        public Label courTitreLb;
        public Label courNoteLb;
        public Label courCodeLb;
    }
}
