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

namespace DataGenerator
{
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            SembawangSportEntities context = new SembawangSportEntities();
            string conS = "Data source = (local); Initial Catalog = SembawangSport; Integrated Security = SSPI";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand("select * from Members", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            cn.Open();
            da.Fill(ds, "Members");
            cn.Close();

            CRMem cr = new CRMem();
            cr.SetDataSource(ds);
            MemListView.ReportSource = cr;
        }
    }
}
