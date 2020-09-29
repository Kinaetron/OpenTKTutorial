namespace MultipleTextures
{
    class Program
    {
        static void Main()
        {
            using (Window game = new Window(800, 600, "Multiple Textures"))
            {
                game.Run(60);
            }
        }
    }
}
