namespace WinFormsApp1
{
    partial class courInscriptionUc
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
            courCodeLb = new Label();
            courTitreCb = new CheckBox();
            SuspendLayout();
            // 
            // courCodeLb
            // 
            courCodeLb.AutoSize = true;
            courCodeLb.Location = new Point(293, 18);
            courCodeLb.Margin = new Padding(2, 0, 2, 0);
            courCodeLb.Name = "courCodeLb";
            courCodeLb.Size = new Size(59, 15);
            courCodeLb.TabIndex = 1;
            courCodeLb.Text = "courCode";
            // 
            // courTitreCb
            // 
            courTitreCb.AutoSize = true;
            courTitreCb.Location = new Point(44, 14);
            courTitreCb.Margin = new Padding(2, 2, 2, 2);
            courTitreCb.Name = "courTitreCb";
            courTitreCb.Size = new Size(73, 19);
            courTitreCb.TabIndex = 2;
            courTitreCb.Text = "courTitre";
            courTitreCb.UseVisualStyleBackColor = true;
            // 
            // courInscriptionUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(courTitreCb);
            Controls.Add(courCodeLb);
            Margin = new Padding(2, 2, 2, 2);
            Name = "courInscriptionUc";
            Size = new Size(640, 43);
            Load += courInscriptionUc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label courCodeLb;
        public CheckBox courTitreCb;
    }
}
