using AdventOfCode2023.Day4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023Tests
{
    public class Day4
    {
        [Fact]
        public void Card_Id_IsAssigned()
        {
            Card card = new Card("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53");
            Assert.Equal(1, card.Id);
        }

        [Fact]
        public void ScratchCards_Part2_TotalCards()
        {
            ScratchCards scratchCards = new ScratchCards(@"Day4TestInput.txt");
            Assert.Equal(30, scratchCards.calculateTotalCards());
        }
    }
}
