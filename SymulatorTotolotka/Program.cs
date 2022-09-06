namespace SymulatorTotolotka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wylosowane = new int[6];
            int[] totek = new int[6];
            bool test = false;
            long licznik = 0;
            Random rnd = new Random();

            // losowanie liczby
            for (int i = 0; i < wylosowane.Length; i++)
            {

                // zapisanie losowanych liczb do tablicy "wylosowane"
                wylosowane[i] = rnd.Next(1, 50);

                // sprawdzenie- zeby liczba sie nie powtarzała
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {

                        if (wylosowane[i] == wylosowane[j])
                        {
                            wylosowane[i] = rnd.Next(1, 50);
                            j = -1;
                        }

                    }
                }

                Console.Write(wylosowane[i] + " ");

            }

            Console.WriteLine();
            int licznikLiczbZgodnych = 0;

            // kupony z totka 
            while (test == false)
            {
                licznikLiczbZgodnych = 0;

                //losowanie liczb do kuponu
                for (int i = 0; i < totek.Length; i++)
                {
                    totek[i] = rnd.Next(1, 50);
                    if (i >= 1)
                    {
                        for (int j = 0; j < i; j++)
                        {

                            if (totek[i] == totek[j])
                            {
                                totek[i] = rnd.Next(1, 50);
                                j = -1;
                            }

                        }
                    }
                }
                // sprawdzenie czy kupon jest taki sam jak wylosowana
                for (int i = 0; i < wylosowane.Length; i++)
                {
                    for (int j = 0; j < wylosowane.Length; j++)
                    {
                        if (wylosowane[i] == totek[j])
                        {
                            licznikLiczbZgodnych++;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    if (licznikLiczbZgodnych == 0)
                    {
                        licznik++;
                        break;
                    }
                    
                }
                if (licznikLiczbZgodnych == 6)
                {
                    test = true;
                    for(int i = 0; i < totek.Length; i++)
                    {
                        Console.Write($"{totek[i]} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Liczba prob {licznik}");
                }
            }
        }
    }
}