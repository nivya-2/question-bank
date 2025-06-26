using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank.Domain.Entities.Common;

namespace QuestionBank.Domain.Entities;

    public class InterviewSkill : BaseDomainEntity
    {
        public int InterviewId { get; set; }
        public int SkillId { get; set; }

        public Interview Interview { get; set; } = null!;
        public Skill Skill { get; set; } = null!;
    }


