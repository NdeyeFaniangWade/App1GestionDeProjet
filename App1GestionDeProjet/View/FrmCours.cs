using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1GestionDeProjet.Model;

namespace App1GestionDeProjet.View
{
    public partial class FrmCours : Form
    {
        public FrmCours()
        {
            InitializeComponent();
        }
        bdabsenceContext db= new bdabsenceContext();

        private void ResetForm()
        {
            txtDate.Text = DateTime.Now.ToString();
            txHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtNom.Text = string.Empty;
            cbbClasse.Text = "Selectonner...";
            cbbMatiere.Text = "Selectionner...";
            cbbSalle.Text = "Selectionner...";
            // Chargement Combobox matiere
            cbbMatiere.DataSource = db.Matiere.ToList();
            cbbMatiere.ValueMember = "ID";
            cbbMatiere.DisplayMember = "LibelleMatiere";
            //Todo chargement Salle
            //Todp chargement Classe
            // Chargement du GridView

        }

        private void FrmCours_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
