using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1GestionDeProjet.Model
{
    // Annotation exceptionnelle pour MySQL
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class bdabsenceContext : DbContext
    {
        // Constructeur par défaut
        public bdabsenceContext() : base("bdabsenceContext")
        {
        }

        // Déclaration des DbSet pour chaque entité
        public DbSet<Matiere> Matiere { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Cours> Cours { get; set; } // Correction : DbSet<Cours>
        public DbSet<Salle> Salle { get; set; } // Correction : DbSet<Salle>
    }
}