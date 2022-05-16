using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Equipe
    {
        public string AdresseLocal { get; set; }


        public int EquipeId { get; set; }

        public string Logo { get; set; }

        public string NomEquipe { get; set; }

        //ay relation feha virtual prefix
        public virtual List<Trophee> Trophees { get; set; }


        //ken fama table associative (manyTomany) thot'ha heya fel les 2 classes
        //w tzid declarihom prop+FK fel table associative
        public virtual List<Contrat> Contrats { get; set; }
    }
}
