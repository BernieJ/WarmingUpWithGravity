using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmingUpWithGravity
{
  class Program
  {
    static void Main(string[] args)
    {      
      var input = ParseInput();

      int winner = CalculateGravity(input);

      Console.WriteLine($"Planet number {winner} has the most gravity");
      Console.ReadKey();
    }

    private static int CalculateGravity(List<(double height, double time)> input)
    {
      int maxItemIndex = -1;
      double maxGravity = 0;
      for (int i = 0; i < input.Count; i++)
      {
        var current = input[i];
        double currentGravity = (current.height * 2) / (Math.Pow(current.time,2));

        if (currentGravity > maxGravity)
        {
          maxItemIndex = i; 
        }
      }
      return maxItemIndex +1;
    }

    private static List<(double height, double time)> ParseInput()
    {
      var NumberOfPlanets = int.Parse(Console.ReadLine());
      List<(double height, double time)> planetsHeightAndTime = new List<(double height, double time)>();
      for (int i = 0; i < NumberOfPlanets; i++)
      {
        var line2 = Console.ReadLine();
        var HeightAndTime = line2.Split(' ');

        var height = double.Parse(HeightAndTime[0]);
        var TimeToFall = double.Parse(HeightAndTime[1]);
        (double height, double time) tuple = (height, TimeToFall);

        planetsHeightAndTime.Add(tuple);
      }
      return planetsHeightAndTime;
    }
  }
}
