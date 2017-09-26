using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class Play : IMove
    {
        private IEnumerable<string> sequencer;
        private int maxMoves;
        private int seqCount;
        private int index;

        public Play(ISequencer sequencer, int maxMoves)
        {
            this.sequencer = sequencer.GetSequence(maxMoves);
            this.maxMoves = maxMoves;
            this.seqCount = this.sequencer.Count();
            this.index = 0;
        }

        public string Next()
        {
            if (index == maxMoves)
                return null;

            string next = this.sequencer.ElementAt(index);
            index++;
            return next;
        }
   }
}
