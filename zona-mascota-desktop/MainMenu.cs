using MaterialSkin;
using MaterialSkin.Controls;
using Models;
using Services;

namespace zona_mascota_desktop
{
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Customer customer = new Customer();
            dataGridCustomers.DataSource = customer.getCustomers();

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            District dist = new District();
            cbxCustomerLocation.DataSource = dist.getDistricts();
            cbxCustomerLocation.DisplayMember = "districtName";
            cbxCustomerLocation.ValueMember = "DistrictID";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void txtDNIClient_Click(object sender, EventArgs e)
        {

        }
        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            int district = cbxCustomerLocation.SelectedIndex+1;
            MessageBox.Show(cbxCustomerLocation.SelectedIndex.ToString());
            int dni = int.Parse(txtCustomerDNI.Text);
            string email = txtCustomerEmail.Text;
            int phone = int.Parse(txtCustomerPhone.Text);
            Customer customer = new Customer();
            customer.registerCustomer(name, district, email, dni, phone);
            dataGridCustomers.DataSource = customer.getCustomers();
            if (customer.status != 1)
            {
                lblMessage.Visible = true;
            }
        }

        private void dataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}