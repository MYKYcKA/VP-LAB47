using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task_23.Models
{
    public class QuizAnswerModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Choose your framework")]
        public string Framework { get; set; }
        [Required(ErrorMessage = "Choose your language")]
        public string Language { get; set; }
        public Dictionary<string, bool> Fruits { get; set; }
        public QuizAnswerModel() 
        {
            Fruits = new Dictionary<string, bool>() { { "Banana", false }, { "Apple", false }, { "Orange", false }, { "Melon", false }, { "Watermelon", false } }; ;
        }
    }
}