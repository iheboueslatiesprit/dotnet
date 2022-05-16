using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Membre
    {
        [Key]
        public int Identifiant { get; set; }

        [Required(ErrorMessage = "Nom obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Prenom obligatoire")]
        public string Prenom { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        //ken fama table associative (manyTomany) thot'ha heya fel les 2 classes
        //w tzid declarihom prop+FK fel table associative
        public virtual List<Contrat> Contrats { get; set; }
    }
}
