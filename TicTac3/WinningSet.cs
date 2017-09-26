using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class WinningSet : IWinningSet
    {
        private int[][] winningFields;

        public WinningSet()
        {
            int[][] winSet =
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
                new int[] {1,4,7},
                new int[] {2,5,8},
                new int[] {3,6,9},
                new int[] {1,5,9},
                new int[] {3,5,7}
            };

            this.WinningFields = winSet;
        }

        public int[][] WinningFields
        {
            get { return winningFields; }
            set { winningFields = value; }
        }
    }
}
