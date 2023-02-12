using Microsoft.EntityFrameworkCore;
using VoitureApi.Model;
using VoitureAPi2.Model;

namespace VoitureAPi2.Services
{
    public class CategorieService : ICategorie
    {
        MyDatabaseContext myDatabase;
        public CategorieService(MyDatabaseContext myDatabase)
        {
            this.myDatabase = myDatabase;
        }

        //Modification return result
        public async Task<Categorie> addUpdateCategorie(Categorie categorie)
        {
            if (categorie == null)
                throw new Exception("Categorie null");
            if (categorie.Id == 0)
                  myDatabase.categories.Add(categorie);
            else
                myDatabase.categories.Update(categorie);
            await myDatabase.SaveChangesAsync();
            return categorie;
        }

        public async Task<IEnumerable<Categorie>> getAllCategories()
        {
           return await myDatabase.categories.ToListAsync();
        }

        public async Task<Categorie> getCategorie(int id)
        {
            Categorie c=await myDatabase.categories.FirstOrDefaultAsync(x=>x.Id == id);
            if (c == null)
                throw new Exception("Not found");
            return c;

        }

        public void removeCategorie(Categorie categorie)
        {
            
            myDatabase.categories.Remove(categorie);
            myDatabase.SaveChanges();
        }

       
    }
}
