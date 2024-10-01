namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Buliding> bulidings = new List<Buliding>();
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();
            List<Rectangle> rectangles = new List<Rectangle>();
            Drone drone = new Drone();
            Buliding buliding = new Buliding();
            Buliding buliding2 = new Buliding();
            Factory factory = new Factory();
            Store store = new Store();
            drone.x = 100;
            drone.y = 100;
            drone.name = "ben";
            fleet.Add(drone);
            bulidings.Add(buliding);
            bulidings.Add(buliding2);
            factorys.Add(factory);
            stores.Add(store);

            buliding.x = 400;
            buliding.y = 100;
            buliding2.y = 70;
            buliding2.x = 410;
            factory.y = 150;
            factory.x = 500;
            store.y = 130;
            store.x = 490;

            Rectangle r1 = new Rectangle(10, 10, 100, 150);
            Rectangle r2 = new Rectangle(30, 100, 150, 100);
            Rectangle r3 = new Rectangle(200, 300, 50, 50);

            r1.IntersectsWith(r2); // true
            r1.IntersectsWith(r3); // false


            Drone drone2 = new Drone();
            drone2.x = 570;
            drone2.y = 100;
            drone2.name = "gonzalo";
            Drone drone3 = new Drone();
            drone3.x = 522;
            drone3.y = 100;
            drone3.name = "ben";
            Drone drone4 = new Drone();
            drone4.x = 250;
            drone4.y = 100;
            drone4.name = "ben";
            Drone drone5 = new Drone();
            drone5.x = 200;
            drone5.y = 100;
            drone5.name = "ben";
            Drone drone6 = new Drone();
            drone6.x = 50;
            drone6.y = 100;
            drone6.name = "ben";
            Drone drone7 = new Drone();
            drone7.x = 83;
            drone7.y = 100;
            drone7.name = "ben";
            Drone drone8 = new Drone();
            drone8.x = 320;
            drone8.y = 100;
            drone8.name = "ben";
            Drone drone9 = new Drone();
            drone9.x = 299;
            drone9.y = 100;
            drone9.name = "ben";
            Drone drone10 = new Drone();
            drone10.x = 10;
            drone10.y = 100;
            drone10.name = "ben";

            fleet.Add(drone2);
            fleet.Add(drone3);
            fleet.Add(drone4);
            fleet.Add(drone5);
            fleet.Add(drone6);
            fleet.Add(drone7);
            fleet.Add(drone8);
            fleet.Add(drone9);
            fleet.Add(drone10);

            try
            {
                if(fleet.Count() >= 10)
                {
                    throw new Exception("La valeur du fleet doit être inférieure à 10");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet,bulidings,factorys,stores,rectangles));


        }
    }
}