namespace TP_GSBRapport2016
{
    partial class FrmVisiteurRapports
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValider = new System.Windows.Forms.Button();
            this.listVisiteurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.date,
            this.motif,
            this.bilan,
            this.idVisiteur,
            this.idMedecin});
            this.dataGridView1.DataSource = this.rapportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // motif
            // 
            this.motif.DataPropertyName = "motif";
            this.motif.HeaderText = "motif";
            this.motif.Name = "motif";
            // 
            // bilan
            // 
            this.bilan.DataPropertyName = "bilan";
            this.bilan.HeaderText = "bilan";
            this.bilan.Name = "bilan";
            // 
            // idVisiteur
            // 
            this.idVisiteur.DataPropertyName = "idVisiteur";
            this.idVisiteur.HeaderText = "idVisiteur";
            this.idVisiteur.Name = "idVisiteur";
            // 
            // idMedecin
            // 
            this.idMedecin.DataPropertyName = "idMedecin";
            this.idMedecin.HeaderText = "idMedecin";
            this.idMedecin.Name = "idMedecin";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "medecin";
            this.dataGridViewTextBoxColumn1.HeaderText = "medecin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "visiteur";
            this.dataGridViewTextBoxColumn2.HeaderText = "visiteur";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnValider.Location = new System.Drawing.Point(543, 138);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 29);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // listVisiteurs
            // 
            this.listVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listVisiteurs.FormattingEnabled = true;
            this.listVisiteurs.Location = new System.Drawing.Point(330, 92);
            this.listVisiteurs.Name = "listVisiteurs";
            this.listVisiteurs.Size = new System.Drawing.Size(178, 24);
            this.listVisiteurs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(221, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visiteur :";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // rapportBindingSource
            // 
            this.rapportBindingSource.DataSource = typeof(TP_GSBRapport2016.rapport);
            // 
            // FrmVisiteurRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVisiteurs);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVisiteurRapports";
            this.Text = "Rapport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rapportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox listVisiteurs;
        private System.Windows.Forms.Label label1;
    }
}