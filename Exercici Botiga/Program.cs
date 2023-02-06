namespace Exercici_Botiga
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] nomsProducte = new string[2];
            double[] preusProducte = new double[2];
            int contadorProductes = 0;

            string exit = "";
            int resposta;
            while (exit != "y")
            {
                Benvingut();
                resposta = int.Parse(Console.ReadLine());

                while (resposta < 1 || resposta > 3)
                {
                    resposta = int.Parse(Console.ReadLine());
                }

                switch (resposta)
                {
                    case 1:
                        Botiga(ref nomsProducte, ref preusProducte, ref contadorProductes);
                        break;
                    case 2:
                        //TODO: pasarle los arrays y el contador por referencia
                        Cistella();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
                Console.WriteLine("_____________________________");
                Console.WriteLine("Vols sortir de la botiga? y/n");
                exit = Console.ReadLine();

            }

        }
    }
}