using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    public class BankOfQuestions
    {
        public List<string> InitializeList()
        {
            List<string> QuestionList = new List<string>();

            foreach (string line in System.IO.File.ReadLines(@"<Put your local drive file here>"))
            {
                QuestionList.Add(line);
            }

            return QuestionList;
        }

        public List<string> AddQuestion(List<string> QuestionList, string Question)
        {
            QuestionList.Add((QuestionList.Count + 1 + " ") + Question);
            return QuestionList;
        }

        public List<string> DeleteQuestion(List<string> QuestionList, int QuestionCounter)
        {
            QuestionList.RemoveAt(QuestionCounter-1);
            return QuestionList;
        }

        public string PickQuestion(List<string> QuestionList)
        {
            Random rnd = new Random();
            int QuestionCounter = rnd.Next(0, QuestionList.Count()-1);
            return QuestionList[QuestionCounter];
        }

        public string DisplayQuestionList(List<string> QuestionList)
        {
            string QuestionListText = string.Empty;
            int counter = 1;
            foreach(string Question in QuestionList)
            {
                QuestionListText += counter + " " + Question + '\n';
                counter++;
            }
            return QuestionListText;
        }
    }
}
