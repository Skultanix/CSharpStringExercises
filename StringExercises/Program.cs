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
            //Calling the 'Exercise Classes'
            //ExerciseOne();
            ExerciseTwo();
        }  
    }
}