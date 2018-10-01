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
	public partial class StudentInformationForm : MetroFramework.Forms.MetroForm
	{
		public StudentInformationForm()
		{
			InitializeComponent();
		}
		DataClassDataContext db = new DataClassDataContext();
		private void StudentProfileForm_Load(object sender, EventArgs e)
		{
			var section = from s in db.Sections
						  select s;
			mcmbSecname.DataSource = section;
			mcmbSecname.DisplayMember = "Section1";
			mcmbSecname.ValueMember = "SectionID";
			var sy = from s in db.Schoolyears
					 select s;
			mcmbShoolYear.DataSource = sy;
			mcmbShoolYear.DisplayMember = "Year";
			mcmbShoolYear.ValueMember = "SchoolyearID";
			displayStudent();
			var studbmi = from s in db.Students
						  select s;
			displayBMI();
		}
		public void displayBMI()
		{
			var studbmi = from s in db.Students
						  select s;

			dgvBMI.Rows.Clear();
			foreach (var s in studbmi)
			{
				double bmi = 0;
				double height = 0;
				double weight = 0;
				string bmires = "";
				height = double.Parse(s.Height.ToString());
				weight = double.Parse(s.Weight.ToString());
				height = height / 3.28;
				bmi = Math.Round((weight / Math.Pow((height), 2)), 2);
				if (bmi < 15)
				{
					bmires = "Very severly underweight";
				}else if(bmi>=15 && bmi <= 16)
				{
					bmires = "Severly underweight";
				}else if(bmi >= 16 && bmi <= 18.5)
				{
					bmires = "Underweight";
				}else if(bmi >= 18.5 && bmi <= 25)
				{
					bmires = "Normal";
				}else if(bmi>=25 && bmi<30)
				{
					bmires = "Overweight";
				}else if(bmi>=30&&bmi<35)
				{
					bmires = "Moderately obese";
				}else if (bmi >= 35 && bmi < 40)
				{
					bmires = "Severly Obese";
				}else if (bmi >= 40)
				{
					bmires = "Very severly obese";
				}
				dgvBMI.Rows.Add(s.Firstname+" "+s.Lastname, bmires);

			}
		}
		private void tpStudProfile_Click(object sender, EventArgs e)
		{

		}
		public void displayStudent()
		{
			var student = from s in db.Students
						  join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
						  join sec in db.Sections on s.SectionID equals sec.SectionID
						  select new { s.StudentID, s.Firstname, s.Middlname, s.Lastname, s.Birthdate,s.Age, s.Address, s.Gender, s.ParentName, s.ParentNo, s.Occupation, s.Height, s.Weight, s.Systolic, s.Diastolic, s.Form137, s.Form138, s.GoodMoral, s.NSO,s.YearLevel, sy.Year, sec.Section1 };
			dgvStud.DataSource = student;
		}
		private void mtbViewStud_Click(object sender, EventArgs e)
		{

		}

		private void mcmb_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void mbtnSelectStud_Click(object sender, EventArgs e)
		{
			ViewSelectStudToGradeForm vsg = new ViewSelectStudToGradeForm();
			vsg.ShowDialog();
		}

		private void metroPanel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void mbtnManageSY_Click(object sender, EventArgs e)
		{
			ManageSchoolyear m = new ManageSchoolyear();
			m.ShowDialog();
		}

		private void mbtnAdd_Click(object sender, EventArgs e)
		{
			if (mbtnAdd.Text == "Add")
			{
				Student stud = new Student();
				stud.Firstname = mtxtFname.Text;
				stud.Middlname = mtxtMname.Text;
				stud.Lastname = mtxtLname.Text;
				stud.Birthdate = mdtpBirthdate.Value;
				stud.Age = int.Parse(mtxtAge.Text);
				stud.Address = mtxtAddress.Text;
				stud.Gender = mtxtGender.Text;
				stud.ParentName = mtxtParentname.Text;
				stud.ParentNo = mtxtContact.Text;
				stud.Occupation = mtxtOccupation.Text;
				stud.Height = decimal.Parse(mtxtHeight.Text);
				stud.Weight = decimal.Parse(mtxtWeight.Text);
				stud.Systolic = int.Parse(mtxtSystolic.Text);
				stud.Diastolic = int.Parse(mtxtDiastolic.Text);
				stud.YearLevel = mcmbYearLevel.Text;
				if (mchk137.Checked)
				{
					stud.Form137 = "Submitted";
				} else
				{
					stud.Form137 = "Not Submitted";
				}
				if (mchkForm138.Checked)
				{
					stud.Form138 = "Submitted";
				}
				else
				{
					stud.Form138 = "Not Submitted";
				}
				if (mchkGoodmoral.Checked)
				{
					stud.GoodMoral = "Submitted";
				}
				else
				{
					stud.GoodMoral = "Not Submitted";
				}
				if (mchkNso.Checked)
				{
					stud.NSO = "Submitted";
				}
				else
				{
					stud.NSO = "Not Submitted";
				}
				stud.SectionID = int.Parse(mcmbSecname.SelectedValue.ToString());
				stud.SchoolyearID = int.Parse(mcmbShoolYear.SelectedValue.ToString());
				db.Students.InsertOnSubmit(stud);
				db.SubmitChanges();
				MessageBox.Show("ADDED");
				displayStudent();
				clearStudent();
				displayBMI();
			}
			else
			{
				var stud = db.Students.SingleOrDefault(x => x.StudentID == int.Parse(dgvStud.CurrentRow.Cells[0].Value.ToString()));
				stud.Firstname = mtxtFname.Text;
				stud.Middlname = mtxtMname.Text;
				stud.Lastname = mtxtLname.Text;
				stud.Birthdate = mdtpBirthdate.Value;
				stud.Age = int.Parse(mtxtAge.Text);
				stud.Address = mtxtAddress.Text;
				stud.Gender = mtxtGender.Text;
				stud.ParentName = mtxtParentname.Text;
				stud.ParentNo = mtxtContact.Text;
				stud.Occupation = mtxtOccupation.Text;
				stud.Height = decimal.Parse(mtxtHeight.Text);
				stud.Weight = decimal.Parse(mtxtWeight.Text);
				stud.Systolic = int.Parse(mtxtSystolic.Text);
				stud.Diastolic = int.Parse(mtxtDiastolic.Text);
				if (mchk137.Checked)
				{
					stud.Form137 = "Submitted";
				}
				else
				{
					stud.Form137 = "Not Submitted";
				}
				if (mchkForm138.Checked)
				{
					stud.Form138 = "Submitted";
				}
				else
				{
					stud.Form138 = "Not Submitted";
				}
				if (mchkGoodmoral.Checked)
				{
					stud.GoodMoral = "Submitted";
				}
				else
				{
					stud.GoodMoral = "Not Submitted";
				}
				if (mchkNso.Checked)
				{
					stud.NSO = "Submitted";
				}
				else
				{
					stud.NSO = "Not Submitted";
				}
				stud.YearLevel = mcmbYearLevel.Text;
				stud.SectionID = int.Parse(mcmbSecname.SelectedValue.ToString());
				stud.SchoolyearID = int.Parse(mcmbShoolYear.SelectedValue.ToString());
				db.SubmitChanges();
				MessageBox.Show("UPDATED");
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
				displayStudent();
				clearStudent();
				displayBMI();
			}
		}
		public void clearStudent()
		{
			mtxtStudID.Clear();
			mtxtFname.Clear();
			mtxtMname.Clear();
			mtxtLname.Clear();
			mdtpBirthdate.Value = DateTime.Now;
			mtxtAddress.Clear();
			mtxtGender.SelectedIndex = -1;
			mtxtParentname.Clear();
			mtxtContact.Clear();
			mtxtOccupation.Clear();
			mtxtHeight.Clear();
			mtxtWeight.Clear();
			mtxtSystolic.Clear();
			mtxtDiastolic.Clear();
			mchk137.Checked = false;
			mchk137.Enabled = true;
			mchkForm138.Checked = false;
			mchkForm138.Enabled = true;
			mchkGoodmoral.Checked = false;
			mchkGoodmoral.Enabled = true;
			mchkNso.Checked = false;
			mchkNso.Enabled = true;
			mcmbYearLevel.SelectedIndex = -1;
			mcmbSecname.SelectedIndex = -1;
			mcmbShoolYear.SelectedIndex = -1;
		}
		private void mdtpBirthdate_ValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Now.Month <= mdtpBirthdate.Value.Month)
			{
				mtxtAge.Text = (DateTime.Now.Year - mdtpBirthdate.Value.Year) + "";
			}
			else
			{
				mtxtAge.Text = (DateTime.Now.Year - mdtpBirthdate.Value.Year) + 1 + "";
			}
		}

		private void txtSearchStud_TextChanged(object sender, EventArgs e)
		{
			var student = from s in db.Students
						  join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
						  join sec in db.Sections on s.SectionID equals sec.SectionID
						  where s.Firstname.Contains(txtSearchStud.Text)||s.Lastname.Contains(txtSearchStud.Text)
						  select new { s.StudentID,s.Firstname, s.Middlname, s.Lastname, s.Birthdate, s.Address, s.Age, s.Gender, s.ParentName, s.ParentNo, s.Occupation, s.Height, s.Weight, s.Systolic, s.Diastolic, s.Form137, s.Form138, s.GoodMoral, s.NSO, sy.Year, sec.Section1 };
			dgvStud.DataSource = student;
		}

		private void dgvStud_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			mtxtStudID.Text = dgvStud.CurrentRow.Cells[0].Value.ToString();
			mtxtFname.Text = dgvStud.CurrentRow.Cells[1].Value.ToString();
			mtxtMname.Text = dgvStud.CurrentRow.Cells[2].Value.ToString();
			mtxtLname.Text = dgvStud.CurrentRow.Cells[3].Value.ToString();
			mdtpBirthdate.Text = dgvStud.CurrentRow.Cells[4].Value.ToString();
			mtxtAge.Text = dgvStud.CurrentRow.Cells[5].Value.ToString();
			mtxtAddress.Text = dgvStud.CurrentRow.Cells[6].Value.ToString();
			mtxtGender.Text = dgvStud.CurrentRow.Cells[7].Value.ToString();
			mtxtParentname.Text = dgvStud.CurrentRow.Cells[8].Value.ToString();
			mtxtContact.Text = dgvStud.CurrentRow.Cells[9].Value.ToString();
			mtxtOccupation.Text = dgvStud.CurrentRow.Cells[10].Value.ToString();
			mtxtHeight.Text = dgvStud.CurrentRow.Cells[11].Value.ToString();
			mtxtWeight.Text = dgvStud.CurrentRow.Cells[12].Value.ToString();
			mtxtSystolic.Text = dgvStud.CurrentRow.Cells[13].Value.ToString();
			mtxtDiastolic.Text = dgvStud.CurrentRow.Cells[14].Value.ToString();
			mcmbYearLevel.Text = dgvStud.CurrentRow.Cells[19].Value.ToString();
			mcmbSecname.Text = dgvStud.CurrentRow.Cells[21].Value.ToString();
			mcmbShoolYear.Text = dgvStud.CurrentRow.Cells[20].Value.ToString();
			if (dgvStud.CurrentRow.Cells[15].Value.ToString() == "Submitted")
			{
				mchk137.Checked = true;
				mchk137.Enabled = false;
			}else
			{
				mchk137.Checked = false;
				mchk137.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[16].Value.ToString() == "Submitted")
			{
				mchkForm138.Checked = true;
				mchkForm138.Enabled = false;
			}
			else
			{
				mchkForm138.Checked = false;
				mchkForm138.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[17].Value.ToString() == "Submitted")
			{
				mchkGoodmoral.Checked = true;
				mchkGoodmoral.Enabled = false;
			}
			else
			{
				mchkGoodmoral.Checked = false;
				mchkGoodmoral.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[18].Value.ToString() == "Submitted")
			{
				mchkNso.Checked = true;
				mchkNso.Enabled = false;
			}
			else
			{
				mchkNso.Checked = false;
				mchkNso.Enabled = true;
			}
			mbtnAdd.Text = "Update";
			mbtnClear.Text = "Cancel";
		}

		private void mbtnClear_Click(object sender, EventArgs e)
		{
			if (mbtnClear.Text == "Clear")
			{
				clearStudent();
			}
			else
			{
				clearStudent();
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
			}
		}

		private void txtSearchBMI_TextChanged(object sender, EventArgs e)
		{
			var studbmi = from s in db.Students
						  where s.Firstname.Contains(txtSearchBMI.Text) || s.Lastname.Contains(txtSearchBMI.Text)
						  select s;

			dgvBMI.Rows.Clear();
			foreach (var s in studbmi)
			{
				double bmi = 0;
				double height = 0;
				double weight = 0;
				string bmires = "";
				height = double.Parse(s.Height.ToString());
				weight = double.Parse(s.Weight.ToString());
				height = height / 3.28;
				bmi = Math.Round((weight / Math.Pow((height), 2)), 2);
				if (bmi < 15)
				{
					bmires = "Very severly underweight";
				}
				else if (bmi >= 15 && bmi <= 16)
				{
					bmires = "Severly underweight";
				}
				else if (bmi >= 16 && bmi <= 18.5)
				{
					bmires = "Underweight";
				}
				else if (bmi >= 18.5 && bmi <= 25)
				{
					bmires = "Normal";
				}
				else if (bmi >= 25 && bmi < 30)
				{
					bmires = "Overweight";
				}
				else if (bmi >= 30 && bmi < 35)
				{
					bmires = "Moderately obese";
				}
				else if (bmi >= 35 && bmi < 40)
				{
					bmires = "Severly Obese";
				}
				else if (bmi >= 40)
				{
					bmires = "Very severly obese";
				}
				dgvBMI.Rows.Add(s.Firstname + " " + s.Lastname, bmires);
			}
		}
	}
}
