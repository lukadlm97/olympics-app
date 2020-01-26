using Microsoft.EntityFrameworkCore;
using SportApplicationData;
using SportApplicationData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportApplicationServices
{
    public class SportService : ISport
    {
        private readonly ApplicationDbContext _context;

        public SportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSport(Sport newSport)
        {
            _context.Add(newSport);
            _context.SaveChanges();
        }

        public IEnumerable<Sport> GetAll()
        {
            return _context.Sports
                .Include(sport => sport.Category);
        }

        public Sport GetById(int id)
        {
            return GetAll()
               .FirstOrDefault(sport => sport.Id == id);
        }

        public Category GetCategory(int id)
        {
            return GetById(id).Category;
        }

        public bool GetIndividual(int id)
        {
            return GetById(id).Individual;
        }

        public string GetName(int id)
        {
            return GetById(id).Name;
        }
    }
}
