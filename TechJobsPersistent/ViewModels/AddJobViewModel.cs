using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        [Required(ErrorMessage = "Job Name is required")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Employer ID is required")]
        public int EmployerId { get; set; }

        //public Job Job { get; set; }

        public List<SelectListItem> Employers { get; set; }

        //public AddJobViewModel(List<Employer> possibleEmployers)
        //{
        //    Employers = new List<SelectListItem>();

        //    foreach (var employer in possibleEmployers)
        //    {
        //        Employers.Add(new SelectListItem
        //        {
        //            Value = employer.Id.ToString(),
        //            Text = employer.Name
        //        });
        //    }

        //    Job = theJob;
        //}

        public AddJobViewModel()
        {
        }
    }
}
