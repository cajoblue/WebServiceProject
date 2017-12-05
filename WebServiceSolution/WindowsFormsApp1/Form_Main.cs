using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            using (ServiceReference1.ServiceBloodCrowdClient client = new ServiceReference1.ServiceBloodCrowdClient())
            {
                foreach (var var_dador in client.GetDonors())
                {
                    String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress,
                        var_dador.Age.ToString(), var_dador.BloodType,
                        var_dador.GetIMC.ToString(), var_dador.Guid };
                    var listviwItensViewItem = new ListViewItem(coluna);
                    listView1.Items.Add(listviwItensViewItem);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
