using System;

namespace DbFirst_Exercise_Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();

            dbContext.AddVideo("Shrek", new DateTime(2015, 2, 5), "Comedy", (byte)Classification.Gold);
            dbContext.AddVideo("Star Wars I", new DateTime(1988, 7, 25), "Action", (byte)Classification.Platinum);
        }
    }
}
