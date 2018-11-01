using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementAPI.From
{
    public partial class wProgressDlg : MetroFramework.Forms.MetroForm
    {
        public wProgressDlg()
        {
            InitializeComponent();
        }
       // Update Progress Status
        public int W_SETnProgressValue
        {
            set { this.opgStatus.Value = value; }
        }
    }
}
