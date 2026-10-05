namespace CatFramework
{

    public class CatException : ArgumentException
    {
        public CatException(string message) 
        {
            throw new ArgumentException(message);
        }
    }
}
