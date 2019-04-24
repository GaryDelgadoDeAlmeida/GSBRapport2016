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
    public partial class FrmVisiteurGerer : Form
    {
        private gsbrapport2016Entities mesDonnees;
        private string idVisiteur;

        public FrmVisiteurGerer(gsbrapport2016Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSourceVisiteurGerer.DataSource = mesDonnees.visiteurs.ToList();
            this.idVisiteur = mesDonnees.visiteurs.ToList()[0].id;
        }

        /// <summary>
        /// Récupére l'id du visiteur, fait la recherche dans la base
        /// puis s'il ne possède aucun rapport, la suppression se produit
        /// sinon si une erreur est rencontré, une exception est données et 
        /// la suppression dans la base de données n'est pas effectué.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Read Only => true;
            changerEtat(true);

            try
            {
                var x = (from v in this.mesDonnees.visiteurs
                         where v.id == this.idVisiteur
                         select v).First();

                this.mesDonnees.visiteurs.Remove(x);
                this.mesDonnees.SaveChanges();
                MessageBox.Show("Suppression réussi.");
                this.idVisiteur = this.txtId.Text;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Par défaut, READ ONLY = true
            changerEtat(false);
        }

        /// <summary>
        /// On crée un nouveau visiteur auquel on attribue les valeurs des
        /// input texte aux attributs de l'objet visiteur. Cette objet sera ensuite ajouter dans
        /// la base de données.
        /// 
        /// Cette méthode fonctionne aussi pour la mise à jour avec une erreur
        /// récéptionnée mais la modification a été correctement effectuée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            changerEtat(true);
            try
            {
                visiteur v = new visiteur();
                v.id = this.txtId.Text;
                v.nom = this.txtNom.Text;
                v.prenom = this.txtPrenom.Text;
                v.adresse = this.txtAdr.Text;
                v.cp = this.txtCP.Text;
                v.ville = this.txtVille.Text;

                this.mesDonnees.visiteurs.Add(v);
                this.mesDonnees.SaveChanges();
                this.idVisiteur = this.txtId.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changerEtat(bool b)
        {
            //Enable the possibility to ReadOnly so we can write or modify the data
            this.txtId.ReadOnly = b;
            this.txtNom.ReadOnly = b;
            this.txtPrenom.ReadOnly = b;
            this.txtAdr.ReadOnly = b;
            this.txtCP.ReadOnly = b;
            this.txtVille.ReadOnly = b;

            // Inverse logic of the bool b for the visibility of btnValider
            if (b)
            {
                this.btnValider.Visible = false;
            }
            else
            {
                this.btnValider.Visible = true;
            }
        }

        private void changeEtatExceptNum(bool b)
        {
            //Enable the possibility to ReadOnly so we can write or modify the data
            this.txtNom.ReadOnly = b;
            this.txtPrenom.ReadOnly = b;
            this.txtAdr.ReadOnly = b;
            this.txtCP.ReadOnly = b;
            this.txtVille.ReadOnly = b;

            // Inverse logic of the bool b for the visibility of btnValider
            if (b)
            {
                this.btnValider.Visible = false;
            }
            else
            {
                this.btnValider.Visible = true;
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.idVisiteur = this.txtId.Text;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.idVisiteur = this.txtId.Text;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.idVisiteur = this.txtId.Text;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.idVisiteur = this.txtId.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.changeEtatExceptNum(false);
            this.idVisiteur = this.txtId.Text;
        }
    }
}
