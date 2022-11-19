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
            this.txrid_e = new System.Windows.Forms.TextBox();
            this.txrdate_debut = new System.Windows.Forms.TextBox();
            this.lbrid_e = new System.Windows.Forms.Label();
            this.lbrdate_debut = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.txrid_qu = new System.Windows.Forms.TextBox();
            this.lblid_qu = new System.Windows.Forms.Label();
            this.btnafficher = new System.Windows.Forms.Button();
            this.pnl1recherche.SuspendLayout();
            this.pnlbutton.SuspendLayout();
            this.pnl2affichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1recherche
            // 
            this.pnl1recherche.Controls.Add(this.lblid_qu);
            this.pnl1recherche.Controls.Add(this.txrid_qu);
            this.pnl1recherche.Controls.Add(this.lbrdate_debut);
            this.pnl1recherche.Controls.Add(this.lbrid_e);
            this.pnl1recherche.Controls.Add(this.txrdate_debut);
            this.pnl1recherche.Controls.Add(this.txrid_e);
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
            // txrid_e
            // 
            this.txrid_e.Location = new System.Drawing.Point(153, 17);
            this.txrid_e.Name = "txrid_e";
            this.txrid_e.Size = new System.Drawing.Size(254, 22);
            this.txrid_e.TabIndex = 0;
            this.txrid_e.TextChanged += new System.EventHandler(this.txrid_q_TextChanged);
            // 
            // txrdate_debut
            // 
            this.txrdate_debut.Location = new System.Drawing.Point(153, 62);
            this.txrdate_debut.Name = "txrdate_debut";
            this.txrdate_debut.Size = new System.Drawing.Size(254, 22);
            this.txrdate_debut.TabIndex = 1;
            // 
            // lbrid_e
            // 
            this.lbrid_e.AutoSize = true;
            this.lbrid_e.Location = new System.Drawing.Point(17, 20);
            this.lbrid_e.Name = "lbrid_e";
            this.lbrid_e.Size = new System.Drawing.Size(78, 16);
            this.lbrid_e.TabIndex = 2;
            this.lbrid_e.Text = "Id examen : ";
            this.lbrid_e.Click += new System.EventHandler(this.lbrid_q_Click);
            // 
            // lbrdate_debut
            // 
            this.lbrdate_debut.AutoSize = true;
            this.lbrdate_debut.Location = new System.Drawing.Point(18, 68);
            this.lbrdate_debut.Name = "lbrdate_debut";
            this.lbrdate_debut.Size = new System.Drawing.Size(96, 16);
            this.lbrdate_debut.TabIndex = 3;
            this.lbrdate_debut.Text = "date de debut :";
            this.lbrdate_debut.Click += new System.EventHandler(this.lbrt_ype_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(21, 22);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(97, 37);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
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
            // txrid_qu
            // 
            this.txrid_qu.Location = new System.Drawing.Point(153, 109);
            this.txrid_qu.Name = "txrid_qu";
            this.txrid_qu.Size = new System.Drawing.Size(254, 22);
            this.txrid_qu.TabIndex = 4;
            // 
            // lblid_qu
            // 
            this.lblid_qu.AutoSize = true;
            this.lblid_qu.Location = new System.Drawing.Point(18, 115);
            this.lblid_qu.Name = "lblid_qu";
            this.lblid_qu.Size = new System.Drawing.Size(78, 16);
            this.lblid_qu.TabIndex = 5;
            this.lblid_qu.Text = "Id question :";
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(654, 23);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(99, 36);
            this.btnafficher.TabIndex = 5;
            this.btnafficher.Text = "afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
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
        private System.Windows.Forms.Label lbrdate_debut;
        private System.Windows.Forms.Label lbrid_e;
        private System.Windows.Forms.TextBox txrdate_debut;
        private System.Windows.Forms.TextBox txrid_e;
        private System.Windows.Forms.Panel pnlbutton;
        private System.Windows.Forms.Panel pnl2affichage;
        private System.Windows.Forms.DataGridView dgrExamen;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label lblid_qu;
        private System.Windows.Forms.TextBox txrid_qu;
        private System.Windows.Forms.Button btnafficher;
    }
}

