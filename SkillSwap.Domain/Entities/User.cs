using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSwap.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public Guid OfferdSkillId { get; set;}
        public Skill OfferdSkill { get; set; }
        public Guid WantedSkillId { get; set; }
        public Skill WantedSkill { get; set; }
    }
}
