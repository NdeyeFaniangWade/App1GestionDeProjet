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
    public partial class FrmMatiere : Form
    {
        public FrmMatiere()
        {
            InitializeComponent();
        }
        bdabsenceContext db = new bdabsenceContext();

        public void Effacer()
        {
            txtFiliere.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtNiveau.Text = string.Empty;
            dgMatiere.DataSource = db.Matiere.ToList();
            db.SaveChanges();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            matiere.LibelleMatiere = txtLibelle.Text;
            matiere.FiliereMatiere = txtFiliere.Text;
            matiere.NiveauMatiere = txtNiveau.Text;
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matiere.Find(id);
            m.LibelleMatiere = txtLibelle.Text;
            m.FiliereMatiere = txtFiliere.Text;
            m.NiveauMatiere = txtNiveau.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matiere.Find(id);
            db.Matiere.Remove(m);
            db.SaveChanges();
            Effacer();

        }

        private void FrmMatiere_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void FrmMatiere_Load_1(object sender, EventArgs e)
        {

        }
    }
}