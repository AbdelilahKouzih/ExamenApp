namespace Examen
{
    partial class Form1
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
            this.pnl1recherche = new System.Windows.Forms.Panel();
            this.pnlbutton = new System.Windows.Forms.Panel();
            this.pnl2affichage = new System.Windows.Forms.Panel();
            this.dgrExamen = new System.Windows.Forms.DataGridView();
            this.txrid_q = new System.Windows.Forms.TextBox();
            this.txrt_ype = new System.Windows.Forms.TextBox();
            this.lbrid_q = new System.Windows.Forms.Label();
            this.lbrt_ype = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.txtid_pro = new System.Windows.Forms.TextBox();
            this.lblid_pro = new System.Windows.Forms.Label();
            this.btnafficher = new System.Windows.Forms.Button();
            this.pnl1recherche.SuspendLayout();
            this.pnlbutton.SuspendLayout();
            this.pnl2affichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1recherche
            // 
            this.pnl1recherche.Controls.Add(this.lblid_pro);
            this.pnl1recherche.Controls.Add(this.txtid_pro);
            this.pnl1recherche.Controls.Add(this.lbrt_ype);
            this.pnl1recherche.Controls.Add(this.lbrid_q);
            this.pnl1recherche.Controls.Add(this.txrt_ype);
            this.pnl1recherche.Controls.Add(this.txrid_q);
            this.pnl1recherche.Location = new System.Drawing.Point(19, 27);
            this.pnl1recherche.Name = "pnl1recherche";
            this.pnl1recherche.Size = new System.Drawing.Size(764, 153);
            this.pnl1recherche.TabIndex = 0;
            // 
            // pnlbutton
            // 
            this.pnlbutton.Controls.Add(this.btnafficher);
            this.pnlbutton.Controls.Add(this.btnannuler);
            this.pnlbutton.Controls.Add(this.btnvalider);
            this.pnlbutton.Controls.Add(this.btnsupprimer);
            this.pnlbutton.Controls.Add(this.btnmodifier);
            this.pnlbutton.Controls.Add(this.btnajouter);
            this.pnlbutton.Location = new System.Drawing.Point(19, 469);
            this.pnlbutton.Name = "pnlbutton";
            this.pnlbutton.Size = new System.Drawing.Size(764, 69);
            this.pnlbutton.TabIndex = 1;
            // 
            // pnl2affichage
            // 
            this.pnl2affichage.Controls.Add(this.dgrExamen);
            this.pnl2affichage.Location = new System.Drawing.Point(19, 213);
            this.pnl2affichage.Name = "pnl2affichage";
            this.pnl2affichage.Size = new System.Drawing.Size(764, 228);
            this.pnl2affichage.TabIndex = 2;
            // 
            // dgrExamen
            // 
            this.dgrExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrExamen.Location = new System.Drawing.Point(0, 0);
            this.dgrExamen.Name = "dgrExamen";
            this.dgrExamen.RowHeadersWidth = 51;
            this.dgrExamen.RowTemplate.Height = 24;
            this.dgrExamen.Size = new System.Drawing.Size(764, 277);
            this.dgrExamen.TabIndex = 0;
            this.dgrExamen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrExamen_CellContentClick);
            // 
            // txrid_q
            // 
            this.txrid_q.Location = new System.Drawing.Point(153, 17);
            this.txrid_q.Name = "txrid_q";
            this.txrid_q.Size = new System.Drawing.Size(254, 22);
            this.txrid_q.TabIndex = 0;
            // 
            // txrt_ype
            // 
            this.txrt_ype.Location = new System.Drawing.Point(153, 62);
            this.txrt_ype.Name = "txrt_ype";
            this.txrt_ype.Size = new System.Drawing.Size(254, 22);
            this.txrt_ype.TabIndex = 1;
            // 
            // lbrid_q
            // 
            this.lbrid_q.AutoSize = true;
            this.lbrid_q.Location = new System.Drawing.Point(17, 20);
            this.lbrid_q.Name = "lbrid_q";
            this.lbrid_q.Size = new System.Drawing.Size(81, 16);
            this.lbrid_q.TabIndex = 2;
            this.lbrid_q.Text = "Id question : ";
            this.lbrid_q.Click += new System.EventHandler(this.lbrid_q_Click);
            // 
            // lbrt_ype
            // 
            this.lbrt_ype.AutoSize = true;
            this.lbrt_ype.Location = new System.Drawing.Point(17, 68);
            this.lbrt_ype.Name = "lbrt_ype";
            this.lbrt_ype.Size = new System.Drawing.Size(118, 16);
            this.lbrt_ype.TabIndex = 3;
            this.lbrt_ype.Text = "Type de question :";
            this.lbrt_ype.Click += new System.EventHandler(this.lbrt_ype_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(21, 22);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(97, 37);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(141, 23);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(98, 36);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(269, 23);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(98, 36);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(404, 23);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(98, 36);
            this.btnvalider.TabIndex = 3;
            this.btnvalider.Text = "valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(532, 23);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(98, 36);
            this.btnannuler.TabIndex = 4;
            this.btnannuler.Text = "annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // txtid_pro
            // 
            this.txtid_pro.Location = new System.Drawing.Point(153, 109);
            this.txtid_pro.Name = "txtid_pro";
            this.txtid_pro.Size = new System.Drawing.Size(254, 22);
            this.txtid_pro.TabIndex = 4;
            // 
            // lblid_pro
            // 
            this.lblid_pro.AutoSize = true;
            this.lblid_pro.Location = new System.Drawing.Point(18, 115);
            this.lblid_pro.Name = "lblid_pro";
            this.lblid_pro.Size = new System.Drawing.Size(94, 16);
            this.lblid_pro.TabIndex = 5;
            this.lblid_pro.Text = "Id proposition :";
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(654, 23);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(99, 36);
            this.btnafficher.TabIndex = 5;
            this.btnafficher.Text = "afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 580);
            this.Controls.Add(this.pnl2affichage);
            this.Controls.Add(this.pnlbutton);
            this.Controls.Add(this.pnl1recherche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1recherche.ResumeLayout(false);
            this.pnl1recherche.PerformLayout();
            this.pnlbutton.ResumeLayout(false);
            this.pnl2affichage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrExamen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1recherche;
        private System.Windows.Forms.Label lbrt_ype;
        private System.Windows.Forms.Label lbrid_q;
        private System.Windows.Forms.TextBox txrt_ype;
        private System.Windows.Forms.TextBox txrid_q;
        private System.Windows.Forms.Panel pnlbutton;
        private System.Windows.Forms.Panel pnl2affichage;
        private System.Windows.Forms.DataGridView dgrExamen;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label lblid_pro;
        private System.Windows.Forms.TextBox txtid_pro;
        private System.Windows.Forms.Button btnafficher;
    }
}

