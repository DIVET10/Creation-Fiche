namespace WinFormsApp1
{
    partial class inscriptionUC
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
            nomEtudiantTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prenomEtudiantTb = new TextBox();
            numeroEtudiantLb = new Label();
            label4 = new Label();
            soumetrreBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // nomEtudiantTb
            // 
            nomEtudiantTb.Location = new Point(179, 25);
            nomEtudiantTb.Margin = new Padding(2);
            nomEtudiantTb.Name = "nomEtudiantTb";
            nomEtudiantTb.Size = new Size(299, 23);
            nomEtudiantTb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Prenom";
            // 
            // prenomEtudiantTb
            // 
            prenomEtudiantTb.Location = new Point(179, 65);
            prenomEtudiantTb.Margin = new Padding(2);
            prenomEtudiantTb.Name = "prenomEtudiantTb";
            prenomEtudiantTb.Size = new Size(299, 23);
            prenomEtudiantTb.TabIndex = 2;
            prenomEtudiantTb.TextChanged += prenomEtudiantTb_TextChanged;
            // 
            // numeroEtudiantLb
            // 
            numeroEtudiantLb.AutoSize = true;
            numeroEtudiantLb.Location = new Point(179, 103);
            numeroEtudiantLb.Margin = new Padding(2, 0, 2, 0);
            numeroEtudiantLb.Name = "numeroEtudiantLb";
            numeroEtudiantLb.Size = new Size(37, 15);
            numeroEtudiantLb.TabIndex = 4;
            numeroEtudiantLb.Text = "00000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 103);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 5;
            label4.Text = "numero etudiant";
            // 
            // soumetrreBtn
            // 
            soumetrreBtn.Location = new Point(662, 390);
            soumetrreBtn.Margin = new Padding(2);
            soumetrreBtn.Name = "soumetrreBtn";
            soumetrreBtn.Size = new Size(78, 26);
            soumetrreBtn.TabIndex = 6;
            soumetrreBtn.Text = "soumettre";
            soumetrreBtn.UseVisualStyleBackColor = true;
            soumetrreBtn.Click += soumetrreBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(62, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(678, 238);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // inscriptionUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(soumetrreBtn);
            Controls.Add(label4);
            Controls.Add(numeroEtudiantLb);
            Controls.Add(label2);
            Controls.Add(prenomEtudiantTb);
            Controls.Add(label1);
            Controls.Add(nomEtudiantTb);
            Name = "inscriptionUC";
            Size = new Size(900, 480);
            Load += inscriptionUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomEtudiantTb;
        private Label label1;
        private Label label2;
        private TextBox prenomEtudiantTb;
        private Label numeroEtudiantLb;
        private Label label4;
        private Button soumetrreBtn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
