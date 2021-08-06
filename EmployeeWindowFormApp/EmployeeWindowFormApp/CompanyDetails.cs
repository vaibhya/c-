using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWindowFormApp
{
    public partial class CompanyDetails : Form
    {
        public DataSet data;
        public CompanyDetails()
        {
            
            InitializeComponent();
            Load += new EventHandler(CompanyDetails_Load);

        }
        
        private void CompanyDetails_Load(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand empComm = new SqlCommand("select * from EMP",conn);
            SqlCommand deptComm = new SqlCommand("select * from DEPT",conn);

            SqlDataAdapter empDA = new SqlDataAdapter();
            empDA.SelectCommand = empComm;
            SqlDataAdapter deptDA = new SqlDataAdapter(deptComm);
            
            data = new DataSet();
            empDA.Fill(data, "empTable");
            deptDA.Fill(data, "deptTable");
            conn.Close();

        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            
            empGridView.DataSource = data.Tables["empTable"];
        }

        private void DeptBtn_Click(object sender, EventArgs e)
        {
            deptGridView.DataSource = data.Tables["deptTable"];
        }
    }
}
