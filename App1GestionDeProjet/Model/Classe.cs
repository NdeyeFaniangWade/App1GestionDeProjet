using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1GestionDeProjet.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }
        [Required, MaxLength(15)]
        public string NomClasse { get; set; }
        [Required, MaxLength(15)]
        public string NiveauClasse { get; set; }
        [Required]
        public int Annee { get; set; }


    }
}
