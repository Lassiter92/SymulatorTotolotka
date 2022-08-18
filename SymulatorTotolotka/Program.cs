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
                if (i >= 1)
                {
                    // test czy dana liczba została już wylosowana, jeśli tak losuje nową
                    if (wylosowane[i] == wylosowane[i - 1])
                    {
                        wylosowane[i] = rnd.Next(1, 50);
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
                for (int i = 0; i < totek.Length; i++)
                {
                    totek[i] = rnd.Next(1, 50);
                    if (i >= 1)
                    {
                        // test czy dana liczba została już wylosowana, jeśli tak losuje nową
                        if (totek[i] == totek[i - 1])
                        {
                            totek[i] = rnd.Next(1, 50);
                        }
                    }
                }


                for (int i = 0; i < totek.Length; i++)
                {

                    for (int j = 0; j < totek.Length; j++)
                    {
                        if (totek[i] == wylosowane[j])
                        {
                            licznikLiczbZgodnych++;
                            break;
                        }
                        else if (totek[i] != wylosowane[j])
                        {

                            continue;
                        }
                    }

                }
                licznik++;
                Console.WriteLine(licznik);
                if (licznikLiczbZgodnych == 5)
                {
                    test = true;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < totek.Length; i++)
            {
                Console.Write(totek[i] + " ");
               
            }
            Console.WriteLine();
            for (int i = 0; i < totek.Length; i++)
            {
                Console.Write(wylosowane[i] + " ");

            }

        }
    }
}