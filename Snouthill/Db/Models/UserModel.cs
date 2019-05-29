using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Snouthill.Db.Models
{
    class UserModel
    {
        [Key] public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Motto { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string Figure { get; set; }
        public string SwimsuitFigure { get; set; }

        public bool Superuser { get; set; } = false;
        public string Badge { get; set; }
        public int Credits { get; set; } = 0;
    }
}
