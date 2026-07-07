class Klasa
{

    string[] uczniowie = new string[] { "Zibi", "Wojtek", "Gienia" };
    string[] przedmioty = new string[] { "Matematyka", "Polski", "Fizyka", "Chemia" };
    double[,] oceny = new double[3, 4];
    double[] srednia_ucznia = new double[3]; // tu bede przechowywal srednie uczniow 
    double srednia_ogolna = 0;
    double suma_wszystkich = 0;

    public void czytaj_dane()
    {
        Random losowa = new Random();
       
        for (int i = 0; i < 3; i++) // (ilość uczniów) 
        {
            for (int j = 0; j < 4; j++) // (ilość przedmiotów) 
            {
                oceny[i, j] = losowa.Next(1, 7);
                
            }
        }
    }
    public void przetworz_dane()
    {
        for ( int i = 0; i < 3; i++) // dla kazdego ucznia 
        {
            double suma = 0;
            
            for ( int j = 0; j < 4; j++) // dla kazdej oceny z kazdego przedmiotu
            {
                suma += oceny[i, j];
                suma_wszystkich += oceny[i, j];
                
            }
            srednia_ucznia[i] = suma / 4;
            
        }
        srednia_ogolna = suma_wszystkich / 12;
    }


    public void wyswietl_dane()
    {
        Console.WriteLine("DZIENNIK UCZNIA");
        Console.WriteLine();


        Console.Write($"{"Uczeń "}");
        foreach (string przedmiot in przedmioty)
        {
            Console.Write($"{przedmiot, -8}");
        }

        Console.Write($"{"Średnia", -8}");
        Console.WriteLine();
        
        for (int i = 0; i < 3; i++) // wyswietlam ilosc uczniow przy pomocy tablicy uczniowie, uczniow jest 3 wiec musze dac i < 3, zrezygnowalem z dawania formatu {uczniowie[i], 4} poniewaz brzydko wyswietlal
        {
            Console.Write($"{uczniowie[i], -8}");
            
            for(int j = 0; j < 4; j++) // petla zagniedzona j wyswietla oceny, sa 4 oceny wiec j musi byc mniejsze od 4 
            {
                Console.Write($"{oceny[i, j], -8:F2}");
                
            }
            Console.WriteLine();



            
            Console.WriteLine($"{srednia_ucznia[i],8}");

            //Console.WriteLine();
        }
        Console.WriteLine("ŚREDNIA OGÓLNA");
        Console.WriteLine($"{srednia_ogolna:F2}");

        /* foreach (double ocena in oceny)
        {
            Console.Write($"{ocena,4}");
        }
         Console.WriteLine(); 
        foreach (string uczen in uczniowie)
        {
            Console.WriteLine($"{uczen,8}");
        }
        foreach (double srednia in srednia_ucznia)
        {
            Console.Write($"{srednia,8}");
        }
        Console.WriteLine(); */


    }











    static void Main(string[] args)
    {
        Klasa klasa = new Klasa();
        klasa.czytaj_dane();
        klasa.przetworz_dane();
        klasa.wyswietl_dane();


    }



}