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
            String [] bloodType_list = client.getBloodTypes();
            searchBloodType_cbx.Items.AddRange(bloodType_list);
            searchBloodComp_cbx.Items.AddRange(bloodType_list);

            //Listar dadores quando o form principal é carregado.
            foreach (var var_dador in client.GetDonors())
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress,
                        var_dador.Age.ToString(), var_dador.BloodType,
                        var_dador.Imc.ToString(), var_dador.Guid};
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
               
                listView1.Items.Clear();
            Donor[] listDonor = client.GetDonorsByName(searchName_tb.Text);
            
            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            

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
               
            }
        }

        private void btn_SearchAge_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            Donor[] listDonor = client.GetDonorsByAge((int)searchAge_UpDown.Value,(int) maxAge.Value);

            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
        }

        //ComboBox pesquisar pelo BloodType
        private void searchBloodType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            Donor[] listDonor = client.GetDonorsByBloodType(searchBloodType_cbx.SelectedItem.ToString());

            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
           
        }

        private void searchBloodComp_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
          
            Donor[] list_encontrados = client.GetDonorsByCompBlood(searchBloodComp_cbx.SelectedItem.ToString());
            foreach (var var_dador in list_encontrados)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
           
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
                    btn_UpdateList_Click(sender, e);
                }
            }
        }

        private void asXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;

            String[] list_guid = new String[checkedItems.Count];;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FileName = @"fileXportado.xml";
            int i = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem var_indice in checkedItems)
                {                    
                    list_guid[i]= var_indice.SubItems[6].Text;
                    i += 1;
                }

               bool valido = client.ExportToXml(list_guid, saveFileDialog1.FileName);
                if (valido)
                {
                    MessageBox.Show("File saved successfully!");
                }
                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project: BloodCrowd Application & WebServer" + "\n" + "Students: Diogo Gaspar (5170277) and Celso Teixeira (5151804)" +
                             "\n" + "Class: Integration of Systems Information" + "\n" + "Year: 2017");
        }

        private void btn_SearchImc_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            Donor[] listDonor = client.GetDonorsByIMC((double)minIMC.Value,(double)maxIMC.Value);

            foreach (var var_dador in listDonor)
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress, var_dador.Age.ToString(), var_dador.BloodType, var_dador.Imc.ToString(), var_dador.Guid };
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
        }

        private void btn_DeleteDonor_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
            String[] list_guis = new String[checkedItems.Count];
            int i = 0;
            foreach (ListViewItem var_indice in checkedItems)
            {
                list_guis[i]=var_indice.SubItems[6].Text;
                i += 1;
            }

            bool valida = client.RemoveDonor(list_guis);

            if (valida)
            {
                MessageBox.Show("Donor removed successfully!");
                btn_UpdateList_Click(sender,  e);
            }
            else
            {
                MessageBox.Show("The process failed!");
                btn_UpdateList_Click(sender, e);
            }
        }

        private void btn_DonorDetails_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var var_dador in client.GetDonors())
            {
                String[] coluna = { var_dador.GivenName, var_dador.City, var_dador.EmailAddress,
                        var_dador.Age.ToString(), var_dador.BloodType,
                        var_dador.Imc.ToString(), var_dador.Guid};
                var listviwItensViewItem = new ListViewItem(coluna);
                listView1.Items.Add(listviwItensViewItem);
            }
            listView1.Refresh();
            
        }
    }
}
