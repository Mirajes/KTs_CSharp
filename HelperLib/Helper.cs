namespace HelperLib
{
    public class Helper
    {
        public void CreateIndentation() // отступ
        {

        }


        public void Announce(string text)
        {
            Console.Write($"\n\n" +
                $"=> [{text}] <=" +
                $"\n\n"
                );
        }

        public void WaitForInput(ref string answer)
        {
            

            Console.Write("\n>> ");

        }
    }
}