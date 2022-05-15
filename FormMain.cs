using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsAppTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static string TESTConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TEST;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            TESTConnectionString = System.IO.File.ReadAllText(Application.StartupPath + @"\Config.txt");

            this.t_ZayavkiTableAdapter.Fill(this.tESTDataSet.T_Zayavki);
            this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv1 = (DataRowView)tClientsBindingSource[e.RowIndex];
            t_ZayavkiBindingSource.Filter = "[ID_Client]=" + drv1["ID_Client"].ToString();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            foreach (DataRowView item in tClientsBindingSource)
            {
                comboBox1.Items.Add(item["Naimenovanie"].ToString());
            }
        }

        private int getClientIdByName(string ClientName)
        {
            int n = tClientsBindingSource.Find("Naimenovanie", ClientName);
            DataRowView item = (DataRowView)tClientsBindingSource[n];
            return (int)item["ID_Client"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            t_ZayavkiBindingSource2.Filter = comboBox1.SelectedIndex < 1 ? "" : "[ID_Client]=" + getClientIdByName(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditClients FormEditClients1 = new FormEditClients();
            FormEditClients1.Text = "Добавление клиента";
            FormEditClients1.t_SferyDeyatelnostiTableAdapter.Fill(FormEditClients1.tESTDataSet.T_SferyDeyatelnosti);

            if (FormEditClients1.ShowDialog() == DialogResult.OK)
            {
                t_ClientsTableAdapter.Adapter.InsertCommand.Parameters["@Naimenovanie"].Value = FormEditClients1.textBoxNaimenovanie.Text;
                t_ClientsTableAdapter.Adapter.InsertCommand.Parameters["@INN"].Value = FormEditClients1.textBoxINN.Text;
                t_ClientsTableAdapter.Adapter.InsertCommand.Parameters["@Primechanie"].Value = FormEditClients1.textBoxPrimechanie.Text;
                t_ClientsTableAdapter.Adapter.InsertCommand.Parameters["@ID_SferyDeyatelnosti"].Value = FormEditClients1.comboBoxSferyDeyatelnosti.SelectedValue;
                t_ClientsTableAdapter.Adapter.InsertCommand.Connection.Open();
                t_ClientsTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                t_ClientsTableAdapter.Adapter.InsertCommand.Connection.Close();
                this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditClients FormEditClients1 = new FormEditClients();
            FormEditClients1.Text = "Редактирование клиента";
            FormEditClients1.textBoxNaimenovanie.Text = ((DataRowView)tClientsBindingSource.Current)["Naimenovanie"].ToString();
            FormEditClients1.textBoxINN.Text = ((DataRowView)tClientsBindingSource.Current)["INN"].ToString();
            FormEditClients1.textBoxPrimechanie.Text = ((DataRowView)tClientsBindingSource.Current)["Primechanie"].ToString();

            FormEditClients1.t_SferyDeyatelnostiTableAdapter.Fill(FormEditClients1.tESTDataSet.T_SferyDeyatelnosti);

            FormEditClients1.comboBoxSferyDeyatelnosti.SelectedValue = ((DataRowView)tClientsBindingSource.Current)["ID_SferyDeyatelnosti"];

            if (FormEditClients1.ShowDialog() == DialogResult.OK)
            {
                t_ClientsTableAdapter.Adapter.UpdateCommand.Parameters["@Naimenovanie"].Value = FormEditClients1.textBoxNaimenovanie.Text;
                t_ClientsTableAdapter.Adapter.UpdateCommand.Parameters["@INN"].Value = FormEditClients1.textBoxINN.Text;
                t_ClientsTableAdapter.Adapter.UpdateCommand.Parameters["@Primechanie"].Value = FormEditClients1.textBoxPrimechanie.Text;
                t_ClientsTableAdapter.Adapter.UpdateCommand.Parameters["@ID_SferyDeyatelnosti"].Value = FormEditClients1.comboBoxSferyDeyatelnosti.SelectedValue;
                t_ClientsTableAdapter.Adapter.UpdateCommand.Parameters["@ID_Client"].Value = ((DataRowView)tClientsBindingSource.Current)["ID_Client"].ToString();
                t_ClientsTableAdapter.Adapter.UpdateCommand.Connection.Open();
                t_ClientsTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                t_ClientsTableAdapter.Adapter.UpdateCommand.Connection.Close();
                this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_ClientsTableAdapter.Adapter.DeleteCommand.Parameters["@ID_Client"].Value = ((DataRowView)tClientsBindingSource.Current)["ID_Client"].ToString();
            t_ClientsTableAdapter.Adapter.DeleteCommand.Connection.Open();
            t_ClientsTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
            t_ClientsTableAdapter.Adapter.DeleteCommand.Connection.Close();
            this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEditZayavki FormEditZayavki1 = new FormEditZayavki();
            FormEditZayavki1.Text = "Редактирование заявки";

            FormEditZayavki1.dtPickerDate.Value = (DateTime)((DataRowView)t_ZayavkiBindingSource.Current)["DataZayavki"];
            FormEditZayavki1.textBoxNaimenovanie.Text = ((DataRowView)t_ZayavkiBindingSource.Current)["NaimenovanieRabot"].ToString();
            FormEditZayavki1.textBoxOpisanie.Text = ((DataRowView)t_ZayavkiBindingSource.Current)["OpisanieRabot"].ToString();

            FormEditZayavki1.t_StatusyTableAdapter.Fill(FormEditZayavki1.tESTDataSet.T_Statusy);

            FormEditZayavki1.comboBoxStatus.SelectedValue = ((DataRowView)t_ZayavkiBindingSource.Current)["ID_Status"];

            if (FormEditZayavki1.ShowDialog() == DialogResult.OK)
            {
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@DataZayavki"].Value = FormEditZayavki1.dtPickerDate.Value.Date;
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@NaimenovanieRabot"].Value = FormEditZayavki1.textBoxNaimenovanie.Text;
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@OpisanieRabot"].Value = FormEditZayavki1.textBoxOpisanie.Text;
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@ID_Status"].Value = FormEditZayavki1.comboBoxStatus.SelectedValue;
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@ID_Client"].Value = ((DataRowView)tClientsBindingSource.Current)["ID_Client"].ToString();
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Parameters["@ID_Zayavki"].Value = ((DataRowView)t_ZayavkiBindingSource.Current)["ID_Zayavki"].ToString();
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Connection.Open();
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                t_ZayavkiTableAdapter.Adapter.UpdateCommand.Connection.Close();
                this.t_ZayavkiTableAdapter.Fill(this.tESTDataSet.T_Zayavki);
                this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = dataGridView1.RowCount > 0;
            button3.Enabled = dataGridView1.RowCount > 0;
        }

        private void t_ZayavkiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            button4.Enabled = t_ZayavkiDataGridView.RowCount > 0;
            button5.Enabled = t_ZayavkiDataGridView.RowCount > 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormEditZayavki FormEditZayavki1 = new FormEditZayavki();
            FormEditZayavki1.Text = "Добавление заявки";
            FormEditZayavki1.t_StatusyTableAdapter.Fill(FormEditZayavki1.tESTDataSet.T_Statusy);

            if (FormEditZayavki1.ShowDialog() == DialogResult.OK)
            {
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Parameters["@DataZayavki"].Value = FormEditZayavki1.dtPickerDate.Value.Date;
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Parameters["@NaimenovanieRabot"].Value = FormEditZayavki1.textBoxNaimenovanie.Text;
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Parameters["@OpisanieRabot"].Value = FormEditZayavki1.textBoxOpisanie.Text;
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Parameters["@ID_Status"].Value = FormEditZayavki1.comboBoxStatus.SelectedValue;
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Parameters["@ID_Client"].Value = ((DataRowView)tClientsBindingSource.Current)["ID_Client"].ToString();
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Connection.Open();
                t_ZayavkiTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                t_ZayavkiTableAdapter.Adapter.InsertCommand.Connection.Close();
                this.t_ZayavkiTableAdapter.Fill(this.tESTDataSet.T_Zayavki);
                this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_ZayavkiTableAdapter.Adapter.DeleteCommand.Parameters["@ID_Zayavki"].Value = ((DataRowView)t_ZayavkiBindingSource.Current)["ID_Zayavki"].ToString();
            t_ZayavkiTableAdapter.Adapter.DeleteCommand.Connection.Open();
            t_ZayavkiTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
            t_ZayavkiTableAdapter.Adapter.DeleteCommand.Connection.Close();
            this.t_ZayavkiTableAdapter.Fill(this.tESTDataSet.T_Zayavki);
            this.t_ClientsTableAdapter.Fill(this.tESTDataSet.T_Clients);
        }
    }
}
