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
            ExerciseOne();
        }  
    }
}