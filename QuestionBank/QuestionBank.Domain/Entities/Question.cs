﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank.Domain.Entities.Common;

namespace QuestionBank.Domain.Entities;

    public class Question : BaseDomainEntity
    {
        public int InterviewId { get; set; }
        public string QuestionText { get; set; } = null!;

        public Interview Interview { get; set; } = null!;
    }


