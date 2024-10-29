using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Boat : IBoat
    {
        private string _name;
        private float _maxCargoWeight;
        private int _maxSpeed;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float MaxCargoWeight
        {
            get { return _maxCargoWeight; }
            set { _maxCargoWeight = value; }
        }
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public Boat(string name, int maxCargoWeight, int maxSpeed)
        {
            _name = name;
            _maxCargoWeight = maxCargoWeight;
            _maxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine("Boat started");

        }

        public bool LoadContainer(IContainer container)
        {
            if (container.Weight > _maxCargoWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UnloadContainer(IContainer container)
        {
            if (container.Weight > _maxCargoWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}