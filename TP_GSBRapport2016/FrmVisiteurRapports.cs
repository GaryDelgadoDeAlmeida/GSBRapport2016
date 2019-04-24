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
    public partial class FrmVisiteurRapports : Form
    {
        private gsbrapport2016Entities mesDonnees;

        public FrmVisiteurRapports(gsbrapport2016Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.rapportBindingSource.DataSource = null;
            
            /* 
             * On converti les données de la base en list et on attribut chaque id
             * du visiteur à notre ComboBox pour poursuivre notre traitement après
             * validation.
             */
            foreach(visiteur unVisiteur in mesDonnees.visiteurs.ToList())
            {
                this.listVisiteurs.Items.Add(unVisiteur.id);
            }

            /* 
             * On prend le premier index comme valeur par défaut sinon le champs
             * sera vide
             */
            this.listVisiteurs.SelectedIndex = 0;
        }

        /// <summary>
        /// On recherche dans la base tous les rapports en lien avec l'id du visiteur
        /// et on attribut les données à notre tableau.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            var rapportVisiteur = (from rapport in this.mesDonnees.rapports
                                   where rapport.idVisiteur == this.listVisiteurs.Text
                                   select rapport).ToList();

            this.rapportBindingSource.DataSource = rapportVisiteur;
        }
    }
}
