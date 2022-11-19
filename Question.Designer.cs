namespace Examen
{
    partial class Question
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
            this.pnlq1 = new System.Windows.Forms.Panel();
            this.pnlq3 = new System.Windows.Forms.Panel();
            this.pnlq2 = new System.Windows.Forms.Panel();
            this.dgrq1 = new System.Windows.Forms.DataGridView();
            this.txtid_q = new System.Windows.Forms.TextBox();
            this.txtid_pro = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lblid_q = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblid_pro = new System.Windows.Forms.Label();
            this.btnqajouter = new System.Windows.Forms.Button();
            this.btnqmodifier = new System.Windows.Forms.Button();
            this.btnqsupprimer = new System.Windows.Forms.Button();
            this.btnqafficher = new System.Windows.Forms.Button();
            this.btnqannuler = new System.Windows.Forms.Button();
            this.pnlq1.SuspendLayout();
            this.pnlq3.SuspendLayout();
            this.pnlq2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrq1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlq1
            // 
            this.pnlq1.Controls.Add(this.lblid_pro);
            this.pnlq1.Controls.Add(this.lbltype);
            this.pnlq1.Controls.Add(this.lblid_q);
            this.pnlq1.Controls.Add(this.txttype);
            this.pnlq1.Controls.Add(this.txtid_pro);
            this.pnlq1.Controls.Add(this.txtid_q);
            this.pnlq1.Location = new System.Drawing.Point(11, 9);
            this.pnlq1.Name = "pnlq1";
            this.pnlq1.Size = new System.Drawing.Size(778, 115);
            this.pnlq1.TabIndex = 0;
            // 
            // pnlq3
            // 
            this.pnlq3.Controls.Add(this.btnqannuler);
            this.pnlq3.Controls.Add(this.btnqafficher);
            this.pnlq3.Controls.Add(this.btnqsupprimer);
            this.pnlq3.Controls.Add(this.btnqmodifier);
            this.pnlq3.Controls.Add(this.btnqajouter);
            this.pnlq3.Location = new System.Drawing.Point(10, 427);
            this.pnlq3.Name = "pnlq3";
            this.pnlq3.Size = new System.Drawing.Size(778, 115);
            this.pnlq3.TabIndex = 1;
            // 
            // pnlq2
            // 
            this.pnlq2.Controls.Add(this.dgrq1);
            this.pnlq2.Location = new System.Drawing.Point(11, 130);
            this.pnlq2.Name = "pnlq2";
            this.pnlq2.Size = new System.Drawing.Size(778, 291);
            this.pnlq2.TabIndex = 2;
            // 
            // dgrq1
            // 
            this.dgrq1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrq1.Location = new System.Drawing.Point(-1, 0);
            this.dgrq1.Name = "dgrq1";
            this.dgrq1.RowHeadersWidth = 51;
            this.dgrq1.RowTemplate.Height = 24;
            this.dgrq1.Size = new System.Drawing.Size(776, 288);
            this.dgrq1.TabIndex = 0;
            // 
            // txtid_q
            // 
            this.txtid_q.Location = new System.Drawing.Point(199, 25);
            this.txtid_q.Name = "txtid_q";
            this.txtid_q.Size = new System.Drawing.Size(142, 22);
            this.txtid_q.TabIndex = 0;
            // 
            // txtid_pro
            // 
            this.txtid_pro.Location = new System.Drawing.Point(199, 84);
            this.txtid_pro.Name = "txtid_pro";
            this.txtid_pro.Size = new System.Drawing.Size(142, 22);
            this.txtid_pro.TabIndex = 1;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(199, 53);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(142, 22);
            this.txttype.TabIndex = 2;
            // 
            // lblid_q
            // 
            this.lblid_q.AutoSize = true;
            this.lblid_q.Location = new System.Drawing.Point(66, 31);
            this.lblid_q.Name = "lblid_q";
            this.lblid_q.Size = new System.Drawing.Size(78, 16);
            this.lblid_q.TabIndex = 3;
            this.lblid_q.Text = "Id question :";
            this.lblid_q.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(66, 59);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(45, 16);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type :";
            // 
            // lblid_pro
            // 
            this.lblid_pro.AutoSize = true;
            this.lblid_pro.Location = new System.Drawing.Point(66, 87);
            this.lblid_pro.Name = "lblid_pro";
            this.lblid_pro.Size = new System.Drawing.Size(94, 16);
            this.lblid_pro.TabIndex = 5;
            this.lblid_pro.Text = "Id proposition :";
            // 
            // btnqajouter
            // 
            this.btnqajouter.Location = new System.Drawing.Point(24, 43);
            this.btnqajouter.Name = "btnqajouter";
            this.btnqajouter.Size = new System.Drawing.Size(121, 41);
            this.btnqajouter.TabIndex = 0;
            this.btnqajouter.Text = "Ajouter";
            this.btnqajouter.UseVisualStyleBackColor = true;
            // 
            // btnqmodifier
            // 
            this.btnqmodifier.Location = new System.Drawing.Point(174, 43);
            this.btnqmodifier.Name = "btnqmodifier";
            this.btnqmodifier.Size = new System.Drawing.Size(121, 41);
            this.btnqmodifier.TabIndex = 1;
            this.btnqmodifier.Text = "Modifier";
            this.btnqmodifier.UseVisualStyleBackColor = true;
            // 
            // btnqsupprimer
            // 
            this.btnqsupprimer.Location = new System.Drawing.Point(323, 43);
            this.btnqsupprimer.Name = "btnqsupprimer";
            this.btnqsupprimer.Size = new System.Drawing.Size(121, 41);
            this.btnqsupprimer.TabIndex = 2;
            this.btnqsupprimer.Text = "Supprimer";
            this.btnqsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnqafficher
            // 
            this.btnqafficher.Location = new System.Drawing.Point(476, 43);
            this.btnqafficher.Name = "btnqafficher";
            this.btnqafficher.Size = new System.Drawing.Size(121, 41);
            this.btnqafficher.TabIndex = 3;
            this.btnqafficher.Text = "Afficher";
            this.btnqafficher.UseVisualStyleBackColor = true;
            this.btnqafficher.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnqannuler
            // 
            this.btnqannuler.Location = new System.Drawing.Point(628, 43);
            this.btnqannuler.Name = "btnqannuler";
            this.btnqannuler.Size = new System.Drawing.Size(121, 41);
            this.btnqannuler.TabIndex = 4;
            this.btnqannuler.Text = "Annuler";
            this.btnqannuler.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.pnlq2);
            this.Controls.Add(this.pnlq3);
            this.Controls.Add(this.pnlq1);
            this.Name = "Question";
            this.Text = "Question";
            this.pnlq1.ResumeLayout(false);
            this.pnlq1.PerformLayout();
            this.pnlq3.ResumeLayout(false);
            this.pnlq2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrq1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlq1;
        private System.Windows.Forms.Panel pnlq3;
        private System.Windows.Forms.Panel pnlq2;
        private System.Windows.Forms.DataGridView dgrq1;
        private System.Windows.Forms.Label lblid_pro;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblid_q;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtid_pro;
        private System.Windows.Forms.TextBox txtid_q;
        private System.Windows.Forms.Button btnqafficher;
        private System.Windows.Forms.Button btnqsupprimer;
        private System.Windows.Forms.Button btnqmodifier;
        private System.Windows.Forms.Button btnqajouter;
        private System.Windows.Forms.Button btnqannuler;
    }
}