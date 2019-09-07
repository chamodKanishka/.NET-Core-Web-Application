using MyApp.Entities;
using MyApp.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();

    }
    public class InMemoryResturantData : IResturantData
    {
        public InMemoryResturantData()
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

        List<Resturant> _resturants;
    }
}
