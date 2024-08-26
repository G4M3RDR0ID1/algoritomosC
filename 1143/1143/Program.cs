using System; 

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int n1 = 1;
        int n2 = 1;
        int n3 = 1;

        for (int i = 0; i < n; i++) 
        {
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            n1 = n1 + 1;
            n2 = (int)Math.Pow(n1, 2);
            n3 = (int)Math.Pow(n1, 3);
        }

    }

}