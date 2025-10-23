namespace Translation_Dictionary_Console
{
    internal class Program
    {
         static Dictionary<string, string> dictionaryTranslation = new Dictionary<string, string> { 
            {"Szkoła","School"},
            {"Pies","Dog"},
            {"Kot","Cat"},
            {"Krowa","Cow"},
            {"Auto","Car"},

        };
        static private int _score = 0;
        static private int _count = 1;
        static void Main(string[] args)
        {
            Start();

        }
        public static void Start()
        {
            Translate();
            EndGame();
        }
        public static void Translate()
        {
            Console.WriteLine("Translate From Polish to English");
            foreach(KeyValuePair<string,string> pair in dictionaryTranslation)
            {
                Console.WriteLine($"======UR SCORE {_score}/{dictionaryTranslation.Count}=======");
                Console.Write($"{pair.Key} => ");
                string input = Console.ReadLine();
                if (input.Equals(pair.Value,StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Good Answer!");
                    Console.Write($"{_count}.{pair.Key} => {pair.Value}");
                    _score++;
                }else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Answer!");
                    Console.WriteLine("Solution:");
                    Console.Write($"{_count}.{pair.Key} => {pair.Value}");
                }
                _count++;
                Thread.Sleep(1500);
                Console.Clear();
            }

        }
        public static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("=========END GAME=========");
            Console.WriteLine($"======UR SCORE {_score}/{dictionaryTranslation.Count}=======");
            int count = 1;
            foreach(KeyValuePair<string,string> pair in dictionaryTranslation)
            {
                Console.WriteLine($"{count}.{pair.Key} => {pair.Value}");
                count++;
            }

        }
    }
}
