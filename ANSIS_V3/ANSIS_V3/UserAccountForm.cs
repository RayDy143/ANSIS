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
using MetroFramework;

namespace ANSIS_V3
{
	public partial class UserAccountForm : MetroForm
	{
		public UserAccountForm()
		{
			InitializeComponent();
		}
		DataClassDataContext db = new DataClassDataContext();
		private void UserAccountForm_Load(object sender, EventArgs e)
		{
			DisplayUserAccounts();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int uid = 0;
			if (cmbUserType.Text == "Admin")
			{
				uid = 5;
			}
			else
			{
				uid = 6;
			}
			if (btnAdd.Text == "Add")
			{
				var useraccount = new UserAccount();
				useraccount.Firstname = txtFname.Text;
				useraccount.Lastname = txtLname.Text;
				useraccount.Middlename = txtMname.Text;
				useraccount.Username = txtFname.Text + txtLname.Text;
				useraccount.Password = "1234";
				useraccount.ContactNumber = txtContactNo.Text;
				useraccount.UserTypeID = uid;
				db.UserAccounts.InsertOnSubmit(useraccount);
				db.SubmitChanges();
				MessageBox.Show("Successfully Added!");
				DisplayUserAccounts();
				clear();
			}
			else
			{
				var updateuser = db.UserAccounts.SingleOrDefault(u => u.UserAccountID == id);
				updateuser.Firstname = txtFname.Text;
				updateuser.Middlename = txtMname.Text;
				updateuser.Lastname = txtLname.Text;
				updateuser.ContactNumber = txtContactNo.Text;
				updateuser.UserTypeID = uid;
				db.SubmitChanges();
				MessageBox.Show("Successfully Updated!");
				clear();
				DisplayUserAccounts();
				btnAdd.Text = "Add";
			}
		}
		public void DisplayUserAccounts()
		{
			var user = from u in db.UserAccounts join utype in db.UserTypes on u.UserTypeID equals utype.UserTypeID
					   select new{u.UserAccountID,u.Firstname,u.Middlename,u.Lastname,u.Username,u.ContactNumber,utype.Type};
			dgvUserAccounts.DataSource = user;
		}
		public void clear()
		{
			txtFname.Clear();
			txtMname.Clear();
			txtLname.Clear();
			txtContactNo.Clear();
			cmbUserType.SelectedIndex = -1;
			id = 0;
		}
		int id = 0;
		private void dgvUserAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id =int.Parse(dgvUserAccounts.CurrentRow.Cells[0].Value.ToString());
			txtFname.Text = dgvUserAccounts.CurrentRow.Cells[1].Value.ToString();
			txtMname.Text = dgvUserAccounts.CurrentRow.Cells[2].Value.ToString();
			txtLname.Text = dgvUserAccounts.CurrentRow.Cells[3].Value.ToString();
			txtContactNo.Text = dgvUserAccounts.CurrentRow.Cells[5].Value.ToString();
			cmbUserType.Text= dgvUserAccounts.CurrentRow.Cells[6].Value.ToString();
			btnAdd.Text = "Update";
			btnCancel.Text = "Cancel";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (btnCancel.Text == "Cancel")
			{
				clear();
				btnCancel.Text = "Clear";
				btnAdd.Text = "Add";
			}else
			{
				clear();
			}
		}
	}
}
