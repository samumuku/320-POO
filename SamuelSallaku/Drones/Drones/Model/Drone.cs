namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique

    public enum EvacuationState
    {
        Free,           // No limits applied
        Evacuating,     // Limits known, moving out of the zone
        Evacuated       // Limits known, out of the zone
    }

    public interface IExpellable
    {
        // Signal the limits of the no-fly zone 
        // Return true if the drone is already outside the zone
        public bool Evacuate(Rectangle zone);

        // Terminate the no-fly zone
        public void FreeFlight();

        // Interrogate the drone
        public EvacuationState GetEvacuationState();
    }


    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        public int charge = 1000;                     // La charge actuelle de la batterie
        public string name;                           // Un nom
        public int x ;                                // Position en X depuis la gauche de l'espace aérien
        public int y;                                 // Position en Y depuis le haut de l'espace aérien


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

        public bool Evacuate(Rectangle zone)
        {
            return true;
        }

        public void FreeFlight()
        {
            
        }

        public EvacuationState GetEvacuationState()
        {
           return EvacuationState.Free;
        }

        /*public void FreeFlight()
        { 
            Console.WriteLine("e");
        }
        public bool Evacuate(Rectangle zone)
        { 
            return true;
        }

        public void GetEvacuationState()
        {  
            Console.WriteLine("e");
        }

        EvacuationState IExpellable.GetEvacuationState()
        {
            return EvacuationState.Free;
        }*/
    }
    public partial class Buliding
    {
        public int charge = 1000;
        public int x;
        public int y;
        public int width;
        public int height;
        public string color;
    }
}
