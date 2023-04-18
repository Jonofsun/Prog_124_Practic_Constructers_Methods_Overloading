using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practic_Constructers_Methods_Overloading
{
    internal class Car
    {
        string _make;
        string _modle;
        int _year;
        int _mileage;

        public Car()
        {
            _make = "unassinged";
            _modle = "unassinged";
            _year = 0;
            _mileage = 0;
        }

        public Car(string make, string modle)
        {
            _make = make;
            _modle = modle;
            _year = 0;
            _mileage = 0;
        }

        public Car(string make, string modle, int year, int mileage)
        {
            _make = make;
            _modle = modle;
            _year = year;
            _mileage = mileage;
        }

        public string Make { get => _make; set => _make = value; }
        public string Modle { get => _modle; set => _modle = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }
        public override string ToString()
        {
            return $"{_year} {_make} {_modle} - {_mileage}";
        }
    }
}
