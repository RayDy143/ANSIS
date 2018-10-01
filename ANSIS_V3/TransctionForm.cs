using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework;

namespace ANSIS_V3
{
    public partial class TransctionForm : MetroFramework.Forms.MetroForm
    {
        public TransctionForm()
        {
            InitializeComponent();
        }

        private void TransctionForm_Load(object sender, EventArgs e)
        {

        }

        private void mtpRequisitionOFRequirement_Click(object sender, EventArgs e)
        {

        }

        private void mbtnSelectStud_Click(object sender, EventArgs e)
        {
            ViewSelectedStudToRequisitionForm Vssr = new ViewSelectedStudToRequisitionForm();
            Vssr.ShowDialog();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void mtbSelectedStudPay_Click(object sender, EventArgs e)
        {
            ViewSelectedStudToPayment vsp = new ViewSelectedStudToPayment();
            vsp.ShowDialog();
        }
    }
}
