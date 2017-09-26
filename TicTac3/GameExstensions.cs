using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public static class GameExstensions
    {
        public static string GetWinnerIfSubset(this int [][] subSets, IEnumerable<IField> superSet, IField field)
        {
            string mark = "DRAW";
            subSets.ToList().ForEach(s => { if (s.IsSubset(superSet.Where(p => p.Mark == field.Mark).Select(c => c.Position))) { mark = field.Mark; } });
            return mark;
        }
    }
}
