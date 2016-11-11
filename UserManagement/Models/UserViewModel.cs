using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UserManagement.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem
            {
                Text = "Мужской",
                Value = "true"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Женский",
                Value = "false"
            });
        }
        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'.'MM'.'yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "День рождение")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public bool Gender { get; set; }

        [Display(Name = "Дата посещения")]
        public DateTime? VisitDate { get; set; }

        public List<SelectListItem> listItems { get; set; }
    }


}