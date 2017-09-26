using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacUI
{
    public partial class Field : UserControl
    {

        public Field()
        {
            InitializeComponent();
         
        }

        public Field(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public Label label
        {
            get { return label1; }
            set { label1 = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
