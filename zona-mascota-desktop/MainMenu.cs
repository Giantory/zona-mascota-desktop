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

            Pet pet = new Pet();
            dataGridPets.DataSource = pet.getPets();

            Product product = new Product();
            dataGridProducts.DataSource = product.getProducts();

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            District dist = new District();
            Sex sex = new Sex();    
            Specie specie = new Specie();
            Customer customer = new Customer();
            Category category = new Category();
            Product product = new Product();

            cbxCustomerLocation.DataSource = dist.getDistricts();
            cbxCustomerLocation.DisplayMember = "districtName";
            cbxCustomerLocation.ValueMember = "DistrictID";

            cbxPetSex.DataSource = sex.getSexs();
            cbxPetSex.DisplayMember = "sexName";
            cbxPetSex.ValueMember = "SexID";

            cbxPetSpecie.DataSource = specie.getSpecies();
            cbxPetSpecie.DisplayMember = "specieName";
            cbxPetSpecie.ValueMember = "SpecieID";

            cbxPetOwner.DataSource = customer.getCustomers();
            cbxPetOwner.DisplayMember = "customerName";
            cbxPetOwner.ValueMember = "CustomerID";

            cbxProductCategory.DataSource = category.getCategories();
            cbxProductCategory.DisplayMember = "categoryName";
            cbxProductCategory.ValueMember = "CategoryID";

            cbxCustomerOrder.DataSource = customer.getCustomers();
            cbxCustomerOrder.DisplayMember = "customerName";
            cbxCustomerOrder.ValueMember = "CustomerID";

            cbxProducts.DataSource = product.getProducts();
            cbxProducts.DisplayMember = "productDescription";
            cbxProducts.ValueMember = "productID";
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
            int dni = int.Parse(txtCustomerDNI.Text);
            string email = txtCustomerEmail.Text;
            int phone = int.Parse(txtCustomerPhone.Text);
            Customer customer = new Customer();
            customer.registerCustomer(name, district, email, dni, phone);
            dataGridCustomers.DataSource = customer.getCustomers();
            lblOrderMsg.Text = customer.message;
            if (customer.status != 1)
            {
                lblCusMsg.Visible = true;
            }
        }

        private void dataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegisterPet_Click(object sender, EventArgs e)
        {
            string name = txtPetName.Text;
            int owner = cbxPetOwner.SelectedIndex + 1;
            int specie = cbxPetSpecie.SelectedIndex + 1;
            int sex = cbxPetSex.SelectedIndex + 1;
            double weight = double.Parse(txtPetWeight.Text);

            Pet pet = new Pet();

            pet.registerPet(owner, specie, sex, name, weight);
            dataGridPets.DataSource = pet.getPets();
            if (pet.status != 1)
            {
                lblPetMsg.Visible = true;
            }
        }

        private void tabProducts_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtProductSalePrice_Click(object sender, EventArgs e)
        {

        }

        private void txtProductPurchasePrice_Click(object sender, EventArgs e)
        {

        }

        private void cbxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductStock_Click(object sender, EventArgs e)
        {

        }

        private void txtProductDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            string description = txtProductDescription.Text;
            int category = cbxProductCategory.SelectedIndex + 1;
            int stock = int.Parse(txtProductStock.Text);
            double purchasePrice = double.Parse(txtProductPurchasePrice.Text);
            double salePrice = double.Parse(txtProductSalePrice.Text);

            Product product = new Product();
            product.registerProduct(description, category, purchasePrice, salePrice);
            dataGridProducts.DataSource = product.getProducts();
            if (product.status != 1)
            {
                lblPrdMsg.Visible = true;
            }


        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderDetailsForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegisterOrder_Click(object sender, EventArgs e)
        {
            int emp = 3;
            int customer = cbxCustomerOrder.SelectedIndex + 1;

            Order order = new Order();
            order.registerOrder(emp, customer);
            lblOrderMsg.Text = order.message;
            if (order.status != 1)
            {
                lblOrderMsg.Visible = true;
            }else
            {
                orderDetailsForm.Enabled = true;
                orderForm.Enabled = false;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int product = cbxProducts.SelectedIndex + 1;
            int quantity = int.Parse(txtQuantity.Text);

            OrderDetails od = new OrderDetails();
            od.registerOrderDetails(product, quantity);
            lblOdMsg.Text = od.message;
            if (od.status != 1)
            {
                lblOdMsg.Visible = true;
            }
            else
            {
                dataGridSummary.DataSource = od.showSummary();

            }

        }
    }
}