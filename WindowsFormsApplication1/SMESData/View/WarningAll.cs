using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WarningAll : Form
    {
        public WarningAll()
        {
            InitializeComponent();
        }

        private void WarningAll_Load(object sender, EventArgs e)
        {
            lbDate.Text = Convert.ToDateTime(SaveData.Date).ToString("dd-MM-yyyy");
            lbNGA.Text = SaveData.NGallow + "%";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
            UpdateStatus();
        }

        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        private void UpdateStatus()
        {
            EventArgs args = new EventArgs();

            //Call any listeners
            OnUpdateStatus?.Invoke(this, args);

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
