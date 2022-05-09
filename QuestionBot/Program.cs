using System;
using System.Collections.Generic;

namespace QuestionBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialize question object
            BankOfQuestions boq = new BankOfQuestions();
            List<string> QuestionList = boq.InitializeList();
            var Display = boq.DisplayQuestionList(QuestionList);

            //Add Question
            Console.WriteLine("What question would you like to add?");
            string QuestionToAdd = Console.ReadLine();
            QuestionList = boq.AddQuestion(QuestionList, QuestionToAdd);

            //Display question list
            Console.WriteLine(Display);

            //pick a random Question
            string PickedQuestion = boq.PickQuestion(QuestionList);
            Console.WriteLine(PickedQuestion);

            //Remove questions
            Console.WriteLine(Display);
            Console.WriteLine("Which question do you want to remove?");
            string strQuestionCounter = Console.ReadLine();
            int QuestionCounter = Convert.ToInt32(strQuestionCounter);
            QuestionList = boq.DeleteQuestion(QuestionList, QuestionCounter);
            var NewDisplay = boq.DisplayQuestionList(QuestionList);
            Console.WriteLine(NewDisplay);
        }
    }
}
