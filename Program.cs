namespace Set1Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            string numar = Console.ReadLine();

            if(AreDoarDouaCifreDistincte(numar))
            {
                Console.WriteLine("Numarul este format doar din 2 cifre distincte");
            }
            else
            {
                Console.WriteLine("Numarul NU este format doar din 2 cifre distincte");
            }

        }

        static bool AreDoarDouaCifreDistincte(string numar)
        {
            char? cifraUnu = null;
            char? cifraDoi = null;

            foreach(char cifra in numar)
            {
                if (cifraUnu == null)
                {
                    cifraUnu = cifra;
                }
                else if ( cifra != cifraUnu &&  cifraDoi == null)
                {
                    cifraDoi = cifra;
                }
                else if( cifra != cifraUnu && cifra != cifraDoi)
                {
                    return false;
                }
            }
            return cifraUnu != null && cifraDoi != null;
        }
    }
}
