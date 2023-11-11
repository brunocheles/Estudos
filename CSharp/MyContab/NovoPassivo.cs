using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    public partial class NovoPassivo : Form
    {
        public NovoPassivo()
        {
            InitializeComponent();
        }

        private void BTNCancelarPassivo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
