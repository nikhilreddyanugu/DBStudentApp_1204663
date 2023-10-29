using DBStudentApp_1204663.DataLayer;
using DBStudentApp_1204663.Models;

namespace DbStudentApp_1204663
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IRepository irep = new Repository();
            List<Course> CList = irep.GetAllCourses();
            cmbCourses.DataSource = CList;
            cmbCourses.DisplayMember = "CourseNum";
            cmbCourses.ValueMember = "CourseNum";
            cmbCourses.Refresh();

        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseNum = cmbCourses.SelectedValue.ToString();
            IRepository irep = new Repository();
            var EList = irep.GetEnrollment(courseNum);
            dg1.DataSource = EList;
            dg1.Refresh();
        }
    }
}