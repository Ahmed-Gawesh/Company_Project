using System;

namespace Project.PL.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }

        public bool isSelected { get; set; }
        public RoleViewModel()  // علشان هو اللي يبقي يحط ال id مش المستخدم او انا 
        {
            Id=Guid.NewGuid().ToString();
        }
    }
}
