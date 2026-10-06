namespace CatFramework
{

    public class CatException : ArgumentException
    {
        public CatException(string message) 
        {
            Console.WriteLine($"[ERROR][CatException] - {message}");
        }
    }
}
