using Data;
using System;

namespace ExamenGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.create data models
            //2.config data context ( dbSets ,dbName , special relations )
            //3.create DB : console nuget : Add-Migration , update-database
                    // !!!! [ Porject de demarrage ExamenGUI , nuget COnsole project par defaut Data ]
            Console.WriteLine("Hello World!");
            ExamenContext ctx = new ExamenContext();

        }
    }
}
