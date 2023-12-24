namespace WinFormsApp1
{
    partial class courMisajourUc
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
            components = new System.ComponentModel.Container();
            courCodeLb = new Label();
            courNoteLb = new Label();
            courTitreLb = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newNoteTb = new TextBox();
            numEtudiantLb = new Label();
            prenomLb = new Label();
            nomLb = new Label();
            SuspendLayout();
            // 
            // courCodeLb
            // 
            courCodeLb.AutoSize = true;
            courCodeLb.Location = new Point(592, 20);
            courCodeLb.Margin = new Padding(2, 0, 2, 0);
            courCodeLb.Name = "courCodeLb";
            courCodeLb.Size = new Size(59, 15);
            courCodeLb.TabIndex = 1;
            courCodeLb.Text = "courCode";
            courCodeLb.Click += courCodeLb_Click;
            // 
            // courNoteLb
            // 
            courNoteLb.AutoSize = true;
            courNoteLb.Location = new Point(710, 20);
            courNoteLb.Margin = new Padding(2, 0, 2, 0);
            courNoteLb.Name = "courNoteLb";
            courNoteLb.Size = new Size(34, 15);
            courNoteLb.TabIndex = 2;
            courNoteLb.Text = "00.00";
            // 
            // courTitreLb
            // 
            courTitreLb.AutoSize = true;
            courTitreLb.Location = new Point(454, 20);
            courTitreLb.Margin = new Padding(2, 0, 2, 0);
            courTitreLb.Name = "courTitreLb";
            courTitreLb.Size = new Size(54, 15);
            courTitreLb.TabIndex = 3;
            courTitreLb.Text = "courTitre";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // newNoteTb
            // 
            newNoteTb.Location = new Point(761, 12);
            newNoteTb.Margin = new Padding(2);
            newNoteTb.Name = "newNoteTb";
            newNoteTb.Size = new Size(73, 23);
            newNoteTb.TabIndex = 5;
            newNoteTb.TextChanged += textBox1_TextChanged;
            // 
            // numEtudiantLb
            // 
            numEtudiantLb.AutoSize = true;
            numEtudiantLb.Location = new Point(315, 20);
            numEtudiantLb.Margin = new Padding(2, 0, 2, 0);
            numEtudiantLb.Name = "numEtudiantLb";
            numEtudiantLb.Size = new Size(76, 15);
            numEtudiantLb.TabIndex = 6;
            numEtudiantLb.Text = "numEtudiant";
            // 
            // prenomLb
            // 
            prenomLb.AutoSize = true;
            prenomLb.Location = new Point(157, 20);
            prenomLb.Margin = new Padding(2, 0, 2, 0);
            prenomLb.Name = "prenomLb";
            prenomLb.Size = new Size(49, 15);
            prenomLb.TabIndex = 7;
            prenomLb.Text = "prenom";
            prenomLb.Click += prenomLb_Click;
            // 
            // nomLb
            // 
            nomLb.AutoSize = true;
            nomLb.Location = new Point(20, 17);
            nomLb.Margin = new Padding(2, 0, 2, 0);
            nomLb.Name = "nomLb";
            nomLb.Size = new Size(32, 15);
            nomLb.TabIndex = 8;
            nomLb.Text = "nom";
            // 
            // courMisajourUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(nomLb);
            Controls.Add(prenomLb);
            Controls.Add(numEtudiantLb);
            Controls.Add(newNoteTb);
            Controls.Add(courTitreLb);
            Controls.Add(courNoteLb);
            Controls.Add(courCodeLb);
            Margin = new Padding(2);
            Name = "courMisajourUc";
            Size = new Size(889, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label courCodeLb;
        public Label courNoteLb;
        public Label courTitreLb;
        public ContextMenuStrip contextMenuStrip1;
        public TextBox newNoteTb;
        public Label numEtudiantLb;
        public Label prenomLb;
        public Label nomLb;
    }
}
