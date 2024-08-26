using System;

class URI
{

    static void Main(string[] args)
    {

        int x = 1;
        int cont = 0;
        int V_inter = 0;
        int V_Gremio = 0;
        int empate = 0;

        while (x == 1)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inter = int.Parse(vet[0]);
            int gremio = int.Parse(vet[1]);

            cont = cont + 1;
            
            if (inter > gremio)
            {
                V_inter = V_inter + 1;
            }
            if (inter < gremio)
            {
                V_Gremio = V_Gremio + 1;
            }
            if (inter == gremio) 
            { 
                empate = empate + 1;
            }
            
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            x = int.Parse(Console.ReadLine());
           
            while (x != 1 && x != 2) 
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());

            }

        }

    }

}