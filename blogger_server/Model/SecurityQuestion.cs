using Microsoft.Build.Framework;

namespace blogger_server.Model
{
    public class SecurityQuestion
    {
        [Required]
        public string SecurityQuestionOne { get; set; }
        [Required]
        public string SecurityQuestionTwo { get; set; }
        [Required]
        public string SecurityQuestionThree { get; set; }

        [Required]
        public string SecurityAnswerOne { get; set; }
        [Required]
        public string SecurityAnswerTwo { get; set; }
        [Required]
        public string SecurityAnswerThree { get; set; }

    }
}
