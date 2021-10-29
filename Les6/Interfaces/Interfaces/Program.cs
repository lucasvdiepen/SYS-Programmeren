using System;
using System.Threading;

namespace Interfaces
{
    class Program
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        static void Main(string[] args)
        {
            PlayerController playerController = new PlayerController(new InputDevice());

            double lastFrameTime = GetCurerntTime();

            while(true)
            {
                double currentTime = GetCurerntTime();
                float frameTime = Convert.ToSingle(currentTime - lastFrameTime);
                lastFrameTime = currentTime;

                //Console.WriteLine(frameTime);

                playerController.Logic(frameTime);
            }
        }

        public static double GetCurerntTime()
        {
            return DateTime.Now.ToUniversalTime().Subtract(Epoch).TotalMilliseconds;
        }
    }
}
