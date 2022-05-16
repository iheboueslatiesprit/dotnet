using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public enum TypeTrophee
    {
        coupe, championnat
    }
    public class Trophee
    {

        public int TropheeId { get; set; }

        public TypeTrophee TypeTrophee { get; set; }

        [DataType(DataType.Currency)]
        public double Recomponse { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateTrophee { get; set; }

        //ay relation feha virtual prefix
        public virtual Equipe Equipe { get; set; }
        //FK houni sammineh kima nhebou (par convention yekhou esm PK )
        public int EquipeFK { get; set; }
    }
}
