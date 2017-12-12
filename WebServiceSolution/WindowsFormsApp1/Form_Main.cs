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
        public ServiceReference1.ServiceBloodCrowdClient client = new ServiceReference1.ServiceBloodCrowdClient();
        
        public Form_Main()
        {
            InitializeComponent();
            valida += 1;
            searchBloodType_cbx.Items.AddRange(client.getBloodTypes().ToArray());
            searchBloodComp_cbx.Items.AddRange(client.getBloodTypes().ToArray());

            //Listar dadores quando o form principal é carregado.
            foreach (var var_dador in client.GetDonors())
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress,
                        var_dador.Age.ToString(), var_dador.BloodType,
                        var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //Botão pesquisar dador pelo Name.
        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            if (valida == 0)
            {
                MessageBox.Show("Escrever mensagem btn_SearchName_Click");
            }
            else
                //int var_width = 70;
                listView1.Items.Clear();
            Donor[] listDonor = client.searchByName(searchName_tb.Text);
            
            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //this.columnHeader3.Width = var_width;
            //this.columnHeader4.Width = var_width;

            if (btn_SearchName.Text == "" || listDonor.Length == 0)
            {
                String[] coluna = null;
                MessageBox.Show("Donor not found!");
                listDonor = client.GetDonors();
                foreach (var var_dador in listDonor)
                {
                    coluna = new string[] { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                    var listviwItensViewItem = new ListViewItem(coluna);
                    listView1.Items.Add(listviwItensViewItem);
                }
                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //this.columnHeader3.Width = var_width;
                //this.columnHeader4.Width = var_width;
            }
        }

        private void btn_SearchAge_Click(object sender, EventArgs e)
        {
            
        }

        //ComboBox pesquisar pelo BloodType
        private void searchBloodType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //int var_width = 70;
            Donor[] listDonor = client.searchByBloodType(searchBloodType_cbx.SelectedItem.ToString());

            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //this.columnHeader3.Width = var_width;
            //this.columnHeader4.Width = var_width;
        }

        private void searchBloodComp_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //int var_width = 70;
            Donor[] list_encontrados = client.GetDonorsByCompBlood(searchBloodComp_cbx.SelectedItem.ToString());
            foreach (var var_dador in list_encontrados)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //this.columnHeader3.Width = var_width;
            //this.columnHeader4.Width = var_width;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Método para abrir o formulário Form_NewDonor
        private void btn_AddDonor_Click(object sender, EventArgs e)
        {
            if (valida == 0)
            {
                MessageBox.Show("The data was not loaded." + "\n" +  "Maybe there is a problem connecting to the webserver.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form_NewDonor add = new Form_NewDonor();
                if (add.ShowDialog() == DialogResult.OK)
                {
                    listView1.Refresh();
                }
            }
        }

        private void asXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project: BloodCrowd Application & WebServer" + "\n" + "Students: Diogo Gaspar (5170277) and Celso Teixeira (5151804)" +
                             "\n" + "Class: Integration of Systems Information" + "\n" + "Year: 2017");
        }
    }
}
