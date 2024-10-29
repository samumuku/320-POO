using System;
using System.Collections.Generic;



namespace Boat
{
    public interface IBoat
    {
        // Propri�t�s du bateau
        string Name { get; }
        float MaxCargoWeight { get; }
        int MaxSpeed { get; }

        // M�thodes pour le bateau
        void Start();  // D�marrer le bateau
        bool LoadContainer(IContainer container);  // Charger un container
        bool UnloadContainer(IContainer container);  // D�charger un container
    }
}
