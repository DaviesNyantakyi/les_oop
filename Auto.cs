using System;


namespace auto
{
    public class Auto
    {
        public string merk = "Tesla model S";
        public string kleur = "Wit";
        public int aantalDeuren = 4;
        public int maxSnelheid = 200;
        public int pk = 100;

        public Auto(string merk, string kleur, int aantalDeuren, int maxSnelheid)
        {
            this.merk = merk;
            this.kleur = kleur;
            this.aantalDeuren = aantalDeuren;
            this.maxSnelheid = maxSnelheid;
        }

        // Constuctor overloading met alleen de merk 
        public Auto(string merk)
        {
            this.merk = merk;

        }

        public Auto(int aantalDeuren, int maxSnelheid)
        {
            this.aantalDeuren = aantalDeuren;
            this.maxSnelheid = maxSnelheid;
        }
    }
}