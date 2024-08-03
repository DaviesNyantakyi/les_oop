using auto; // When you want to use the class auto. You have to reference to the namespace in the Auto.cs file
using System;


namespace lesOOP
{

  class Program
    {
        static void Main() {


            Auto auto = new Auto(merk:"Tesla model 3", kleur: "Wit",aantalDeuren: 4,maxSnelheid: 200 );

            // Auto object met alleen de deuren en maxSnelheid
            Auto auto2 = new Auto(aantalDeuren: 4, maxSnelheid: 300);
            // Auto object met alleen de 
            Auto auto3 = new Auto(merk: "Range rover");
            Console.WriteLine(auto2.merk);
        }
    }
  
}