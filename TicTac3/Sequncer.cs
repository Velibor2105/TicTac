using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class Sequncer : ISequencer
    {

        public IEnumerable<string> GetSequence(int count)
        {
            return Sequence().Take(count);
        }

        private IEnumerable<string> Sequence()
        {
            while (true)
            {
                yield return "X";
                yield return "O";
            }
        }
    }
}
