using System;

namespace Porownywanie
{
class Program
{
static public void Main(){

    
        var p1 = new Pracownik();
Console.WriteLine(p1);
p1.Wynagrodzenie = 100;
p1.Nazwisko = "   Molenda  ";
p1.DataZatrudnienia = new DateTime(2010, 10, 01);
Console.WriteLine(p1);

var p2 = new Pracownik("Abacki", new DateTime(2011,8,9), 200);
Console.WriteLine(p2);
    }
}
}
