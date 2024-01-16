namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        DepartmentService departmentService;
        List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();
            var employeeList = employeeService.GetEmployees();
            listBox2.DataSource = employeeList;
            listBox2.DisplayMember = "name";

            departmentService = new DepartmentService();
            departmentService.createConnection();
            var departmentList = departmentService.GetDepartments();
            listBox1.DataSource = departmentList;
            listBox1.DisplayMember = "name";

            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = "name";



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department department = (Department)comboBox1.SelectedItem;
            var employeeListByDepartment = employeeService.GetEmployeesByDepartmentId(department.id);
            listBox3.DataSource = employeeListByDepartment;
            listBox3.DisplayMember = "name";

            var managersListByDepartment = employeeService.GetManagersByDepartmentId(department.id);
            listBox4.DataSource = managersListByDepartment;
            listBox4.DisplayMember = "name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}