namespace Textures
{
    class Program
    {
        static void Main()
        {
            using (Window game = new Window(800, 600, "Textures"))
            {
                game.Run(60);
            }
        }
    }
}
