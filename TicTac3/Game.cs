using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class Game : IGame
    {
        private IWinningSet winnSet;
        private IMove moveManager;
        private List<IField> fields;

        public Game(IWinningSet winnSet, IMove moveManager)
        {
            this.winnSet = winnSet;
            this.moveManager = moveManager;
            fields = new List<IField>();
        }


        public string CheckWinner(IField field)
        {
            fields.Add(field);
            return  winnSet.WinningFields.GetWinnerIfSubset(fields, field);
        }
    }
}
