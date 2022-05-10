using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePowerOfKnowledge.Shared.Entities
{
    public class Answer
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public bool CorrectAnswer { get; set; }
        public bool HaveImge { get; set; }
        public int GameID { get; set; }


    }
}
