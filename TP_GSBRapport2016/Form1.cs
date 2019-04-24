using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GSBRapport2016
{
    public partial class Form1 : Form
    {
        private gsbrapport2016Entities mesDonnees;

        public Form1()
        {
            InitializeComponent();
            this.mesDonnees = new gsbrapport2016Entities();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamentGerer f = new FrmMedicamentGerer();
            f.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamentListe f = new FrmMedicamentListe();
            f.Show();
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMedecinGerer f = new FrmMedecinGerer();
            f.Show();
        }

        private void dernierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedecinDernierRapport f = new FrmMedecinDernierRapport();
            f.Show();
        }

        private void gérerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmVisiteurGerer f = new FrmVisiteurGerer(this.mesDonnees);
            f.Show();
        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisiteurRapports f = new FrmVisiteurRapports(this.mesDonnees);
            f.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapportAjout f = new FrmRapportAjout();
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapportRecherche f = new FrmRapportRecherche();
            f.Show();
        }

        public void setGsbrapport2016Entities(gsbrapport2016Entities mesDonnees)
        {
            this.mesDonnees = mesDonnees;
        }
    }
}
