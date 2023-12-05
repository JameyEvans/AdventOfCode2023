using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Day4
{
    public class ScratchCards
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public int TotalPoints { get; set; }

        public ScratchCards(string filePath = @"Day4/input.txt") {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Card card = new Card(line);
                TotalPoints += card.gradeCard();
                Cards.Add(card);
            }
        }

        public int calculateTotalCards()
        {
            TotalPoints = 0;
            Dictionary<int, int> numCards = new Dictionary<int, int>();
            for (int i = 0; i < Cards.Count; i++)
            {
                numCards.Add(i, 1);
            }
            for (int i = 0; i < Cards.Count; i++)
            {
                int cardPoints = Cards[i].gradeNumber();
                for (int j = 1; j < cardPoints + 1; j++)
                {
                    if (i + j < Cards.Count)
                    {
                        numCards[i + j] += numCards[i];
                    }                    
                }                
                
            }

            foreach (KeyValuePair<int, int> pair in numCards)
            {
                TotalPoints += pair.Value;
            }
            return TotalPoints;

        }

    }
}
