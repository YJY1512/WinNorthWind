using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNorthwind
{
    public partial class frmWaitAsyncPop : Form
    {
        public frmWaitAsyncPop(Action action)
        {
            InitializeComponent();
        }


    }
}
