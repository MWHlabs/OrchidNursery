using OrchidModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchidModel.Interfaces
{
    public interface IOrchid
    {
        ICollection<OrchidNew> GetAllOrchids();

        OrchidNew GetAllOrchidNewByID(int id);
        void CreateOrchid(OrchidNew orchidObject);
        int UpdateOrchid(int id, OrchidNew orchidObject);
        void DeleteOrchid(int ID);
    }
}
