using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenerator
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            SembawangSportEntities1 context = new SembawangSportEntities1();
            var q = from x in context.Facility1 group x by x.FacilityType into g select new { FacilityType = g.Key};
            

        }
    }
}
