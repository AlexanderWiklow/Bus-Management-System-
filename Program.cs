/*Hjälpkod för att komma igång
 * Notera att båda klasserna är i samma fil för att det ska underlätta.
 * Om programmet blir större bör man ha klasserna i separata filer såsom jag går genom i filmen
 * Då kan det vara läge att ställa in startvärden som jag gjort.
 * Man kan också skriva ut saker i konsollen i konstruktorn för att se att den "vaknar
 * Denna kod hjälper mest om du siktar mot betyget E och C
 * För högre betyg krävs mer självständigt arbete
 */
using System;
using System.Linq;
//Nedan är namnet på "namespace" - alltså projektet. 
//SKapa ett nytt konsollprojekt med namnet "Bussen" så kan ni kopiera över all koden rakt av från denna fil
namespace Bussen
{
    class Buss
    {
        public int[] passagerare;
        public int antal_passagerare;


        public void Run()
        {
            Console.WriteLine("Welcome to the awesome Buss-simulator");
            //Här ska menyn ligga för att göra saker
            //Jag rekommenderar switch och case här
            //I filmen nummer 1 för slutprojektet så skapar jag en meny på detta sätt.
            //Dessutom visar jag hur man anropar metoderna nedan via menyn
            //Börja nu med att köra koden för att se att det fungerar innan ni sätter igång med menyn.
            //Bygg sedan steg-för-steg och testkör koden.

            int val = 0;
            do
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till en passagerare.");
                Console.WriteLine("1. Skriv ut åldrar på passagerare.");
                Console.WriteLine("3. Beräkna den totala åldern av alla passagerare.");
                Console.WriteLine("4. Beräkna den genomsnittliga åldern");
                Console.WriteLine("5. Avsluta programmet.");

                val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        add_passenger();
                        break;
                    case 2:
                        print_buss();
                        break;
                    case 3:
                        calc_total_age();
                        break;
                    case 4:
                        Console.WriteLine("Programmet avslutas");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;


                }
            } while (val != 0);
        }

        //Metoder för betyget E

        public void add_passenger()
        {
            //Lägg till passagerare. Här skriver man då in ålder men eventuell annan information.
            //Om bussen är full kan inte någon passagerare stiga på

            if (antal_passagerare >= 25)
            {
                Console.WriteLine("Sorry the buss is full");
            }

            Console.WriteLine("Hur många passagerare vill du lägga till?");
            int antalPassagerare = int.Parse(Console.ReadLine());
            string[] passagerare = new string[antalPassagerare];

            // Läs in alla passagerare
            for (int i = 0; i < antalPassagerare; i++)
            {
                Console.WriteLine($"Skriv in åldern på passagerare: {i + 1} av {antalPassagerare}");
                passagerare[i] = Console.ReadLine();
            }
            Console.WriteLine();

        }

        public void print_buss()
        {
            //Skriv ut alla värden ur vektorn. Alltså - skriv ut alla passagerare

            // Skriv ut passagerarna till användaren igen
            foreach (int item in passagerare)
            {
                Console.WriteLine($"Ålder {item + 1}: {passagerare[item]}");
            }

        }

        public int calc_total_age()
        {
            //Beräkna den totala åldern. 
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void


            int sum = 0;
            for (int i = 0; i < passagerare.Length; i++)
            {
                sum += passagerare[i];
            }
            Console.WriteLine("Totala åldern är " + sum);
            return sum;
        }

        //Metoder för betyget C   

        public void Calc_average_age()
        {
            //Betyg C
            //Beräkna den genomsnittliga åldern. Kanske kan man tänka sig att denna metod ska returnera något annat värde än heltal?
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void

            //public decimal Average(params int[] customerssalary)
            //{
            //    int sum = Sum(customerssalary);
            //    decimal result = (decimal)sum / customerssalary.Length;
            //    return result;
            //}
        }

        //public int Max_age()
        //{
        //    int maxAge = 0;
        //    maxAge = passagerare[0];
        //    for (int i = 0; i < passagerare.Length; i++)
        //    {
        //        if (passagerare[i] > maxAge)
        //        {
        //            maxAge = passagerare[i];
        //        }
        //    }
        //    Console.WriteLine("The oldest age is [0]", maxAge);
        //    return maxAge;

        //Betyg C
        //ta fram den passagerare med högst ålder. Detta ska ske med egen kod och är rätt klurigt.
        //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void

        //Bubblesort:
        //using System;
        //	namespace BubbleSort
        //		{
        //			class MySort
        //			{
        //				static void Main(string[] args)
        //				{
        //					int[] arr = { 78, 55, 45, 98, 13 };
        //					int temp;
        //					for (int j = 0; j <= arr.Length - 2; j++)
        //					{
        //						for (int i = 0; i <= arr.Length - 2; i++)
        //						{
        //							if (arr[i] > arr[i + 1])
        //							{
        //								temp = arr[i + 1];
        //								arr[i + 1] = arr[i];
        //								arr[i] = temp;
        //							}
        //						}
        //					}
        //					Console.WriteLine("Sorted:");
        //					foreach (int p in arr)
        //						Console.Write(p + " ");
        //					Console.Read();
        //				}
        //			}
        //		}
        //	}



        // public void find_age()
        // {
        //Visa alla positioner med passagerare med en viss ålder
        //Man kan också söka efter åldersgränser - exempelvis 55 till 67
        //Betyg C
        //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)

        // }

        // public void sort_buss()
        //{
        //Sortera bussen efter ålder. Tänk på att du inte kan ha tomma positioner "mitt i" vektorn.
        //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
        //Man ska kunna sortera vektorn med bubble sort
        //}

        //int[] passagerare = { 78, 55, 45, 98, 13 };
        //int temp;
        //for (int j = 0; j <= passagerare.Length - 2; j++)
        //{
        //    for (int i = 0; i <= passagerare.Length - 2; i++)
        //    {
        //        if (passagerare[i] > passagerare[i + 1])
        //        {
        //            temp = passagerare[i + 1];
        //            passagerare[i + 1] = passagerare[i];
        //            passagerare[i] = temp;
        //        }
        //    }
        //}
        //Console.WriteLine("Passagerare är nu sorterade från lägsta åldern till högsta:");
        //foreach (int person in passagerare)
        //    Console.Write(person + " ");
        //Console.Read();

        //Metoder för betyget A


        // public void print_sex()
        // {
        //Betyg A
        //Denna metod är nödvändigtvis inte svårare än andra metoder men kräver att man skapar en klass för passagerare.
        //Skriv ut vilka positioner som har manliga respektive kvinnliga passagerare.

        // Googlade förut hur man kunde spara flera olika typer av data i en array: Alternativt använda sig av lists? Här finns bra info: https://stackoverflow.com/questions/47047105/how-to-properly-store-data-in-a-c-sharp-array


        // }
        // public void poke()
        // {
        //Betyg A
        //Vilken passagerare ska vi peta på?
        //Denna metod är valfri om man vill skoja till det lite, men är också bra ur lärosynpunkt.
        //Denna metod ska anropa en passagerares metod för hur de reagerar om man petar på dom (eng: poke)
        //Som ni kan läsa i projektbeskrivningen så får detta beteende baseras på ålder och kön.
        // }

        // public void getting_off()
        // {
        //Betyg A
        //En passagerare kan stiga av
        //Detta gör det svårare vid inmatning av nya passagerare (som sätter sig på första lediga plats)
        //Sortering blir också klurigare
        //Den mest lämpliga lösningen (men kanske inte mest realistisk) är att passagerare bakom den plats..
        //.. som tillhörde den som lämnade bussen, får flytta fram en plats.
        //Då finns aldrig någon tom plats mellan passagerare.
        //   }
        // }



        class Program
        {
            public static void Main(string[] args)
            {
                //Skapar ett objekt av klassen Buss som heter minbuss
                //Denna del av koden kan upplevas väldigt förvirrande. Men i sådana fall är det bara att "skriva av".
                var minbuss = new Buss();
                minbuss.Run();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }
    }
}
