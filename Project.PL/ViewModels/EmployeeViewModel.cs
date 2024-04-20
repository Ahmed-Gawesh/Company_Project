using Project.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace Project.PL.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [MaxLength(50, ErrorMessage = "Max Length Is 50 Chars")]
        [MinLength(5, ErrorMessage = "Min Length Is 5 Chars")]
        public string Name { get; set; }
        [Range(20, 35, ErrorMessage = "Age Must Be Between 20 & 35")]
        public int? Age { get; set; }
        //[RegularExpression("^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}-[a-zA-Z]$",
        //    ErrorMessage ="Address Must Like Be 123-Street-City-Country")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public string ImageName { get; set; }

        public IFormFile Image { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        //FK: Optional: OnDelete =>Restrict   القسم هو اللي هيتمسح بس ,اي حاجو مربوطة مش بتتمسح

        //FK: Required: OnDelete =>Cascade  يعني انت لو هتمسح قسم هتمسح اي حد مربوط بيه
        public Department Department { get; set; }// Navigational Property   One 
    }
}
