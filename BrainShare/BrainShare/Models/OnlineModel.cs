﻿using System.Collections.Generic;

namespace BrainShare.Models
{
    public class OnlineModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string full_names { get; set; }
        public List<PastPaperModel> PastPapers { get; set; }
        public List<QuizModel> Quiz { get; set; }
        public List<ExamModel> Exams { get; set; }
    }
}
