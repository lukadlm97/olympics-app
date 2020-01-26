using SportApplicationData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportApplicationData
{
    public interface ISport
    {
        IEnumerable<Sport> GetAll();
        Sport GetById(int id);
        void AddSport(Sport newSport);
        string GetName(int id);
        bool GetIndividual(int id);
        Category GetCategory(int id);
    }
}
