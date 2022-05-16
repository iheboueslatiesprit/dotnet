using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
   public class Contrat
    {
        //Declari composite primary key fi Examen context (date + 2 ids)
        public DateTime DateContrat { get; set; }

        [Range(0, 24)]
        public int DureeMois { get; set; }

        public double Salaire { get; set; }

        //Les 2 tables li chnorbtouhom ICI fields
        public virtual Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
        public virtual Membre Membre { get; set; }
        public int Identifiant { get; set; }

    }
}
