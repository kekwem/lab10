using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Person:IComparable<Person>
    {
        public string imie;
        public string nazwisko;
        public double waga;
        public double wiek;
        public Person()
        {

        }
        public Person(string imie, string nazwisko, double waga, double wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wiek = wiek;
        }

        public int CompareTo(Person other)
        {
            return imie.CompareTo(other.imie);
        }

        public override string ToString()
        {
            return imie + " " + nazwisko + " " + waga + " " + wiek;
        }
    }
}
