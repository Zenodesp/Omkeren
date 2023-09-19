internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HET GROOT WOORDOMKEERPROGRAMMA");
        Console.WriteLine("Copyright (who cares), all rights reserved");
        Console.WriteLine("Selecteer uw methode!");
        Console.WriteLine("1. For");
        Console.WriteLine("2. While");
        Console.WriteLine("3. Do-While");
        Console.WriteLine("4. Recursie");
        char keuze = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Geef uw woord in als volgende:");
        string woord = Console.ReadLine();
        string reverse = null;
        int length = woord.Length - 1;

        int i = 1; 
        switch (keuze)
        {
            case '1':
                for (int index = woord.Length - 1; index >= 0; index--)
                {
                    reverse += woord[index];
                }
                break;

            case '2':
                while(length >= 0)
                {
                    reverse = reverse + woord[length];  
                    length--;
                }
                break;

            case '3':

                do { 
                    reverse = reverse + woord[length];
                    length--;
                } while(length >= 0);
                break;

            case '4':
                reverse = MakeReverse(woord);
                break;

            default:
                break;
        }

        Console.WriteLine("Origineel woord: " + woord + ". Omgekeerd: " + reverse);


    }

    public static string MakeReverse(string str)
    {
        if (str.Length > 0)
            return str[str.Length - 1] + MakeReverse(str.Substring(0, str.Length - 1));
        else
            return str;
    }
}