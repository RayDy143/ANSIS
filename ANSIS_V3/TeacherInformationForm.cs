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
    public partial class TeacherInformationForm : MetroFramework.Forms.MetroForm
    {
        public TeacherInformationForm()
        {
            InitializeComponent();
        }
		DataClassDataContext db = new DataClassDataContext();
        private void TeacherInformationForm_Load(object sender, EventArgs e)
        {
			displaySubject();
			var sub = from s in db.Subjects
					  select s;
			cmbSubject.DataSource = sub;
			cmbSubject.ValueMember = "SubjectID";
			cmbSubject.DisplayMember = "Subject1";
			displayTeacher();
			var ts = from t in db.TimeSchedules
					 select new {ID=t.TimeScheduleID,Time=t.TimeStart+t.TimeEnd};
			mcmbTimeStartENd.DataSource = ts;
			mcmbTimeStartENd.DisplayMember = "Time";
			mcmbTimeStartENd.ValueMember = "ID";
		}

        private void btnAddSched_Click(object sender, EventArgs e)
        {
            AddScheduleTimeForm astf = new AddScheduleTimeForm();
            astf.ShowDialog();
        }

        private void mtpTeacherProfile_Click(object sender, EventArgs e)
        {

        }
		public void displaySubject()
		{
			var sub = from s in db.Subjects
					  select s;
			dgvSubject.DataSource = sub;
		}
		public void clear()
		{
			if (btnCancel.Text == "Clear")
			{
				txtSubject.Clear();
			}else
			{
				txtSubject.Clear();
				btnCancel.Text = "Clear";
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (btnAdd.Text == "Add")
			{
				Subject sub = new Subject();
				sub.Subject1 = mtxtSubject.Text;
				db.Subjects.InsertOnSubmit(sub);
				db.SubmitChanges();
				MessageBox.Show("Success");
				clear();
				displaySubject();
			}else
			{
				var sub = db.Subjects.SingleOrDefault(x => x.SubjectID == id);
				sub.Subject1 = mtxtSubject.Text;
				MessageBox.Show("Success");
				db.SubmitChanges();
				btnAdd.Text = "Add";
				btnCancel.Text = "Clear";
				clear();
			}
			
		}
		int id = 0;
		private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = int.Parse(dgvSubject.CurrentRow.Cells[0].Value.ToString());
			mtxtSubject.Text = dgvSubject.CurrentRow.Cells[1].Value.ToString();
			btnAdd.Text = "Update";
		}

		private void mtxtSearchsub_TextChanged(object sender, EventArgs e)
		{
			var sub = from s in db.Subjects
					  where s.Subject1.Contains(mtxtSearchsub.Text)
					  select s;
			dgvSubject.DataSource = sub;
		}
		private void mbtnAdd_Click(object sender, EventArgs e)
		{
			if (mbtnAdd.Text == "Add")
			{
				Teacher teach = new Teacher();
				teach.Firstname = mtxtFname.Text;
				teach.Middlename = mtxtMname.Text;
				teach.Lastname = mtxtLname.Text;
				teach.ContactNumber = mtxtContact.Text;
				teach.Status = mcmbstatus.Text;
				teach.SubjectID = int.Parse(cmbSubject.SelectedValue.ToString());
				db.Teachers.InsertOnSubmit(teach);
				db.SubmitChanges();
				MessageBox.Show("Added");
				displayTeacher();
				clearTeacher();
			}
			else
			{
				var teach=db.Teachers.SingleOrDefault(x=>x.TeacherID== tid);
				teach.Firstname = mtxtFname.Text;
				teach.Middlename = mtxtMname.Text;
				teach.Lastname = mtxtLname.Text;
				teach.ContactNumber = mtxtContact.Text;
				teach.Status = mcmbstatus.Text;
				teach.SubjectID =int.Parse(cmbSubject.SelectedValue.ToString());
				db.SubmitChanges();
				MessageBox.Show("Updated");
				displayTeacher();
				clearTeacher();
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
			}
		}
		public void clearTeacher()
		{
			mtxtFname.Clear();
			mtxtMname.Clear();
			mtxtLname.Clear();
			mtxtContact.Clear();
			mcmbstatus.SelectedIndex = -1;
			cmbSubject.SelectedIndex = -1;
		}
		public void displayTeacher()
		{
			var teacher = from t in db.Teachers join s in db.Subjects on t.SubjectID equals s.SubjectID
						  select new{t.TeacherID,t.Firstname,t.Middlename,t.Lastname,t.ContactNumber,t.Status,s.Subject1};
			dgvTeacher.DataSource = teacher;
		}

		private void mtxtSearch_TextChanged(object sender, EventArgs e)
		{
			var teacher = from t in db.Teachers
						  join s in db.Subjects on t.SubjectID equals s.SubjectID
						  where t.Firstname.Contains(mtxtSearch.Text) || t.Lastname.Contains(mtxtSearch.Text)
						  select new { t.TeacherID, t.Firstname, t.Middlename, t.Lastname, t.ContactNumber, t.Status, s.Subject1 };
			dgvTeacher.DataSource = teacher;
		}
		int tid = 0;
		private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tid = int.Parse(dgvTeacher.CurrentRow.Cells[0].Value.ToString());
			mtxtFname.Text = dgvTeacher.CurrentRow.Cells[1].Value.ToString();
			mtxtMname.Text = dgvTeacher.CurrentRow.Cells[2].Value.ToString();
			mtxtLname.Text = dgvTeacher.CurrentRow.Cells[3].Value.ToString();
			mtxtContact.Text = dgvTeacher.CurrentRow.Cells[4].Value.ToString();
			mcmbstatus.Text = dgvTeacher.CurrentRow.Cells[5].Value.ToString();
			cmbSubject.Text = dgvTeacher.CurrentRow.Cells[6].Value.ToString();
			mbtnAdd.Text = "Update";
			mbtnClear.Text = "Cancel";
		}

		private void mbtnClear_Click(object sender, EventArgs e)
		{
			if (mbtnClear.Text == "Clear")
			{
				clearTeacher();
			}
			else
			{
				mbtnClear.Text = "Clear";
				mbtnAdd.Text = "Add";
				clearTeacher();
			}
		}

		private void mbtnSelectTeac_Click(object sender, EventArgs e)
		{
			var teacher = from t in db.Teachers
						  select new {t.TeacherID,t.Firstname,t.Middlename,t.Lastname};
			dgvSchedule.DataSource = teacher;
		}
		private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tid = int.Parse(dgvSchedule.CurrentRow.Cells[0].Value.ToString());
		}
	}
}
