using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPets.Utils
{
    interface IRepository<U, V, T, D> : IDisposable where T: class where D: class where U: class where V: class
         
    {
        IEnumerable<T> LoadUsersPetsInto(int id);
        IEnumerable<T> PetInfo(string name);
        IEnumerable<U> GetUsersList();
        IEnumerable<V> GetKindsList();

        U GetUser(int id);
        U GetUser(string login, string password);
        T GetPet(int id);
        V GetKind(int id);

        bool CreateNewUser(U item);
        bool CreateNewPet(string name, string kind, string weight, string age, bool gender, bool type, bool photo);

        void AddProgress(D item);
        void DeletePet(string name);
    }
}
