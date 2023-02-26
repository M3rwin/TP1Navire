using System;

namespace TP1Navire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestEstPresent();




            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public static void Affiche(Navire navire)
        {
            string message = $@"Identification   : {navire.Imo}
Nom              : {navire.Nom}
Type de frêt     : {navire.LibelleFret}
Quantité de frêt : {navire.QteFretMaxi}
_______________________________________
";
            Console.WriteLine(message);
        }


        public static void TestInstanciation()
        {
            //Déclaration et instanciation premier navire (utilisation premier constructeur)
            Navire test = new Navire("IMO9838345", "WONDER OF THE SEAS");
            //Déclaration et instanciation deuxième navire (utilisation deuxième constructeur)
            Navire test2 = new Navire("IMO9795737", "ODYSSEY OF THE SEAS", "bois", 100);
            //Affichage des résultats
            Affiche(test);
            Affiche(test2);
        }


        public static void TestEnregistrerArrivee()
        {
            Navire test1 = new Navire("IMO1564879", "SS Test1");
            Navire test2 = new Navire("IMO1564880", "SS Test2");
            Navire test3 = new Navire("IMO1564881", "SS Test3");
            Navire test4 = new Navire("IMO1564882", "SS Test4");
            Navire test5 = new Navire("IMO1564881", "SS Test5");

            Port monPort = new Port("Toulon");

            monPort.EnregistrerArrivee(test2);
            monPort.EnregistrerArrivee(test1);
            monPort.EnregistrerArrivee(test3);
            monPort.EnregistrerArrivee(test4);
            monPort.EnregistrerArrivee(test5);

            Console.WriteLine("Tous les navires ont été enregistrés");
        }

        public static void TestEnregistrerDepart()
        {
            Port port = new Port("Toulon");
            Navire test1 = new Navire("IMO1564879", "SS Test1");
            Navire test2 = new Navire("IMO1564880", "SS Test2");
            Navire test3 = new Navire("IMO1564881", "SS Test3");
            Navire test4 = new Navire("IMO1564882", "SS Test4");

            port.EnregistrerArrivee(test1);
            port.EnregistrerArrivee(test2);
            port.EnregistrerArrivee(test3);
            port.EnregistrerArrivee(test4);

            port.EnregistrerDepart("IMO1564880");
            Console.WriteLine("Depart de IMO1564880 enregistré");
            port.EnregistrerDepart("IMO1564883");
            Console.WriteLine("Depart de IMO1564883 enregistré");

            Console.WriteLine("Fin du Programme");
        }

        public static void TestRecupPos()
        {
            new Port("Toulon").TestRecupPosition();
        }

        public static void TestRecupPosV2()
        {
            new Port("Toulon").TestRecupPositionV2();
        }

        public static void TestEstPresent()
        {
            Port port = new Port("Toulon");
            Navire test1 = new Navire("IMO1564879", "SS Test1");
            Navire test2 = new Navire("IMO1564880", "SS Test2");
            Navire test3 = new Navire("IMO1564881", "SS Test3");
            Navire test4 = new Navire("IMO1564882", "SS Test4");

            port.EnregistrerArrivee(test1);
            port.EnregistrerArrivee(test2);
            port.EnregistrerArrivee(test3);
            port.EnregistrerArrivee(test4);

            Console.WriteLine(port.EstPresent("IMO1564880"));
            Console.WriteLine(port.EstPresent("IMO0000000"));

            Console.WriteLine("Fin du Programme");
        }
    }
}