using System.Diagnostics.Tracing;

namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ExerciseOne()
            {
                Console.WriteLine("Please enter a sequence of numbers separated by a hyphen (-).");
                var input = Console.ReadLine();
                string[] splitInput = input.Split("-");
                List<int> intList = new List<int>();


                foreach (string s in splitInput)
                {
                    intList.Add(int.Parse(s));
                }

                var isConsecutive = true;
                int sequenceDist = 0;

                for (int i = 0; i < intList.Count - 1; i++)
                {
                    if (sequenceDist == 0)
                    {
                        sequenceDist = intList[i + 1] - intList[i];
                    }
                    else
                    {
                        if ((intList[i + 1] - intList[i]) != sequenceDist)
                        {
                            isConsecutive = false;
                            break;
                        }
                    }
                }
                if (isConsecutive == true)
                {
                    Console.WriteLine("Numbers are consecutive.");
                }
                else
                {
                    Console.WriteLine("Numbers are not consecutive");
                }
            }
            static void ExerciseTwo()
            {
                Console.WriteLine("Please write a series of numbers separated by hyphens (-).");
                var input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input))
                {
                    return;
                }
                var numList = new List<int>();
                foreach(var number in input.Split("-"))
                {
                    numList.Add(int.Parse(number));
                }
                var hasDuplicates = false;
                var isUnique = new List<int>();
                for(var i = 0; i < numList.Count; i++)
                {
                    if (isUnique.Contains(numList[i]))
                    {
                        hasDuplicates = true;
                    } 
                    else
                    {
                        isUnique.Add(numList[i]);
                    }
                }
                if(hasDuplicates == true)
                {
                    Console.WriteLine("Duplicates present.");
                }
                else
                {
                    Console.WriteLine("No duplicates present.");
                }

            }
            static void ExerciseThree()
            {
                Console.WriteLine("Please enter a valid time in 24-hr format.");
                var input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid time provided.");
                    return;
                }
                var hourAndMinutes = input.Split(":");
                if(hourAndMinutes.Length != 2)
                {
                    Console.WriteLine("Invalid time provided.");
                    return;
                }
                var hour = int.Parse(hourAndMinutes[0]);
                var minute = int.Parse(hourAndMinutes[1]);
                if((hour >= 0) && (hour <= 23) && (minute >= 0) && (minute <= 59))
                {
                    Console.WriteLine("Valid time provided");
                }    
                else
                {
                    Console.WriteLine("Invalid time provided.");
                }
            }
            static void ExerciseFour()
            {
                Console.WriteLine("Say the first few words on your mind and they will be converted to pascal case (PascalCase).");
                var input = Console.ReadLine();
             
                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error.");
                    return;
                }
                var pascalizedInput = "";
                foreach(var word in input.Split(" "))
                {
                    var pascalizedWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                    pascalizedInput += pascalizedWord;
                }
                Console.WriteLine(pascalizedInput);
            }
            //Calling the 'Exercise Classes'
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            ExerciseFour();
        }
    }
}