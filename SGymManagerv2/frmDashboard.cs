using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymManagerv2
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
            //Count Total Member
            string sql = "SELECT * FROM tblMember";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Member"); //Datatable
            lbcountmember.Text = ds.Tables[0].Rows.Count.ToString();
            //gridMem.DataSource = ds.Tables["Member"]

            //Count Total Employee
            string sql1 = "SELECT * FROM tblEmployee";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, connection);
            da1.Fill(ds, "Employee"); //Datatable
            lbCountTrainer.Text = ds.Tables[0].Rows.Count.ToString();
            //gridMem.DataSource = ds.Tables["Member"]


            //Count Total Employee
            /*string sql2 = "SELECT SUM (CoursePrice) FROM tblApply";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, connection);
            da2.Fill(ds, "Apply"); //Datatable
            lbCountTrainer.Text = ds.Tables[6].Rows.ToString();*/
        }
    }
}
