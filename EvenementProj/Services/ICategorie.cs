using VoitureApi.Model;

namespace VoitureAPi2.Services
{
    public interface ICategorie
    {
        Task<Categorie> addUpdateCategorie(Categorie categorie);
        void removeCategorie(Categorie categorie );
        Task<Categorie> getCategorie(int id);
        Task<IEnumerable<Categorie>> getAllCategories();

    }
}
