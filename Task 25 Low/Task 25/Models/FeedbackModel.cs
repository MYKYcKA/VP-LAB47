using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Task_23.Models
{
    public class FeedbackModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [Display(Name = "Surname")]
        public string AuthorSurname { get; set; }
        public DateTime FeedbackDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Text is required")]
        [Display(Name = "Your opinion")]
        public string FeedbackText { get; set; }
    }
}