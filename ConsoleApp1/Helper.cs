namespace KTs_CSharp
{
    public class Helper
    {
        public string Answer => _answer;
        private string _answer = string.Empty;

        public void CreateAnIdentation(string text)
        {
            Console.Write("\n====================" +
                $"=> [{text} <=]" +
                "====================\n");
        }

        public void MakeNewAnswer()
        {
            Console.Write("\n >> ");
            _answer = Console.ReadLine();

            if (_answer == string.Empty)
            {
                Console.Write($"\nYour answer is empty\n");
                MakeNewAnswer();
            }
        }    
    }
}
