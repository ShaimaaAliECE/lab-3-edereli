using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class CollectionBoard
    {
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }

        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
        }
        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
        }

    }
}
