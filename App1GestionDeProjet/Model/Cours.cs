using App1GestionDeProjet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1GestionDeProjet.Model
{
    public class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }

        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
    }
}

