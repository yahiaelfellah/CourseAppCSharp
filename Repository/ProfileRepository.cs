using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectApp.Models;

namespace CourseProjectApp.Repository
{
    public class ProfileRepository:IProfileRepository
    {
        private readonly ProfileContext _context;
        public ProfileRepository(ProfileContext context)
        {
            _context = context;
        }
        public List<Hobbies> GetHobbyList(string id)
        {
            return _context.Hobby.Where(x => x.AspNetUserId == id).ToList();
        }

        public List<Organization> GetOrganizationList(string id)
        {
            return _context.Organizations.Where(x => x.AspNetUserId == id).ToList();
        }

        public List<Individual> GetIndividualList(string id)
        {
            return _context.Individuals.Where(x => x.AspNetUserId == id).ToList();
        }

        public async void CreateHobby(Hobbies model)
        {
            _context.Add(model);
             await _context.SaveChangesAsync();
        }
        public async void CreateOrganization(Organization model)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();
        }

        public async void CreateIndividual(Individual model)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();
        }
    }
}
