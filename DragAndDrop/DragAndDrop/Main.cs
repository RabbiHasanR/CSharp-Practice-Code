using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtNote_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            txtNote.Text += e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
