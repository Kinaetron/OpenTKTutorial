using Transformations.Resources;

namespace Transformations
{
    class Program
    {
        static void Main()
        {
            using (var window = new Window(800, 600, "Transformations"))
            {
                window.Run();
            }
        }
    }
}
