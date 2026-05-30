namespace StudentManagementSystem
{
    public partial class lblTitle : Form
    {
        public lblTitle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (txtName.Text == "" || txtAge.Text == "" || cmbDepartment.Text == "")
                {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if (!int.TryParse(txtAge.Text, out _))
                {
                    MessageBox.Show("Age must be a number");
                    return;
                }
                string student =
                    "Name: " + txtName.Text +
                    " | Age: " + txtAge.Text +
                    " | Department: " + cmbDepartment.Text;
                if (lstStudents.Items.Contains(student))
                {
                    MessageBox.Show("Student already exists");
                    return;
                }
                lstStudents.Items.Add(student);
                lblTotalStudents.Text = "Total Students: " + lstStudents.Items.Count;

                MessageBox.Show("Student Added Successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
                lblTotalStudents.Text = "Total Students: " + lstStudents.Items.Count;

                MessageBox.Show("Student Deleted");
            }
            else
            {
                MessageBox.Show("Please select a student");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            cmbDepartment.ResetText();
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
