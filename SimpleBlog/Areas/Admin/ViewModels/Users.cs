using SimpleBlog.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.Areas.Admin.ViewModels
{
    public class RoleCheckbox
    {
        public int Id { get; set; }

        public bool IsChecked { get; set; }

        public string Name { get; set; }

    }

    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }

    public class UsersNew
    {
        [Required, MaxLength(128)]
        public string Username { get; set; }


        [Required, DataType(DataType.Password)]
        public string Password { get; set; }


        [Required, DataType(DataType.EmailAddress), MaxLength(128)]
        public string Email { get; set; }

        public IList<RoleCheckbox> Roles { get; set; }
    }

    public class UsersEdit
    {
        [Required, MaxLength(128)]
        public string Username { get; set; }


        [Required, DataType(DataType.EmailAddress), MaxLength(128)]
        public string Email { get; set; }

        public IList<RoleCheckbox> Roles { get; set; }
    }

    public class ResetPassword
    {
        public string Username { get; set; }


        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
