using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Day4
{
    public class Card
    {
        public int Id { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();
        public List<int> WinningNumbers { get; set; } = new List<int>();
        public int Points { get; set; }

        public Card(string line)
        {
            string[] parts = line.Split(':');
            parts[0] = parts[0].Replace("Card ", "");
            String[] numbers = parts[1].Trim().Split('|');
            string[] cardNumbers = numbers[0].Trim().Split(' ');
            String[] winningNumbers = numbers[1].Trim().Split(' ');
            
            foreach (string number in cardNumbers)
            {
                try
                {
                    Numbers.Add(int.Parse(number.Trim()));

                }
                catch (Exception e)
                {
                    continue;
                }
            }

            foreach (string number in winningNumbers)
            {
                try
                {
                    WinningNumbers.Add(int.Parse(number.Trim()));
                }
                catch (Exception e)
                {
                    continue;
                }
                
            }

            Id = int.Parse(parts[0].Trim());
        }

        public int gradeCard()
        {
            int points = 0;
            foreach (int number in Numbers)
            {
                if (WinningNumbers.Contains(number))
                {
                    if (points == 0)
                    {
                        points = 1;
                    }
                    else
                    {
                        points = 2 * points;
                    }
                }
            }
            Points = points;
            return points;
        }

        public int gradeNumber()
        {
            int points = 0;
            foreach (int number in Numbers)
            {
                if (WinningNumbers.Contains(number))
                {
                    points++;
                }
            }
            return points;
        }
    }
}
