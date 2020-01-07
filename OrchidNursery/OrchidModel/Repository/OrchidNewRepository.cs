using OrchidModel.Interfaces;
using OrchidModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrchidModel.Repository
{

    public class OrchidNewRepository : IOrchid
    {
        MyDbContext _myDbContext;

        public OrchidNewRepository(MyDbContext dbContext)
        {
            _myDbContext = dbContext;
        }

        public void CreateOrchid(OrchidNew orchidObject) //enter a new data packet
        {
            _myDbContext.OrchidNews.Add(orchidObject);
            _myDbContext.SaveChanges();
        }

        public void DeleteOrchid(int ID) //Deletetion of a data entered.
        {
            var orchids = _myDbContext.OrchidNews.Where(c => c.orchidID == ID).FirstOrDefault();
            _myDbContext.OrchidNews.Remove(orchids);
            _myDbContext.SaveChanges();
        }

        public OrchidNew GetAllOrchidNewByID(int ID)
        {
            var orchids = _myDbContext.OrchidNews.Where(c => c.orchidID == ID).SingleOrDefault();
            return orchids;
        }

        public ICollection<OrchidNew> GetAllOrchids()
        {
            var orchids = _myDbContext.OrchidNews.ToList();
            return orchids;
        }

        

        public int UpdateOrchid(int ID, OrchidNew orchidObject)
        {
            var orchids = _myDbContext.OrchidNews.Where(c => c.orchidID == ID).SingleOrDefault();

            if (orchids == null)
            {
                return 0;
            }
            else
            {
                orchids.orchidName = orchidObject.orchidName;
                orchids.category = orchidObject.category;
                orchids.size = orchidObject.size;
                orchids.price = orchidObject.price;
                orchids.quanity = orchidObject.quanity;
                orchids.manuDate = orchidObject.manuDate;
                orchids.expTime = orchidObject.expTime;
                _myDbContext.SaveChanges();
                return 1; //If Success Return One.

            }
        }

     

        
    }
}
