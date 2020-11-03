namespace CoordinateSystems
{
    class Program
    {
        private static void Main()
        {
            using (var window = new Window(800, 600, "Coordinate Systems"))
            {
                window.Run(60.0);
            }
        }
    }
}
