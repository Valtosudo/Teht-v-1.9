namespace Koodi;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hei, tervetuloa kirjastoon !");

        while (true)
        {
            Console.WriteLine("Jos haluat lisätä kirjoja laita 1");
            Console.WriteLine("jos haluta poistaa kirjoja laita 2");
            Console.WriteLine("jos haluat nähdä kaikki kirjat laita 3");
            Console.WriteLine("jos haluta nähdä kirjat gendren mukaan laita 4");
            Console.WriteLine("jos haluat löytää kirjan kirjoittajan/kirjan nimellä laita 5");
            Console.WriteLine("jos haluat lopettaa ohjelman laita 6");

            int vastaus = Convert.ToInt32(Console.ReadLine());
            
            if (vastaus == 1)
            {
                Kirja.LisaaKirja();
            }
            else if (vastaus == 2)
            {
                Kirja.PoistaKirja();
            }
            else if (vastaus == 3)
            {
                Kirja.NaytaKaikkiKirjat();
            }
            else if (vastaus == 4)
            {
                Kirja.NaytaKirjatGendrenMukaan();
            }
            else if (vastaus == 5)
            {
                Kirja.LoydaKirja();
            }
            else if (vastaus == 6)
            {
                Console.WriteLine("Kiitos, että käytit kirjastoa!");
                break;
            }
            else
            {
                Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
            }

        }


    }
}
