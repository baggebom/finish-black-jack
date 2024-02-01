using System;
namespace Projekt
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till 21:an");
            Random slump = new Random();


            string menyval = "0";
            while (menyval != "4")
            {
                Console.WriteLine("välj alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. spelets regler");
                Console.WriteLine("4. avsluta programmet");
                menyval = Console.ReadLine();
                switch (menyval)
                {
                    case "1":
                        Console.WriteLine("Spela omgång 21:an");
                        int datornspoäng = 0;
                        int spelarenspoäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        datornspoäng += slump.Next(1, 11);
                        datornspoäng += slump.Next(1, 11);
                        spelarenspoäng +=slump.Next(1, 11);
                        spelarenspoäng +=slump.Next(1, 11);

                        string kortval = "";

                        while(kortval != "n" && spelarenspoäng<= 21)
                        {
                            Console.WriteLine($"din poäng:{spelarenspoäng}");
                            Console.WriteLine($"datorns poäng; {datornspoäng}");
                            Console.WriteLine("vill du ha ett till kort? (j/n)");
                            kortval = Console.ReadLine();

                            switch(kortval)
                            {
                                case "j":
                                    int nypoäng = slump.Next(1, 11);
                                    spelarenspoäng += nypoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nypoäng} poäng");
                                    Console.WriteLine($"din totalpoäng är {spelarenspoäng}");
                                    break;
                                case "n":
                                    break;
                                default:
                                    Console.WriteLine("du valde inte ett giltigt alternativ");
                                    break;
                            }

                        }
                        if (spelarenspoäng > 21)
                        {
                            Console.WriteLine("du har mer än 21, du har förlorat");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                            while (datornspoäng<spelarenspoäng&& datornspoäng<=21)
                            {
                                int datornsnyapoäng=slump.Next(1, 11);
                                datornspoäng += datornsnyapoäng;
                                Console.WriteLine($"datorn drog ett kort värt {datornsnyapoäng}");

                            }
                        Console.WriteLine($"Din poäng: {spelarenspoäng}");
                        Console.WriteLine($"datorns poäng: {datornspoäng}");

                        if (datornspoäng >21)
                        {

                            Console.WriteLine("du har vunnit");
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("datorn har vunnit");
                        }
                        


                        
                       
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "2":
                        Console.WriteLine("Visa senaste vinnaren");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("spelets regler");
                        Console.WriteLine("Ditt mål är att vara tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("Dra fler kort tills du är nöjd eller får över 21");
                        Console.WriteLine("När du är färdig drar datron kort till den har");
                        Console.WriteLine("Mer poäng än dig eller över 21 poäng");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":

                        Console.WriteLine("programmet avslutas");
                        break;

                    default:
                        Console.WriteLine("du valde inte ett giltigt alternativ");
                        break;
                }
            }

            


        }
    }
}
