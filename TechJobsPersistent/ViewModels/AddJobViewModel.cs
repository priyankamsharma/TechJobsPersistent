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
        public int JobName { get; set; }

        //[Required(ErrorMessage = "Employer ID is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel()
        {
        }

        //public AddJobViewModel(Job theJob, List<SelectListItem> Employers)
        //{
        //    Skills = new List<SelectListItem>();

        //    foreach (var skill in possibleSkills)
        //    {
        //        Skills.Add(new SelectListItem
        //        {
        //            Value = skill.Id.ToString(),
        //            Text = skill.Name
        //        });
        //    }

        //    Job = theJob;
        //}
    }
}
