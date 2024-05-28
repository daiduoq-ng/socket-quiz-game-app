using System.Collections.Generic;

namespace NT106
{
    public class QuestionModel
    {
        public string question { get; set; }
        public string[] choices { get; set; }
        public int answer { get; set; }
    }

    public class QuestionsData
    {
        public List<QuestionModel> questions { get; set; }
    }

}
