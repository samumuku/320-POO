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

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Buliding> bulidings = new List<Buliding>();
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();
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



            Drone drone2 = new Drone();
            Drone drone3 = new Drone();
            Drone drone4 = new Drone();
            Drone drone5 = new Drone();
            Drone drone6 = new Drone();
            Drone drone7 = new Drone();
            Drone drone8 = new Drone();
            Drone drone9 = new Drone();
            Drone drone10 = new Drone();

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
                    throw new Exception("La valeur du fleet doit �tre inf�rieure � 10");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // D�marrage
            Application.Run(new AirSpace(fleet,bulidings,factorys,stores));
        }
    }
}