using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_Calcolatrice.Classes
{
    internal class Calcolatrice
    {

        //COSTRUTTORE DEFAULT

        

        //METHODS

        //1) SOMMA
        
        public void Somma()
        {
            Console.WriteLine("Inserisci due valori da Sommare");
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            Console.WriteLine($"Risultato: {x1 + y1}");
        }
        public void Differenza()
        {
            Console.WriteLine("Inserisci due valori da Sottrarre");
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            Console.WriteLine($"Risultato: {x1 - y1}");
        }
        public void Prodotto()
        {
            Console.WriteLine("Inserisci due valori da Moltiplicare");
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            Console.WriteLine($"Risultato: {x1 * y1}");
        }
        public void Quoziente()
        {
            Console.WriteLine("Inserisci due valori da Dividere");
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            if (y1 != 0)
                Console.WriteLine($"Risultato: {x1 / y1}");
            else Console.WriteLine("Errore: Divisione per 0");
        }
        public void Potenza()
        {
            Console.WriteLine("Inserisci la base: ");
            string? x = Console.ReadLine();
            Console.WriteLine("Inserisci l'esponente: ");
            string? y = Console.ReadLine();
            double y1 = Convert.ToDouble(y);
            double x1 = Convert.ToDouble(x);;
            
            Console.WriteLine($"Risultato: {Math.Pow(x1, y1)}");
        }
        public void Radice()
        {
            Console.WriteLine("Inserisci il radicando: ");
            string? x = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            if (x1 >= 0)
                Console.WriteLine($"Risultato: {Math.Sqrt(x1)}");
            else
                Console.WriteLine("Errore: errore di inserimento");
        }

        public void SommaComplessa()
        {
            Console.WriteLine("Quanti valori vuoi inserire? ");
            string? d = Console.ReadLine();
            int dimensione = Convert.ToInt32(d);
            if (dimensione > 0)
            {
                double[] sommatoria = new double[dimensione];
                double s = 0;
                //Inserimento
                for (int i = 0; i < dimensione; i++)
                {
                    Console.WriteLine("Inserisci valore: ");
                    double valore = Convert.ToDouble(Console.ReadLine());
                    sommatoria[i] = valore;
                    s = s + valore;
                }
                Console.WriteLine($"Risultato:{s}");
            }
            else { 
                Console.WriteLine("Errore di inserimento: Dimensione negativa");
            }
        }
        public void DifferenzaComplessa()
        {
            Console.WriteLine("Quanti valori vuoi inserire? ");
            string? d = Console.ReadLine();
            int dimensione = Convert.ToInt32(d);
            double[] differenza = new double[dimensione];
            double p;
            double s = 0;

            //Inserimento
            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine("Inserisci valore: ");
                double valore = Convert.ToDouble(Console.ReadLine());
                differenza[i] = valore;
                      
            } 
            
            Console.WriteLine($"Risultato:{s}"); 
        }

        public void ProdottoComplesso()
        {
            Console.WriteLine("Quanti valori vuoi inserire? ");
            string? d = Console.ReadLine();
            int dimensione = Convert.ToInt32(d);
            if (dimensione > 0)
            {
                double[] Produttoria = new double[dimensione];
                double s = 1;
                //Inserimento
                for (int i = 0; i < dimensione; i++)
                {
                    Console.WriteLine("Inserisci valore: ");
                    double valore = Convert.ToDouble(Console.ReadLine());
                    Produttoria[i] = valore;
                    s = s * valore;
                }
                Console.WriteLine($"Risultato:{s}");
            }
        }

        public void QuozienteComlplesso()
        {
            Console.WriteLine("Quanti valori vuoi inserire? ");
            string? d = Console.ReadLine();
            int dimensione = Convert.ToInt32(d);
            double[] Quoziente = new double[dimensione];

            if (dimensione <= 0)
            {
                Console.WriteLine("Errore di inserimento: Dimensione negativa");
            }
            else
            {
                //Inserimento
                for (int i = 0; i < dimensione; i++)
                {

                    Console.WriteLine("Inserisci valore: ");
                    double valore = Convert.ToDouble(Console.ReadLine());
                    Quoziente[i] = valore;
                }
                for (int j = 0; j < dimensione; j++)
                {
                    double s = Quoziente[j];
                    Console.WriteLine(Quoziente[j]);
                    //if (Quoziente[j + 1] != 0) {
                    //    s = s / Quoziente[j + 1];
                    //}
                    //Console.WriteLine($"Risultato: {s}");         
                }
            }
        }

        

        

    }
}
