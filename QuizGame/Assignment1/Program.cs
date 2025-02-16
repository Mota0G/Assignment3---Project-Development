namespace Assignment1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz!");
            GetQuizGeography(); //Start the Quiz
        }
        static void GetQuizGeography()
        {
            Quiz quiz = new Quiz(); //New instance
            quiz.quizName = "Quiz Geography";

            //Questions
            quiz.questions.Add("What is the capital of Canada?");
            quiz.options.Add("A)Toronto B)Waterloo C)Ottawa D)Kitchener E)Skip");
            quiz.answer.Add("C");

            quiz.questions.Add("What is the capital of Australia?");
            quiz.options.Add("A)Toronto B)Washington, D.C. C)Buenos Aires D)Camberra E)Skip");
            quiz.answer.Add("D");

            quiz.questions.Add("What is the capital of Brazil?");
            quiz.options.Add("A)Boa vista B)Rio de Janeiro C)Natal D)Brasilia E)Skip");
            quiz.answer.Add("D");

            quiz.questions.Add("What is the capital of USA?");
            quiz.options.Add("A)Washington, D.C. B)Los Angeles C)Chicago D)Houston E)Skip");
            quiz.answer.Add("A");

            quiz.questions.Add("What is the capital of Mexico?");
            quiz.options.Add("A)Guadalajara B)Mexico City C)Chicago D)Cancún E)Skip");
            quiz.answer.Add("B");


            bool answerUserValid = false;
            while (answerUserValid == false) //it is necessary to have a specific input (yes/no)
            {
                Console.WriteLine("Do you want to start the Quiz? (yes/no)\n");
                Console.Write("Answer: ");
                string answerUser = Console.ReadLine();

                if (answerUser == "yes") //if the user types "yes"
                {
                    Console.WriteLine("\nLet's Go\n");
                    quiz.displayQuiz();

                    while (answerUserValid == false) // You can play again
                    {
                        Console.Write("\nDo you want to do the Quiz again? (yes/no)\n");
                        answerUser = Console.ReadLine();
                        if (answerUser == "yes")
                        {
                            quiz.answerUserList.Clear();
                            quiz.score.Clear();
                            quiz.displayQuiz();
                        }
                        else if (answerUser == "no")
                        {
                            answerUserValid = true;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease, enter a valid answer.");
                        }
                    }

                }
                else if (answerUser == "no") //if the user types "no"
                {
                    Console.WriteLine("Ok, have a good day!");
                    answerUserValid = true;
                }
                else
                {
                    Console.WriteLine("\nPlease, enter a valid answer."); //if the user types something else
                }
            }
        }
    }
}
