using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Przedmiot
{
    int v; //wartość
    int w; //waga
    int numerPrzedmiotu;
    bool czyMiesci;

    public Przedmiot(int v, int w, int numerPrzedmiotu)
    {
        this.v = v;
        this.w = w;
        this.numerPrzedmiotu = numerPrzedmiotu;
        this.czyMiesci = false;
    }

    public void Przypisanie(int v, int w)
    {
        this.v = v;
        this.w = w;
    }

    public void WypiszPrzedmioty()
    {
        Console.WriteLine( this.numerPrzedmiotu + ". value: " + this.v + " weight: " + this.w);
    }

}

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int iloscPrzedmiotow = 10;
            int C = 50; //capasity


            RandomNumberGenerator rng = new RandomNumberGenerator(1);

            List<int> values = new List<int>();
            List<int> weight = new List<int>();
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>();



            for (int i = 0; i < iloscPrzedmiotow; i++)
            {
                values.Add(rng.nextInt(1, 29));
                weight.Add(rng.nextInt(1, 29));
            }

            for (int i = 0; i < iloscPrzedmiotow; i++)
            {
                listaPrzedmiotow.Add(new Przedmiot(values[i], weight[i], i+1));
            }

        
            foreach (var przedmiot in listaPrzedmiotow)
            {
                przedmiot.WypiszPrzedmioty();
            }
            Console.Read();
        }
    }
}
