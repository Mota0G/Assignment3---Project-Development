namespace Assignment1
{
    internal class Quiz
    {
        static int counterID; 
        public int quizId { get; set; }
        public string quizName { get; set; }

        public List<string> questions = new List<string>();
        public List<string> options = new List<string>();
        public List<string> answer = new List<string>();
        public List<string> answerUserList = new List<string>(); //What the user entered
        public List<double> score = new List<double>(); // Marks

        public Quiz()
        {
            counterID++;
            this.quizId = counterID; //Add always a new id for the new object
        }
        public void displayQuiz()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                bool ValidationAnswer = false;
                string answerUser = "";

                while (ValidationAnswer == false) //it is necessary to have a specific input (A,B,C,D,E)
                {
                    Console.Write($"\n{questions[i]}");
                    Console.WriteLine($" \n\n{options[i]}\n");
                    Console.Write("Enter the answer(A,B,C,D,E): ");
                    answerUser = Console.ReadLine();


                    switch (answerUser) 
                    {
                        case "A":
                            ValidationAnswer = true;
                            answerUserList.Add(answerUser);
                            break;
                        case "B":
                            ValidationAnswer = true;
                            answerUserList.Add(answerUser);
                            break;
                        case "C":
                            ValidationAnswer = true;
                            answerUserList.Add(answerUser);
                            break;
                        case "D":
                            ValidationAnswer = true;
                            answerUserList.Add(answerUser);
                            break;
                        case "E":
                            ValidationAnswer = true;
                            answerUserList.Add(answerUser);
                            break;
                        default:
                            Console.WriteLine("\nPlease Enter an option!!!\n");
                            break;
                    }
                }

                if (answerUser == answer[i])
                {
                    score.Add(1);
                }
                else if (answerUser == "E")
                {
                    score.Add(0);
                }
                else 
                {
                    score.Add(-0.25);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nResults:\n"); //Display the results
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Write(questions[i]);
                Console.Write($" {options[i]} - Answer: ");
                Console.WriteLine($" {answer[i]}\n");
                Console.WriteLine($"Your answer: {answerUserList[i]} - ({score[i]})\n");
            }
            double counter = 0;

            for (int j = 0; j < score.Count; j++)
            {
                counter = score[j]+ counter;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            if (counter >= 0)
            {
                Console.Write($"You scored {counter}");
                counter = (counter * 100 / 5);
                Console.WriteLine($" - {counter}%");

            }
        }


    }
}
