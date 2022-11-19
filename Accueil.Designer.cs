namespace Examen
{
    partial class Accueil
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnexamen = new System.Windows.Forms.Button();
            this.btnquestion = new System.Windows.Forms.Button();
            this.btnproposition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexamen
            // 
            this.btnexamen.Location = new System.Drawing.Point(181, 181);
            this.btnexamen.Name = "btnexamen";
            this.btnexamen.Size = new System.Drawing.Size(101, 59);
            this.btnexamen.TabIndex = 0;
            this.btnexamen.Text = "Examen";
            this.btnexamen.UseVisualStyleBackColor = true;
            this.btnexamen.Click += new System.EventHandler(this.btnexamen_Click);
            // 
            // btnquestion
            // 
            this.btnquestion.Location = new System.Drawing.Point(326, 181);
            this.btnquestion.Name = "btnquestion";
            this.btnquestion.Size = new System.Drawing.Size(101, 59);
            this.btnquestion.TabIndex = 1;
            this.btnquestion.Text = "Question";
            this.btnquestion.UseVisualStyleBackColor = true;
            this.btnquestion.Click += new System.EventHandler(this.btnquestion_Click);
            // 
            // btnproposition
            // 
            this.btnproposition.Location = new System.Drawing.Point(470, 181);
            this.btnproposition.Name = "btnproposition";
            this.btnproposition.Size = new System.Drawing.Size(101, 59);
            this.btnproposition.TabIndex = 2;
            this.btnproposition.Text = "Proposition";
            this.btnproposition.UseVisualStyleBackColor = true;
            this.btnproposition.Click += new System.EventHandler(this.btnproposition_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnproposition);
            this.Controls.Add(this.btnquestion);
            this.Controls.Add(this.btnexamen);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexamen;
        private System.Windows.Forms.Button btnquestion;
        private System.Windows.Forms.Button btnproposition;
    }
}