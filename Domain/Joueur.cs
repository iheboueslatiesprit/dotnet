using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
     public class Joueur : Membre
    {
        public string Poste { get; set; }
    }

    /*
     * TPT
[Table("People")]
public class Person
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

[Table("Students")]
public class Student : Person
{
    public DateTime EnrollmentDate { get; set; }
}

[Table("Teachers")]
public class Teacher : Person
{
    public DateTime HireDate { get; set; }
}
     * 
     */

}
