namespace KTs_CSharp
{
    public static class Helper
    {
        public static string Answer => _answer;
        private static string _answer = string.Empty;

        public static void CreateAnIdentation(string text)
        {
            Console.Write("\n====================" +
                $"=> [{text} <=]" +
                "====================\n");
        }

        public static void GetAnswer()
        {
            Console.Write("\n >> ");
            _answer = Console.ReadLine();

            if (_answer == string.Empty)
            {
                Console.Write($"\nYour answer is empty\n");
                GetAnswer();
            }
        }    
    }
}
