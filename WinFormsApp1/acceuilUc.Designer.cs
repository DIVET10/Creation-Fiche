namespace WinFormsApp1
{
    partial class acceuilUc
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
            button3 = new Button();
            button2 = new Button();
            connexionBt = new Button();
            label1 = new Label();
            numEtudiantTb = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(344, 341);
            button3.Name = "button3";
            button3.Size = new Size(119, 26);
            button3.TabIndex = 9;
            button3.Text = "mettre note a jour";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 286);
            button2.Name = "button2";
            button2.Size = new Size(119, 26);
            button2.TabIndex = 8;
            button2.Text = "inscription";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // connexionBt
            // 
            connexionBt.Location = new Point(344, 238);
            connexionBt.Name = "connexionBt";
            connexionBt.Size = new Size(119, 26);
            connexionBt.TabIndex = 7;
            connexionBt.Text = "connexion";
            connexionBt.UseVisualStyleBackColor = true;
            connexionBt.Click += connexionBt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 94);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Mon portail";
            // 
            // numEtudiantTb
            // 
            numEtudiantTb.Location = new Point(264, 155);
            numEtudiantTb.Name = "numEtudiantTb";
            numEtudiantTb.PlaceholderText = "num Etudiant 00000";
            numEtudiantTb.Size = new Size(287, 23);
            numEtudiantTb.TabIndex = 5;
            // 
            // acceuilUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(connexionBt);
            Controls.Add(label1);
            Controls.Add(numEtudiantTb);
            Name = "acceuilUc";
            Size = new Size(900, 480);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button connexionBt;
        private Label label1;
        private TextBox numEtudiantTb;
    }
}
