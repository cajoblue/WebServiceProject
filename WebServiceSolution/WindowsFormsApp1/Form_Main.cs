using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;


namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        public int valida = 0;

        public Form_Main()
        {
            InitializeComponent();            

            using (ServiceReference1.ServiceBloodCrowdClient client = new ServiceReference1.ServiceBloodCrowdClient())
            {
                foreach (var var_dador in client.GetDonors())
                {
                    String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress,
                        /*var_dador.Age.ToString(), var_dador.BloodType,
                        /*var_dador.GetIMC.ToString(),*/ var_dador.Guid };
                    var listviwItensViewItem = new ListViewItem(coluna);
                    listView1.Items.Add(listviwItensViewItem);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            
            
                listView1.Items.Clear();

                ServiceReference1.ServiceBloodCrowdClient client = new ServiceReference1.ServiceBloodCrowdClient();

                Donor[] list_encontrados = client.searchByName(btn_SearchName.Text);
                String[] coluna = null; int var_width = 70;

                if (searchName_tb.Text != "")
                {
                    foreach (var var_dador in list_encontrados)
                    {
                        coluna = new string[] { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, /*var_dador.Age.ToString(),*/ var_dador.BloodType, /*var_dador.getIMC().ToString(),*/ var_dador.Guid };
                        var listviwItensViewItem = new ListViewItem(coluna);
                        listView1.Items.Add(listviwItensViewItem);
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.columnHeader3.Width = var_width;
                    this.columnHeader4.Width = var_width;
                }

                /* if (searchName_tb.Text == "" || list_encontrados.Length == 0)
                 {
                     MessageBox.Show("Donor not found!");
                     List<Donor> newDador = client.GetDadoresResumo();
                     foreach (var var_dador in newDador)
                     {
                         coluna = new string[] { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.getIMC().ToString(), var_dador.Guid };
                         var listviwItensViewItem = new ListViewItem(coluna);
                         listView1.Items.Add(listviwItensViewItem);
                     }
                     listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                     this.columnHeader3.Width = var_width;
                     this.columnHeader4.Width = var_width;
                 }
                 */
            }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
