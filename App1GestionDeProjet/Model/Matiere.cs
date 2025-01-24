using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Pour définir des contraintes
using System.ComponentModel.DataAnnotations.Schema;

namespace App1GestionDeProjet.Model
{
    public class Matiere
    {
       
        [Key]
        public int IdMatiere { get; set; }

        [Required(ErrorMessage ="*"), MaxLength(60 ,ErrorMessage ="Taille Maximale est de 60")]

        public string LibelleMatiere { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "Taille Maximale est de 40")]
        public string NiveauMatiere { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "Taille Maximale est de 40")]
        public string FiliereMatiere { get; set; }
    }
}