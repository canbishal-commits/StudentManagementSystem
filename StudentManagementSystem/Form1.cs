namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtName.Text == "" || txtAge.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    string student =
                        "Name: " + txtName.Text +
                        " | Age: " + txtAge.Text +
                        " | Department: " + cmbDepartment.Text;

                    lstStudents.Items.Add(student);

                    MessageBox.Show("Student Added Successfully");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                string student =
                    "Name: " + txtName.Text +
                    " | Age: " + txtAge.Text +
                    " | Department: " + cmbDepartment.Text;

                lstStudents.Items.Add(student);

                MessageBox.Show("Student Added Successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);

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
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
