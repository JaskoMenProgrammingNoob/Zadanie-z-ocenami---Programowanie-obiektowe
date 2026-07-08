class Klasa
{

    string[] uczniowie = new string[] { "Zibi", "Wojtek", "Gienia" };
    string[] przedmioty = new string[] { "Matematyka", "Polski", "Fizyka", "Chemia" };
    double[,] oceny = new double[3, 4];
    double[] srednia_ucznia = new double[3]; // tu bede przechowywal srednie uczniow 
    double srednia_ogolna = 0;
    double suma_wszystkich = 0;
    string[] ranking_uczniow = new string[3];
    double[] ranking_ocen = new double[3];
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
        //bool swapped;
        //string[] ranking_uczniow = new string[3];
        //double[] ranking_ocen = new double[3];
        for (int i = 0; i < 3; i++)
        {
            ranking_uczniow[i] = uczniowie[i];
            ranking_ocen[i] = srednia_ucznia[i];
        }
        
         for(int i = 0; i < 3 - 1; i++) //bombelkowe przekopiowane i zamienione z mojego githuba z poprzednieog zadania
        {
            //swapped = false;
            for (int j = 0; j < 3 - 1 - i; j++)
            {
                if (ranking_ocen[j] < ranking_ocen[j + 1])
                {
                    
                    double temp = ranking_ocen[j];
                    ranking_ocen[j] = ranking_ocen[j +1];
                    ranking_ocen[j + 1] = temp;

                    string temp2 = ranking_uczniow[j];
                    ranking_uczniow[j] = ranking_uczniow[j + 1];
                    ranking_uczniow[j + 1] = temp2;

                    //swapped = true;
                }
            } 
        } 
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

        Console.Write($"{"Średnia", -8}"); // nie rozumiem dlaczego nie chce sie to ustawic w jednej lini pod sekcja srednia
        Console.WriteLine();
        
        for (int i = 0; i < 3; i++) // wyswietlam ilosc uczniow przy pomocy tablicy uczniowie, uczniow jest 3 wiec musze dac i < 3, zrezygnowalem z dawania formatu {uczniowie[i], 4} poniewaz brzydko wyswietlal
        {
            Console.Write($"{uczniowie[i], -8}");
            
            for(int j = 0; j < 4; j++) // petla zagniedzona j wyswietla oceny, sa 4 oceny wiec j musi byc mniejsze od 4 
            {
                Console.Write($"{oceny[i, j], -8:F2}");
                
            }
            //Console.WriteLine();



            
            Console.WriteLine($"{srednia_ucznia[i],8}");

            
        }
        Console.WriteLine("ŚREDNIA OGÓLNA");
        Console.WriteLine($"{srednia_ogolna:F2}");
        Console.WriteLine();

        Console.WriteLine("RANKING");
        
        Console.WriteLine();
           
            for (int j = 0; j < 3; j++)
            {
            Console.WriteLine($"{j+1} : {ranking_uczniow[j]} " + $"- {ranking_ocen[j],-8:F2}");
            //Console.WriteLine($"{j + 1} : {uczniowie[j]} - {srednia_ucznia[j],-8:F2}");

            }

        
        
        /* for (int j = 0; j < 3; j++)
            {

                Console.WriteLine($"{srednia_ucznia[j],-8}");

            } */
        
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