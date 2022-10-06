using Unit2.CardGame;

namespace Unit2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// The function will generate a new director.
        /// Game will begin by calling the StartGame method.
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}
