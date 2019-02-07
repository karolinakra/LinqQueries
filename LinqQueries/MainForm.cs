using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MockData;

namespace LinqQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void GetResults_Click(object sender, EventArgs e)
        {


            ObjectRepo repo = new ObjectRepo();

            repo.Add(new Person { ID = 1000, Name = "XYZ" });
            dgv.DataSource = People.PeopleList.OrderByDescending(a => a.ID).ToList();
        }
    }
}
