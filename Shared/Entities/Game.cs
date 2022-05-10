using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePowerOfKnowledge.Shared.Entities
{
    public class Game
    {
        public int ID { get; set; }
        public int GamePin { get; set; }
        public string GameTopic { get; set; }
        public string GameQuestionText { get; set; }
        public string GameQuestionImge { get; set; }
        public bool IsPublish { get; set; }
        public int UserID { get; set; }
        public List<Answer> GameAnswers { get; set; }



    }
}