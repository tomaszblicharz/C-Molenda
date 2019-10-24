using System;

namespace Porownywanie
{
    public class Pracownik
    {
        private string _naz;
        public string Nazwisko 
        {
            get => _naz;
            set => _naz = value.Trim(' ');
            }        
        private DateTime _date;
        public DateTime DataZatrudnienia
        {
            get => _date;
            set{
                if (DateTime.Today <= value)
                {
                throw new ArgumentException("error");
                }
                else
                {
                    _date = value;
                }
            }
        }
       private decimal _wyn;
        private string v1;
        private DateTime dateTime;
        private int v2;

        public Pracownik(string v1, DateTime dateTime, int v2)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
        }

        public decimal Wynagrodzenie
        {
            get => _wyn;
            set => _wyn = (value < 0)? 0: value;
        }

           public override string ToString() 
        => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie} PLN)";

     public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;

   

        public Pracownik()
        {
        Nazwisko = "Anonoom";
        _date = DateTime.Today;
        Wynagrodzenie = 0;
        }

    }   
    
 
}