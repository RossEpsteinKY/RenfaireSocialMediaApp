using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string PhotoUrl { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastActive { get; set; }

        public string Gender { get; set; }

        public string Pronouns { get; set; }

        public string Introduction { get; set; }

        public string Interests { get; set; }

        public string HomeFaire { get; set; }

        public string ActType { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Country { get; set; }

        public ICollection<PhotoDto> Photos { get; set; }

    }
}