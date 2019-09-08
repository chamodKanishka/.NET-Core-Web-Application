using MyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant Get(int id);
        Resturant Add(Resturant newResturant);

    }
    public class InMemoryResturantData : IResturantData
    {
        static InMemoryResturantData()
        {
            _resturants = new List<Resturant>
            {
                new Resturant{id =1, name ="The house of kube"},
                new Resturant{id=2, name="LJ's and the kat"},
                new Resturant{id=3, name="King's Contrivance"}
            };
        }
        public IEnumerable<Resturant> GetAll()
        {
            return _resturants;
        }

        public Resturant Get(int id)
        {
            return _resturants.FirstOrDefault(r => r.id == id);
        }

        public Resturant Add(Resturant newResturant)
        {
            newResturant.id = _resturants.Max(r => r.id) + 1;
            _resturants.Add(newResturant);

            return newResturant;
        }

        static List<Resturant> _resturants;
    }
}
