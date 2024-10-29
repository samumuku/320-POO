
namespace Boat
{
    public interface IContainer
    {
        // Propri�t�s du container
        int Id { get; }
        float Weight { get; }
        bool IsRefrigerated { get; }
        List<string> Merchandise { get; }
        string Color { get; }

        // M�thodes pour le container
        void ViewContent();  // Voir le contenu du container
        void AddMerchandise(string item);  // Ajouter un �l�ment dans le container
    }
}