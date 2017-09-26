using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class Field : IField
    {
        private int position;
        private string mark;

        public Field(int p, string m)
        {
            position = p;
            mark = m;
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
    }
}
