namespace Camera
{
    class Program
    {
        static void Main()
        {
            using (var window = new Window(800, 600, "Camera"))
            {
                window.Run(60.0);
            }
        }
    }
}
