using System;
using System.Collections;
using System.Collections.Generic;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string KnownAs { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string Gender { get; set; }

        public string Pronouns { get; set; }

        public string Introduction { get; set; }

        public string Interests { get; set; }

        public string HomeFaire { get; set; }

        public string ActType { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Country { get; set; }

        public ICollection<Photo> Photos { get; set; }





    }
}