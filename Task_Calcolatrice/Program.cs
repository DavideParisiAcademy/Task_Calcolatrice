using System.Reflection;
using Task_Calcolatrice.Classes;

namespace Task_Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcolatrice calcolatrice = new Calcolatrice();
            bool ciclo = true;

            while (ciclo)
            {

                Console.WriteLine("Scegli un'operazione:\n1)Somma\n2)Differenza\n3)Prodotto\n4)Quoziente\n5)Potenza\n6)Radice Quadrata");
                Console.WriteLine("7)Operazioni a più cifre");
                Console.WriteLine("Premere Q per chiudere il programma");

                string? inputUtente = Console.ReadLine();
                
                if (inputUtente is not null)
                {
                    inputUtente = inputUtente.ToUpper();
                }
                    switch (inputUtente)
                    {
                        case "1":
                            calcolatrice.Somma();
                            break;
                        case "2":
                            calcolatrice.Differenza();
                            break;
                        case "3":
                            calcolatrice.Prodotto();
                            break;
                        case "4":
                            calcolatrice.Quoziente();
                            break;
                        case "5":
                            calcolatrice.Potenza();
                            break;
                        case "6":
                            calcolatrice.Radice();
                            break;
                        case "7":
                            Console.WriteLine("Scegli un'operazione a più valori fra:\n1)Somma\n2)Differenza\n3)Prodotto\n4)Quoziente");
                            string? inputUtente1 = Console.ReadLine();
                            if (inputUtente1 is not null)
                            {
                                inputUtente1 = inputUtente1.ToUpper();
                            }
                            switch (inputUtente1) { 
                            
                                case "1":
                                    calcolatrice.SommaComplessa();
                                    break;
                                case "2":
                                    calcolatrice.DifferenzaComplessa();
                                    break;
                                case "3":
                                    calcolatrice.ProdottoComplesso();
                                    break;
                                case "4":
                                calcolatrice.DifferenzaComplessa();
                                    break;                           
                            }
                            break;
                        case "Q":
                            ciclo = false;
                            break;

                        default:
                            Console.WriteLine("ERRORE");
                            break;
                    }
                }
            }
        }
    }

