using System.Collections.Generic;
using CourseProjectApp.Models;

namespace CourseProjectApp.ViewModels
{
    public class DashboardViewModel
    {
        public List<Individual> Individuals { get; set; }

        public List<Organization> Organization { get; set; }

        public List<Hobbies> Hobby { get; set; }
    }
}
