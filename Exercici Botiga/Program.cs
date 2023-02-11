namespace Exercici_Botiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cantidadesCarro = new int[2];
            string[] nomsProducte = new string[2];
            string[] productesCarro = new string[2];
            double[] dinersCarro = new double[2];
            double[] preusProducte = new double[2];
            int contadorProductes = 0, contadorProductesCarro = 0;
            double diners = 10;
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

                        Cistella(ref nomsProducte, ref preusProducte, ref contadorProductes, ref diners, ref productesCarro, ref dinersCarro, ref cantidadesCarro, ref contadorProductesCarro);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
                Console.WriteLine("═════════════════════════════");
                Console.WriteLine("Vols sortir de la botiga? y/n");
                exit = Console.ReadLine();

            }
        }

        static void Benvingut()
        {
            Console.Clear();
            Console.WriteLine("Benvingut a la nostre botiga, que desitja fer?");
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine("1 - Botiga ");
            Console.WriteLine("2 - Cistella");
            Console.WriteLine("3 - Sortir\n");
        }

        public static void Botiga(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes)
        {

            Console.Clear();
            Console.WriteLine("Ha entrat en la nostre botiga, escolleix l'opció que vulguis:");
            Console.WriteLine("═════════════════════════════════════════════════════════════");
            Console.WriteLine("1 - Afegir un nou producte");
            Console.WriteLine("2 - Ampliar botiga");
            Console.WriteLine("3 - Modificar preu");
            Console.WriteLine("4 - Modificar nom de producte");
            Console.WriteLine("5 - Ordenar per nom");
            Console.WriteLine("6 - Ordenar per preu");
            Console.WriteLine("7 - Mostrar botiga");
            Console.WriteLine("8 - Tornar enrrere\n");

            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (resposta < 1 || resposta > 8)
            {
                resposta = int.Parse(Console.ReadLine());
            }

            switch (resposta)
            {
                case 1:
                    string resposta1 = "";

                    Console.WriteLine("\nProductes en la botiga -> " + contadorProductes);
                    Console.WriteLine("Capacitat del magatzem -> " + nomsProducte.Length);
                    Console.WriteLine();
                    if (contadorProductes == nomsProducte.Length)
                    {
                        //en teoria es porque ya esta la tienda llena
                        Console.WriteLine("No tenim espai per més productes, vols ampliar l'espai del magatzem? y/n\n");
                        while (resposta1 != "y" && resposta1 != "n")
                        {
                            resposta1 = Console.ReadLine().ToLower();
                        }
                        if (resposta1 == "y")
                        {
                            Console.WriteLine();
                            AmpliarBotiga(ref nomsProducte, ref preusProducte, ref contadorProductes);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Introdueix el nom del producte:");
                        string nomProducte = Console.ReadLine();
                        Console.WriteLine("\nIntrodueix el preu del producte:");
                        double preuProducte = Double.Parse(Console.ReadLine());
                        //productes = AfegirProducte(nomProducte, preuProducte);
                        nomsProducte[contadorProductes] = nomProducte;
                        preusProducte[contadorProductes] = preuProducte;
                        contadorProductes++;
                        Console.WriteLine("\nProducte creat");
                        Thread.Sleep(1500);
                    }

                    break;
                case 2:
                    AmpliarBotiga(ref nomsProducte, ref preusProducte, ref contadorProductes);
                    break;
                case 3:
                    ModificarPreu(nomsProducte, ref preusProducte, contadorProductes);
                    break;
                case 4:
                    ModificarNomDeProducte(ref nomsProducte, preusProducte, contadorProductes);
                    break;
                case 5:
                    OrdenarPerNom(ref nomsProducte,ref preusProducte, ref contadorProductes);
                    break;
                case 6:
                    OrdenarPerPreu(ref nomsProducte,ref preusProducte, ref contadorProductes);
                    break;
                case 7:
                    MostrarBotiga(nomsProducte, preusProducte);
                    break;
                case 8:
                    Benvingut();
                    break;
            }
        }

        public static void Cistella(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes, ref double diners, ref string[] productesCarro, ref double[] dinersCarro, ref int[] cantidadesCarro, ref int contadorProductesCarro)
        {

            Console.Clear();
            Console.WriteLine("Ha entrat a la seva cistella, escull l'opció que vulguis:");
            Console.WriteLine("═════════════════════════════════════════════════════════");
            Console.WriteLine("1 - Comprar producte");
            Console.WriteLine("2 - Veure cistella");
            Console.WriteLine("3 - Ordenar cistella");
            Console.WriteLine("4 - Mostrar tiquet");
            Console.WriteLine("5 - Tornar enrere\n");

            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (resposta < 1 || resposta > 5)
            {
                resposta = int.Parse(Console.ReadLine());
            }

            switch (resposta)
            {
                case 1:
                    ComprarProducte(ref nomsProducte, ref preusProducte, ref contadorProductes, ref diners, ref productesCarro, ref dinersCarro, ref cantidadesCarro, ref contadorProductesCarro);
                    break;

                case 2:
                    MostrarCistella(nomsProducte, preusProducte, contadorProductes, cantidadesCarro);
                    break;
                case 3:
                    OrdenarCistella(ref nomsProducte, ref preusProducte, ref contadorProductes);
                    break;
                case 4:
                    MostrarTiquet(nomsProducte, preusProducte, contadorProductes, cantidadesCarro);
                    break;
            }
        }

        public static void ComprarProducte(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes, ref double diners, ref string[] productesCarro, ref double[] dinersCarro, ref int[] cantidadesCarro, ref int contadorProductesCarro)
        {
            string resposta = "";
            Console.Clear();
            MostrarBotiga(nomsProducte, preusProducte);
            Console.WriteLine("══════════════════════════════════");
            Console.WriteLine("Has entrat en la botiga\n");
            Console.WriteLine($"\nA la teva caixa hi ha: {diners} euros\n");

            Console.WriteLine("Introdueix el nom del producte que vols comprar:");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("\nIntrodueix la quantitat de productes que vols comprar:");
            int cantidad = int.Parse(Console.ReadLine());

            if (contadorProductesCarro == productesCarro.Length)
            {
                //en teoria es porque ya esta la tienda llena
                Console.WriteLine("No tenim espai per ficar més productes al carro, vols ampliar l'espai del carretó? y/n\n");
                while (resposta != "y" && resposta != "n")
                {
                    resposta = Console.ReadLine().ToLower();
                }
                if (resposta == "y")
                {
                    Console.WriteLine();
                    AmpliarBotiga(ref nomsProducte, ref preusProducte, ref contadorProductesCarro);
                }
            }
            else
            {
                for (int i = 0; i < nomsProducte.Length; i++)
                {
                    if (nombreProducto == nomsProducte[i])
                    {
                        if (diners >= preusProducte[i] * cantidad)
                        {
                            diners -= preusProducte[i] * cantidad;
                            Console.WriteLine("\nProducte possat a la caixa");
                            contadorProductesCarro++;
                            productesCarro[i] = nombreProducto;
                            dinersCarro[i] = (preusProducte[i] * cantidad);
                            cantidadesCarro[i] = cantidad;
                            contadorProductes++;
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("\nNo tens suficients diners per comprar aquest producte");
                            Console.WriteLine("\nVos afegir diners als teus estalvis? (S/N)");
                            string opcion = Console.ReadLine();
                            if (opcion.ToUpper() == "S")
                            {
                                Console.WriteLine("\nIntrodueix la quantitat de diners que vols afegi-hi:");
                                double dineroAAgregar = double.Parse(Console.ReadLine());
                                diners += dineroAAgregar;
                                ComprarProducte(ref nomsProducte, ref preusProducte, ref contadorProductes, ref diners, ref productesCarro, ref dinersCarro, ref cantidadesCarro, ref contadorProductesCarro);
                            }
                            else
                            {
                                Console.WriteLine("\nNo s'han afegit diners a la teva caixa");
                                Console.WriteLine("\nTorna a la botiga quan tinguis més diners");
                            }
                        }
                    }
                }
                Console.WriteLine("\nProducte no trobat a la botiga");
                Console.WriteLine("\nTorna a la botiga i introdueix un producte vàlid");
            }
        }

        public static void MostrarCistella(string[] nomsProducte, double[] preusProducte, int contadorProductes, int[] cantidadesCarro)
        {

            if (contadorProductes == 0)
            {
                for (int i = 0; i < cantidadesCarro.Length; i++)
                {
                    if (cantidadesCarro[0] == 0)
                    {
                        Console.WriteLine("La cistella està buida.");
                        Thread.Sleep(3000);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Productes en la cistella:");
                for (int i = 0; i < cantidadesCarro.Length; i++)
                {
                    if (cantidadesCarro[i] != 0)
                    {
                        Console.WriteLine(nomsProducte[i] + " - Preu: " + preusProducte[i] + " euros\t\t-->\t ║ Quantitat al carro: " + cantidadesCarro[i]);
                        Thread.Sleep(300);
                    }
                }
                Thread.Sleep(4000);
            }

        }

        public static void OrdenarCistella(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes)
        {
            Console.Clear();
            for (int i = 0; i < contadorProductes; i++)
            {
                for (int j = i + 1; j < contadorProductes; j++)
                {
                    if (preusProducte[i] > preusProducte[j])
                    {
                        double temp = preusProducte[i];
                        preusProducte[i] = preusProducte[j];
                        preusProducte[j] = temp;

                        string tempNom = nomsProducte[i];
                        nomsProducte[i] = nomsProducte[j];
                        nomsProducte[j] = tempNom;
                    }
                }
            }
            Console.WriteLine("\nCistella ordenada!");
            Thread.Sleep(2000);
        }

        public static void MostrarTiquet(string[] nomsProducte, double[] preusProducte, int contadorProductes, int[] cantidadesCarro)
        {

            if (contadorProductes == 0)
            {
                for (int i = 0; i < cantidadesCarro.Length; i++)
                {
                    if (cantidadesCarro[0] == 0)
                    {
                        Console.WriteLine("La cistella està vuída.");
                        Thread.Sleep(3000);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Productes en la cistella:");
                for (int i = 0; i < cantidadesCarro.Length; i++)
                {
                    if (cantidadesCarro[i] != 0)
                    {
                        Console.WriteLine(nomsProducte[i] + " - Preu: " + preusProducte[i] + " euros\t\t-->\t ║ Quantitat al carro: " + cantidadesCarro[i]);
                        Thread.Sleep(300);
                    }
                }
                Console.WriteLine("                                         ║\t\tTOTAL: " + CalcularPrecioTotal(ref cantidadesCarro, ref preusProducte));
                Thread.Sleep(4000);
            }

        }

        public static double CalcularPrecioTotal(ref int[] cantidadesCarro, ref double[] preusProducte)
        {
            double precioTotal = 0;
            for (int i = 0; i < cantidadesCarro.Length; i++)
            {
                precioTotal += cantidadesCarro[i] * preusProducte[i];
            }
            return precioTotal;
        }

        static void AmpliarBotiga(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes)
        {
            Console.WriteLine("\nIntroduce el espacio total de productos que deseas: ");
            int cantidad = int.Parse(Console.ReadLine());
            if (cantidad > contadorProductes)
            {
                string[] nomsProducteNuevo = new string[cantidad];
                double[] preusProducteNuevo = new double[cantidad];

                for (int i = 0; i < contadorProductes; i++)
                {
                    nomsProducteNuevo[i] = nomsProducte[i];
                    preusProducteNuevo[i] = preusProducte[i];
                }
                nomsProducte = nomsProducteNuevo;
                preusProducte = preusProducteNuevo;

                Console.WriteLine("\nTamany modificat, tamany nou: " + cantidad + " productes actuals: " + contadorProductes);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("No se puede hacer la tienda mas pequeña o igual");
                Console.ReadLine();
            }
        }

        static void ModificarPreu(string[] nomsProducte, ref double[] preusProducte, int contadorProductes)
        {
            Console.WriteLine("Introduce el nombre del producto que deseas modificar el precio: ");
            string nomProducte = Console.ReadLine();
            int posicionPrecio = -1;

            for (int i = 0; i < contadorProductes; i++)
            {
                if (nomProducte == nomsProducte[i])
                {
                    posicionPrecio = i;
                }
            }

            if (posicionPrecio != -1)
            {
                Console.WriteLine("Introduce el nuevo precio: ");
                double nouPreu = double.Parse(Console.ReadLine());

                preusProducte[posicionPrecio] = nouPreu;
                //he encontrado el producto
                Console.WriteLine(nouPreu);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("No existe un producto con ese nombre");
                Console.ReadLine();
            }
        }

        public static void ModificarNomDeProducte(ref string[] nomsProducte, double[] preusProducte, int contadorProductes)
        {
            Console.WriteLine("Introduce el nombre del producto que deseas modificar su nombre: ");
            string nomProducte = Console.ReadLine();
            int posicionNom = -1;

            for (int i = 0; i < contadorProductes; i++)
            {
                if (nomProducte == nomsProducte[i])
                {
                    posicionNom = i;
                }
            }

            if (posicionNom != -1)
            {
                Console.WriteLine("Introdueix el nou nom: ");
                string nouNom = Console.ReadLine();

                nomsProducte[posicionNom] = nouNom;
                //he trobat el producte
                Console.WriteLine(nouNom);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("No existe un producto con ese nombre");
                Console.ReadLine();
            }
        }

        public static void OrdenarPerNom(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes)
        {

            string aux;
            double aux2;
            for (int i = 1; i <= contadorProductes; i++)
            {
                for (int j = 0; j < contadorProductes - i; j++)
                {
                    if (nomsProducte[j].CompareTo(nomsProducte[j + 1]) > 0)
                    {
                        aux = nomsProducte[j];
                        aux2 = preusProducte[j];
                        preusProducte[j] = preusProducte[j + 1];
                        nomsProducte[j] = nomsProducte[j + 1];
                        nomsProducte[j + 1] = aux;
                        preusProducte[j + 1] = aux2;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Nom del producte \tPreu");
            Console.WriteLine("--------------------------------------");


            for (int i = 0; i < nomsProducte.Length; i++)
            {
                Console.WriteLine("{0}\t\t\t{1}", preusProducte[i], nomsProducte[i]);
            }
            Thread.Sleep(10000);

        }


        public static void OrdenarPerPreu(ref string[] nomsProducte, ref double[] preusProducte, ref int contadorProductes)
        {

            int pmenor;
            for (int volta = 0; volta < contadorProductes - 1; volta++)
            {
                pmenor = volta;
                for (int i = volta + 1; i < contadorProductes; i++)
                {
                    if (preusProducte[pmenor] > preusProducte[i])
                        pmenor = i;
                    if (pmenor != volta)
                    {
                        double aux = preusProducte[pmenor];
                        string aux2 = nomsProducte[pmenor];
                        preusProducte[pmenor] = preusProducte[volta];
                        nomsProducte[pmenor] = nomsProducte[volta];
                        preusProducte[volta] = aux;
                        nomsProducte[volta] = aux2;
                    }
                }

            }


            Console.Clear();
            Console.WriteLine("Nom del producte\tPreu");
            Console.WriteLine("--------------------------------------");


            for (int i = 0; i < nomsProducte.Length; i++)
            {
                Console.WriteLine("{0}\t\t\t{1}", preusProducte[i], nomsProducte[i]);
            }
            Thread.Sleep(10000);

        }




        public static void MostrarBotiga(string[] nomsProducte, double[] preusProducte)
        {
            Console.Clear();
            Console.WriteLine("Nombre del producto\tPrecio");
            Console.WriteLine("═════════════════════════════════════");


            for (int i = 0; i < nomsProducte.Length; i++)
            {
                if (preusProducte[i] != 0)
                {
                    Console.WriteLine($"{nomsProducte[i]}\t\t\t{preusProducte[i]}");
                }
            }
            Thread.Sleep(2600);
        }

    }
}