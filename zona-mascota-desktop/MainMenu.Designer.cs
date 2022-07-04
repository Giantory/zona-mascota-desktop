namespace zona_mascota_desktop
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txtCustomerPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCusMsg = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegisterClient = new MaterialSkin.Controls.MaterialButton();
            this.txtCustomerEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxCustomerLocation = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCustomerDNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.tabMascotas = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblPetMsg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPetName = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxPetOwner = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegisterPet = new MaterialSkin.Controls.MaterialButton();
            this.txtPetWeight = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxPetSpecie = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxPetSex = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridPets = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txtAlmQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxAlmProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblPrdMsg = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductPurchasePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegisterProduct = new MaterialSkin.Controls.MaterialButton();
            this.txtProductStock = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductSalePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.orderDetailsForm = new MaterialSkin.Controls.MaterialCard();
            this.lblOdMsg = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbxProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.orderForm = new MaterialSkin.Controls.MaterialCard();
            this.lblOrderMsg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxCustomerOrder = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegisterOrder = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridSummary = new System.Windows.Forms.DataGridView();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.tabMascotas.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPets)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.tabSale.SuspendLayout();
            this.orderDetailsForm.SuspendLayout();
            this.orderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabClients);
            this.materialTabControl1.Controls.Add(this.tabMascotas);
            this.materialTabControl1.Controls.Add(this.tabProducts);
            this.materialTabControl1.Controls.Add(this.tabSale);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 85);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1582, 855);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.materialCard2);
            this.tabClients.Controls.Add(this.materialLabel2);
            this.tabClients.Controls.Add(this.dataGridCustomers);
            this.tabClients.ImageKey = "user_png_64.png";
            this.tabClients.Location = new System.Drawing.Point(4, 39);
            this.tabClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClients.Size = new System.Drawing.Size(1574, 812);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Clientes";
            this.tabClients.UseVisualStyleBackColor = true;
            this.tabClients.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txtCustomerPhone);
            this.materialCard2.Controls.Add(this.lblCusMsg);
            this.materialCard2.Controls.Add(this.btnRegisterClient);
            this.materialCard2.Controls.Add(this.txtCustomerEmail);
            this.materialCard2.Controls.Add(this.cbxCustomerLocation);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.txtCustomerName);
            this.materialCard2.Controls.Add(this.txtCustomerDNI);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(833, 81);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(631, 386);
            this.materialCard2.TabIndex = 26;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.AnimateReadOnly = true;
            this.txtCustomerPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomerPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerPhone.Depth = 0;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerPhone.HelperText = "Nombre";
            this.txtCustomerPhone.HideSelection = true;
            this.txtCustomerPhone.Hint = "Celular";
            this.txtCustomerPhone.LeadingIcon = null;
            this.txtCustomerPhone.Location = new System.Drawing.Point(384, 153);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerPhone.MaxLength = 32767;
            this.txtCustomerPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.PasswordChar = '\0';
            this.txtCustomerPhone.PrefixSuffixText = null;
            this.txtCustomerPhone.ReadOnly = false;
            this.txtCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerPhone.SelectedText = "";
            this.txtCustomerPhone.SelectionLength = 0;
            this.txtCustomerPhone.SelectionStart = 0;
            this.txtCustomerPhone.ShortcutsEnabled = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(208, 48);
            this.txtCustomerPhone.TabIndex = 19;
            this.txtCustomerPhone.TabStop = false;
            this.txtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerPhone.TrailingIcon = null;
            this.txtCustomerPhone.UseSystemPasswordChar = false;
            // 
            // lblCusMsg
            // 
            this.lblCusMsg.AutoSize = true;
            this.lblCusMsg.Depth = 0;
            this.lblCusMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCusMsg.Location = new System.Drawing.Point(19, 289);
            this.lblCusMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCusMsg.Name = "lblCusMsg";
            this.lblCusMsg.Size = new System.Drawing.Size(152, 19);
            this.lblCusMsg.TabIndex = 18;
            this.lblCusMsg.Text = "Information Message";
            this.lblCusMsg.Visible = false;
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterClient.Depth = 0;
            this.btnRegisterClient.HighEmphasis = true;
            this.btnRegisterClient.Icon = null;
            this.btnRegisterClient.Location = new System.Drawing.Point(19, 328);
            this.btnRegisterClient.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnRegisterClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterClient.Size = new System.Drawing.Size(99, 36);
            this.btnRegisterClient.TabIndex = 3;
            this.btnRegisterClient.Text = "Registrar";
            this.btnRegisterClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterClient.UseAccentColor = false;
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AnimateReadOnly = false;
            this.txtCustomerEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerEmail.Depth = 0;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerEmail.HelperText = "Nombre";
            this.txtCustomerEmail.HideSelection = true;
            this.txtCustomerEmail.Hint = "Email";
            this.txtCustomerEmail.LeadingIcon = null;
            this.txtCustomerEmail.Location = new System.Drawing.Point(19, 153);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerEmail.MaxLength = 32767;
            this.txtCustomerEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.PasswordChar = '\0';
            this.txtCustomerEmail.PrefixSuffixText = null;
            this.txtCustomerEmail.ReadOnly = false;
            this.txtCustomerEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerEmail.SelectedText = "";
            this.txtCustomerEmail.SelectionLength = 0;
            this.txtCustomerEmail.SelectionStart = 0;
            this.txtCustomerEmail.ShortcutsEnabled = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(359, 48);
            this.txtCustomerEmail.TabIndex = 6;
            this.txtCustomerEmail.TabStop = false;
            this.txtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerEmail.TrailingIcon = null;
            this.txtCustomerEmail.UseSystemPasswordChar = false;
            // 
            // cbxCustomerLocation
            // 
            this.cbxCustomerLocation.AutoResize = false;
            this.cbxCustomerLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCustomerLocation.Depth = 0;
            this.cbxCustomerLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCustomerLocation.DropDownHeight = 174;
            this.cbxCustomerLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerLocation.DropDownWidth = 121;
            this.cbxCustomerLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCustomerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCustomerLocation.FormattingEnabled = true;
            this.cbxCustomerLocation.Hint = "Distrito";
            this.cbxCustomerLocation.IntegralHeight = false;
            this.cbxCustomerLocation.ItemHeight = 43;
            this.cbxCustomerLocation.Items.AddRange(new object[] {
            "Cercado de Lima",
            "Los Olivos",
            "San Martín de Porres"});
            this.cbxCustomerLocation.Location = new System.Drawing.Point(19, 222);
            this.cbxCustomerLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCustomerLocation.MaxDropDownItems = 4;
            this.cbxCustomerLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCustomerLocation.Name = "cbxCustomerLocation";
            this.cbxCustomerLocation.Size = new System.Drawing.Size(207, 49);
            this.cbxCustomerLocation.StartIndex = 0;
            this.cbxCustomerLocation.TabIndex = 7;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(19, 28);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(251, 41);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Registrar Cliente";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AnimateReadOnly = false;
            this.txtCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.HideSelection = true;
            this.txtCustomerName.Hint = "Nombre";
            this.txtCustomerName.LeadingIcon = null;
            this.txtCustomerName.Location = new System.Drawing.Point(19, 86);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PrefixSuffixText = null;
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(359, 48);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TabStop = false;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.TrailingIcon = null;
            this.txtCustomerName.UseSystemPasswordChar = false;
            // 
            // txtCustomerDNI
            // 
            this.txtCustomerDNI.AnimateReadOnly = true;
            this.txtCustomerDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomerDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerDNI.Depth = 0;
            this.txtCustomerDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerDNI.HelperText = "Nombre";
            this.txtCustomerDNI.HideSelection = true;
            this.txtCustomerDNI.Hint = "DNI";
            this.txtCustomerDNI.LeadingIcon = null;
            this.txtCustomerDNI.Location = new System.Drawing.Point(384, 86);
            this.txtCustomerDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerDNI.MaxLength = 32767;
            this.txtCustomerDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerDNI.Name = "txtCustomerDNI";
            this.txtCustomerDNI.PasswordChar = '\0';
            this.txtCustomerDNI.PrefixSuffixText = null;
            this.txtCustomerDNI.ReadOnly = false;
            this.txtCustomerDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerDNI.SelectedText = "";
            this.txtCustomerDNI.SelectionLength = 0;
            this.txtCustomerDNI.SelectionStart = 0;
            this.txtCustomerDNI.ShortcutsEnabled = true;
            this.txtCustomerDNI.Size = new System.Drawing.Size(208, 48);
            this.txtCustomerDNI.TabIndex = 5;
            this.txtCustomerDNI.TabStop = false;
            this.txtCustomerDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerDNI.TrailingIcon = null;
            this.txtCustomerDNI.UseSystemPasswordChar = false;
            this.txtCustomerDNI.Click += new System.EventHandler(this.txtDNIClient_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(21, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 41);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Clientes";
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(21, 81);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.RowTemplate.Height = 29;
            this.dataGridCustomers.Size = new System.Drawing.Size(795, 566);
            this.dataGridCustomers.TabIndex = 8;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellContentClick);
            // 
            // tabMascotas
            // 
            this.tabMascotas.Controls.Add(this.materialCard1);
            this.tabMascotas.Controls.Add(this.materialLabel3);
            this.tabMascotas.Controls.Add(this.dataGridPets);
            this.tabMascotas.ImageKey = "huella_png_64.png";
            this.tabMascotas.Location = new System.Drawing.Point(4, 39);
            this.tabMascotas.Name = "tabMascotas";
            this.tabMascotas.Size = new System.Drawing.Size(1574, 812);
            this.tabMascotas.TabIndex = 2;
            this.tabMascotas.Text = "Mascotas";
            this.tabMascotas.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblPetMsg);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txtPetName);
            this.materialCard1.Controls.Add(this.cbxPetOwner);
            this.materialCard1.Controls.Add(this.btnRegisterPet);
            this.materialCard1.Controls.Add(this.txtPetWeight);
            this.materialCard1.Controls.Add(this.cbxPetSpecie);
            this.materialCard1.Controls.Add(this.cbxPetSex);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(826, 103);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(664, 300);
            this.materialCard1.TabIndex = 24;
            // 
            // lblPetMsg
            // 
            this.lblPetMsg.AutoSize = true;
            this.lblPetMsg.Depth = 0;
            this.lblPetMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPetMsg.Location = new System.Drawing.Point(17, 201);
            this.lblPetMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPetMsg.Name = "lblPetMsg";
            this.lblPetMsg.Size = new System.Drawing.Size(152, 19);
            this.lblPetMsg.TabIndex = 24;
            this.lblPetMsg.Text = "Information Message";
            this.lblPetMsg.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(17, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(281, 41);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "Registrar Mascota";
            // 
            // txtPetName
            // 
            this.txtPetName.AnimateReadOnly = false;
            this.txtPetName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPetName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPetName.Depth = 0;
            this.txtPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPetName.HelperText = "Nombre";
            this.txtPetName.HideSelection = true;
            this.txtPetName.Hint = "Nombre";
            this.txtPetName.LeadingIcon = null;
            this.txtPetName.Location = new System.Drawing.Point(17, 68);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetName.MaxLength = 32767;
            this.txtPetName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.PasswordChar = '\0';
            this.txtPetName.PrefixSuffixText = null;
            this.txtPetName.ReadOnly = false;
            this.txtPetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPetName.SelectedText = "";
            this.txtPetName.SelectionLength = 0;
            this.txtPetName.SelectionStart = 0;
            this.txtPetName.ShortcutsEnabled = true;
            this.txtPetName.Size = new System.Drawing.Size(297, 48);
            this.txtPetName.TabIndex = 14;
            this.txtPetName.TabStop = false;
            this.txtPetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPetName.TrailingIcon = null;
            this.txtPetName.UseSystemPasswordChar = false;
            // 
            // cbxPetOwner
            // 
            this.cbxPetOwner.AutoResize = false;
            this.cbxPetOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPetOwner.Depth = 0;
            this.cbxPetOwner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPetOwner.DropDownHeight = 174;
            this.cbxPetOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPetOwner.DropDownWidth = 121;
            this.cbxPetOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPetOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPetOwner.FormattingEnabled = true;
            this.cbxPetOwner.Hint = "Dueño";
            this.cbxPetOwner.IntegralHeight = false;
            this.cbxPetOwner.ItemHeight = 43;
            this.cbxPetOwner.Location = new System.Drawing.Point(320, 67);
            this.cbxPetOwner.MaxDropDownItems = 4;
            this.cbxPetOwner.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPetOwner.Name = "cbxPetOwner";
            this.cbxPetOwner.Size = new System.Drawing.Size(309, 49);
            this.cbxPetOwner.StartIndex = 0;
            this.cbxPetOwner.TabIndex = 17;
            this.cbxPetOwner.Tag = "";
            // 
            // btnRegisterPet
            // 
            this.btnRegisterPet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterPet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterPet.Depth = 0;
            this.btnRegisterPet.HighEmphasis = true;
            this.btnRegisterPet.Icon = null;
            this.btnRegisterPet.Location = new System.Drawing.Point(17, 242);
            this.btnRegisterPet.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnRegisterPet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterPet.Name = "btnRegisterPet";
            this.btnRegisterPet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterPet.Size = new System.Drawing.Size(99, 36);
            this.btnRegisterPet.TabIndex = 15;
            this.btnRegisterPet.Text = "Registrar";
            this.btnRegisterPet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterPet.UseAccentColor = false;
            this.btnRegisterPet.UseVisualStyleBackColor = true;
            this.btnRegisterPet.Click += new System.EventHandler(this.btnRegisterPet_Click);
            // 
            // txtPetWeight
            // 
            this.txtPetWeight.AnimateReadOnly = false;
            this.txtPetWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPetWeight.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPetWeight.Depth = 0;
            this.txtPetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPetWeight.HelperText = "Nombre";
            this.txtPetWeight.HideSelection = true;
            this.txtPetWeight.Hint = "Peso";
            this.txtPetWeight.LeadingIcon = null;
            this.txtPetWeight.Location = new System.Drawing.Point(418, 124);
            this.txtPetWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetWeight.MaxLength = 32767;
            this.txtPetWeight.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPetWeight.Name = "txtPetWeight";
            this.txtPetWeight.PasswordChar = '\0';
            this.txtPetWeight.PrefixSuffixText = null;
            this.txtPetWeight.ReadOnly = false;
            this.txtPetWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPetWeight.SelectedText = "";
            this.txtPetWeight.SelectionLength = 0;
            this.txtPetWeight.SelectionStart = 0;
            this.txtPetWeight.ShortcutsEnabled = true;
            this.txtPetWeight.Size = new System.Drawing.Size(124, 48);
            this.txtPetWeight.TabIndex = 20;
            this.txtPetWeight.TabStop = false;
            this.txtPetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPetWeight.TrailingIcon = null;
            this.txtPetWeight.UseSystemPasswordChar = false;
            // 
            // cbxPetSpecie
            // 
            this.cbxPetSpecie.AutoResize = false;
            this.cbxPetSpecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPetSpecie.Depth = 0;
            this.cbxPetSpecie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPetSpecie.DropDownHeight = 174;
            this.cbxPetSpecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPetSpecie.DropDownWidth = 121;
            this.cbxPetSpecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPetSpecie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPetSpecie.FormattingEnabled = true;
            this.cbxPetSpecie.Hint = "Especie";
            this.cbxPetSpecie.IntegralHeight = false;
            this.cbxPetSpecie.ItemHeight = 43;
            this.cbxPetSpecie.Location = new System.Drawing.Point(17, 123);
            this.cbxPetSpecie.MaxDropDownItems = 4;
            this.cbxPetSpecie.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPetSpecie.Name = "cbxPetSpecie";
            this.cbxPetSpecie.Size = new System.Drawing.Size(192, 49);
            this.cbxPetSpecie.StartIndex = 0;
            this.cbxPetSpecie.TabIndex = 19;
            this.cbxPetSpecie.Tag = "";
            // 
            // cbxPetSex
            // 
            this.cbxPetSex.AutoResize = false;
            this.cbxPetSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPetSex.Depth = 0;
            this.cbxPetSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPetSex.DropDownHeight = 174;
            this.cbxPetSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPetSex.DropDownWidth = 121;
            this.cbxPetSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPetSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPetSex.FormattingEnabled = true;
            this.cbxPetSex.Hint = "Sexo";
            this.cbxPetSex.IntegralHeight = false;
            this.cbxPetSex.ItemHeight = 43;
            this.cbxPetSex.Location = new System.Drawing.Point(215, 123);
            this.cbxPetSex.MaxDropDownItems = 4;
            this.cbxPetSex.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPetSex.Name = "cbxPetSex";
            this.cbxPetSex.Size = new System.Drawing.Size(197, 49);
            this.cbxPetSex.StartIndex = 0;
            this.cbxPetSex.TabIndex = 18;
            this.cbxPetSex.Tag = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(14, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(153, 41);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Mascotas";
            // 
            // dataGridPets
            // 
            this.dataGridPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPets.Location = new System.Drawing.Point(14, 103);
            this.dataGridPets.Name = "dataGridPets";
            this.dataGridPets.RowHeadersWidth = 51;
            this.dataGridPets.RowTemplate.Height = 29;
            this.dataGridPets.Size = new System.Drawing.Size(795, 414);
            this.dataGridPets.TabIndex = 21;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.materialCard4);
            this.tabProducts.Controls.Add(this.materialCard3);
            this.tabProducts.Controls.Add(this.materialLabel1);
            this.tabProducts.Controls.Add(this.dataGridProducts);
            this.tabProducts.ImageKey = "product_png_64.png";
            this.tabProducts.Location = new System.Drawing.Point(4, 39);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Size = new System.Drawing.Size(1574, 812);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Productos";
            this.tabProducts.UseVisualStyleBackColor = true;
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialButton3);
            this.materialCard4.Controls.Add(this.materialLabel10);
            this.materialCard4.Controls.Add(this.materialButton2);
            this.materialCard4.Controls.Add(this.txtAlmQuantity);
            this.materialCard4.Controls.Add(this.cbxAlmProduct);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(807, 391);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(633, 284);
            this.materialCard4.TabIndex = 20;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(113, 167);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(73, 36);
            this.materialButton3.TabIndex = 19;
            this.materialButton3.Text = "Quitar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel10.Location = new System.Drawing.Point(19, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(293, 41);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Actualizar almacén";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(17, 167);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(74, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "Añadir";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // txtAlmQuantity
            // 
            this.txtAlmQuantity.AnimateReadOnly = false;
            this.txtAlmQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAlmQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAlmQuantity.Depth = 0;
            this.txtAlmQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlmQuantity.HideSelection = true;
            this.txtAlmQuantity.Hint = "Cantidad";
            this.txtAlmQuantity.LeadingIcon = null;
            this.txtAlmQuantity.Location = new System.Drawing.Point(245, 75);
            this.txtAlmQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlmQuantity.MaxLength = 32767;
            this.txtAlmQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlmQuantity.Name = "txtAlmQuantity";
            this.txtAlmQuantity.PasswordChar = '\0';
            this.txtAlmQuantity.PrefixSuffixText = null;
            this.txtAlmQuantity.ReadOnly = false;
            this.txtAlmQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlmQuantity.SelectedText = "";
            this.txtAlmQuantity.SelectionLength = 0;
            this.txtAlmQuantity.SelectionStart = 0;
            this.txtAlmQuantity.ShortcutsEnabled = true;
            this.txtAlmQuantity.Size = new System.Drawing.Size(131, 48);
            this.txtAlmQuantity.TabIndex = 10;
            this.txtAlmQuantity.TabStop = false;
            this.txtAlmQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAlmQuantity.TrailingIcon = null;
            this.txtAlmQuantity.UseSystemPasswordChar = false;
            // 
            // cbxAlmProduct
            // 
            this.cbxAlmProduct.AutoResize = false;
            this.cbxAlmProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxAlmProduct.Depth = 0;
            this.cbxAlmProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxAlmProduct.DropDownHeight = 174;
            this.cbxAlmProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlmProduct.DropDownWidth = 121;
            this.cbxAlmProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxAlmProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxAlmProduct.FormattingEnabled = true;
            this.cbxAlmProduct.Hint = "Producto";
            this.cbxAlmProduct.IntegralHeight = false;
            this.cbxAlmProduct.ItemHeight = 43;
            this.cbxAlmProduct.Location = new System.Drawing.Point(17, 74);
            this.cbxAlmProduct.MaxDropDownItems = 4;
            this.cbxAlmProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxAlmProduct.Name = "cbxAlmProduct";
            this.cbxAlmProduct.Size = new System.Drawing.Size(212, 49);
            this.cbxAlmProduct.StartIndex = 0;
            this.cbxAlmProduct.TabIndex = 11;
            this.cbxAlmProduct.Tag = "";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblPrdMsg);
            this.materialCard3.Controls.Add(this.txtProductPurchasePrice);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Controls.Add(this.txtProductDescription);
            this.materialCard3.Controls.Add(this.btnRegisterProduct);
            this.materialCard3.Controls.Add(this.txtProductStock);
            this.materialCard3.Controls.Add(this.txtProductSalePrice);
            this.materialCard3.Controls.Add(this.cbxProductCategory);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(807, 69);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(633, 310);
            this.materialCard3.TabIndex = 19;
            // 
            // lblPrdMsg
            // 
            this.lblPrdMsg.AutoSize = true;
            this.lblPrdMsg.Depth = 0;
            this.lblPrdMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrdMsg.Location = new System.Drawing.Point(19, 214);
            this.lblPrdMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrdMsg.Name = "lblPrdMsg";
            this.lblPrdMsg.Size = new System.Drawing.Size(152, 19);
            this.lblPrdMsg.TabIndex = 25;
            this.lblPrdMsg.Text = "Information Message";
            this.lblPrdMsg.Visible = false;
            // 
            // txtProductPurchasePrice
            // 
            this.txtProductPurchasePrice.AnimateReadOnly = false;
            this.txtProductPurchasePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductPurchasePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductPurchasePrice.Depth = 0;
            this.txtProductPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductPurchasePrice.HelperText = "Nombre";
            this.txtProductPurchasePrice.HideSelection = true;
            this.txtProductPurchasePrice.Hint = "Precio compra";
            this.txtProductPurchasePrice.LeadingIcon = null;
            this.txtProductPurchasePrice.Location = new System.Drawing.Point(158, 147);
            this.txtProductPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductPurchasePrice.MaxLength = 32767;
            this.txtProductPurchasePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductPurchasePrice.Name = "txtProductPurchasePrice";
            this.txtProductPurchasePrice.PasswordChar = '\0';
            this.txtProductPurchasePrice.PrefixSuffixText = null;
            this.txtProductPurchasePrice.ReadOnly = false;
            this.txtProductPurchasePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductPurchasePrice.SelectedText = "";
            this.txtProductPurchasePrice.SelectionLength = 0;
            this.txtProductPurchasePrice.SelectionStart = 0;
            this.txtProductPurchasePrice.ShortcutsEnabled = true;
            this.txtProductPurchasePrice.Size = new System.Drawing.Size(152, 48);
            this.txtProductPurchasePrice.TabIndex = 12;
            this.txtProductPurchasePrice.TabStop = false;
            this.txtProductPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductPurchasePrice.TrailingIcon = null;
            this.txtProductPurchasePrice.UseSystemPasswordChar = false;
            this.txtProductPurchasePrice.Click += new System.EventHandler(this.txtProductPurchasePrice_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(17, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(285, 41);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Registrar Producto";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.AnimateReadOnly = false;
            this.txtProductDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductDescription.Depth = 0;
            this.txtProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductDescription.HelperText = "Nombre";
            this.txtProductDescription.HideSelection = true;
            this.txtProductDescription.Hint = "Descripción";
            this.txtProductDescription.LeadingIcon = null;
            this.txtProductDescription.Location = new System.Drawing.Point(17, 79);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductDescription.MaxLength = 32767;
            this.txtProductDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.PasswordChar = '\0';
            this.txtProductDescription.PrefixSuffixText = null;
            this.txtProductDescription.ReadOnly = false;
            this.txtProductDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductDescription.SelectedText = "";
            this.txtProductDescription.SelectionLength = 0;
            this.txtProductDescription.SelectionStart = 0;
            this.txtProductDescription.ShortcutsEnabled = true;
            this.txtProductDescription.Size = new System.Drawing.Size(359, 48);
            this.txtProductDescription.TabIndex = 7;
            this.txtProductDescription.TabStop = false;
            this.txtProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductDescription.TrailingIcon = null;
            this.txtProductDescription.UseSystemPasswordChar = false;
            this.txtProductDescription.Click += new System.EventHandler(this.txtProductDescription_Click);
            // 
            // btnRegisterProduct
            // 
            this.btnRegisterProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterProduct.Depth = 0;
            this.btnRegisterProduct.HighEmphasis = true;
            this.btnRegisterProduct.Icon = null;
            this.btnRegisterProduct.Location = new System.Drawing.Point(19, 252);
            this.btnRegisterProduct.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnRegisterProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterProduct.Name = "btnRegisterProduct";
            this.btnRegisterProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterProduct.Size = new System.Drawing.Size(99, 36);
            this.btnRegisterProduct.TabIndex = 8;
            this.btnRegisterProduct.Text = "Registrar";
            this.btnRegisterProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterProduct.UseAccentColor = false;
            this.btnRegisterProduct.UseVisualStyleBackColor = true;
            this.btnRegisterProduct.Click += new System.EventHandler(this.btnRegisterProduct_Click);
            // 
            // txtProductStock
            // 
            this.txtProductStock.AnimateReadOnly = false;
            this.txtProductStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductStock.Depth = 0;
            this.txtProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductStock.HelperText = "Nombre";
            this.txtProductStock.HideSelection = true;
            this.txtProductStock.Hint = "Stock";
            this.txtProductStock.LeadingIcon = null;
            this.txtProductStock.Location = new System.Drawing.Point(17, 147);
            this.txtProductStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductStock.MaxLength = 32767;
            this.txtProductStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.PasswordChar = '\0';
            this.txtProductStock.PrefixSuffixText = null;
            this.txtProductStock.ReadOnly = false;
            this.txtProductStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductStock.SelectedText = "";
            this.txtProductStock.SelectionLength = 0;
            this.txtProductStock.SelectionStart = 0;
            this.txtProductStock.ShortcutsEnabled = true;
            this.txtProductStock.Size = new System.Drawing.Size(131, 48);
            this.txtProductStock.TabIndex = 10;
            this.txtProductStock.TabStop = false;
            this.txtProductStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductStock.TrailingIcon = null;
            this.txtProductStock.UseSystemPasswordChar = false;
            this.txtProductStock.Click += new System.EventHandler(this.txtProductStock_Click);
            // 
            // txtProductSalePrice
            // 
            this.txtProductSalePrice.AnimateReadOnly = false;
            this.txtProductSalePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductSalePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductSalePrice.Depth = 0;
            this.txtProductSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductSalePrice.HelperText = "Nombre";
            this.txtProductSalePrice.HideSelection = true;
            this.txtProductSalePrice.Hint = "Precio venta";
            this.txtProductSalePrice.LeadingIcon = null;
            this.txtProductSalePrice.Location = new System.Drawing.Point(327, 147);
            this.txtProductSalePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductSalePrice.MaxLength = 32767;
            this.txtProductSalePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductSalePrice.Name = "txtProductSalePrice";
            this.txtProductSalePrice.PasswordChar = '\0';
            this.txtProductSalePrice.PrefixSuffixText = null;
            this.txtProductSalePrice.ReadOnly = false;
            this.txtProductSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductSalePrice.SelectedText = "";
            this.txtProductSalePrice.SelectionLength = 0;
            this.txtProductSalePrice.SelectionStart = 0;
            this.txtProductSalePrice.ShortcutsEnabled = true;
            this.txtProductSalePrice.Size = new System.Drawing.Size(131, 48);
            this.txtProductSalePrice.TabIndex = 13;
            this.txtProductSalePrice.TabStop = false;
            this.txtProductSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductSalePrice.TrailingIcon = null;
            this.txtProductSalePrice.UseSystemPasswordChar = false;
            this.txtProductSalePrice.Click += new System.EventHandler(this.txtProductSalePrice_Click);
            // 
            // cbxProductCategory
            // 
            this.cbxProductCategory.AutoResize = false;
            this.cbxProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxProductCategory.Depth = 0;
            this.cbxProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxProductCategory.DropDownHeight = 174;
            this.cbxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductCategory.DropDownWidth = 121;
            this.cbxProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxProductCategory.FormattingEnabled = true;
            this.cbxProductCategory.Hint = "Categoría";
            this.cbxProductCategory.IntegralHeight = false;
            this.cbxProductCategory.ItemHeight = 43;
            this.cbxProductCategory.Location = new System.Drawing.Point(382, 78);
            this.cbxProductCategory.MaxDropDownItems = 4;
            this.cbxProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(212, 49);
            this.cbxProductCategory.StartIndex = 0;
            this.cbxProductCategory.TabIndex = 11;
            this.cbxProductCategory.Tag = "";
            this.cbxProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbxProductCategory_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(19, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(157, 41);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Productos";
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(19, 72);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 29;
            this.dataGridProducts.Size = new System.Drawing.Size(759, 465);
            this.dataGridProducts.TabIndex = 14;
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.orderDetailsForm);
            this.tabSale.Controls.Add(this.orderForm);
            this.tabSale.Controls.Add(this.materialLabel4);
            this.tabSale.Controls.Add(this.dataGridSummary);
            this.tabSale.ImageKey = "money_png_64.png";
            this.tabSale.Location = new System.Drawing.Point(4, 39);
            this.tabSale.Name = "tabSale";
            this.tabSale.Size = new System.Drawing.Size(1574, 812);
            this.tabSale.TabIndex = 3;
            this.tabSale.Text = "Venta";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // orderDetailsForm
            // 
            this.orderDetailsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderDetailsForm.Controls.Add(this.lblOdMsg);
            this.orderDetailsForm.Controls.Add(this.txtQuantity);
            this.orderDetailsForm.Controls.Add(this.materialLabel9);
            this.orderDetailsForm.Controls.Add(this.materialButton1);
            this.orderDetailsForm.Controls.Add(this.cbxProducts);
            this.orderDetailsForm.Controls.Add(this.btnAddProduct);
            this.orderDetailsForm.Depth = 0;
            this.orderDetailsForm.Enabled = false;
            this.orderDetailsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orderDetailsForm.Location = new System.Drawing.Point(833, 333);
            this.orderDetailsForm.Margin = new System.Windows.Forms.Padding(14);
            this.orderDetailsForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderDetailsForm.Name = "orderDetailsForm";
            this.orderDetailsForm.Padding = new System.Windows.Forms.Padding(14);
            this.orderDetailsForm.Size = new System.Drawing.Size(555, 308);
            this.orderDetailsForm.TabIndex = 23;
            this.orderDetailsForm.Paint += new System.Windows.Forms.PaintEventHandler(this.orderDetailsForm_Paint);
            // 
            // lblOdMsg
            // 
            this.lblOdMsg.AutoSize = true;
            this.lblOdMsg.Depth = 0;
            this.lblOdMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOdMsg.Location = new System.Drawing.Point(18, 144);
            this.lblOdMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOdMsg.Name = "lblOdMsg";
            this.lblOdMsg.Size = new System.Drawing.Size(152, 19);
            this.lblOdMsg.TabIndex = 27;
            this.lblOdMsg.Text = "Information Message";
            this.lblOdMsg.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.Hint = "Cantidad";
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(344, 68);
            this.txtQuantity.MaxLength = 50;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 50);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Text = "";
            this.txtQuantity.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel9.Location = new System.Drawing.Point(17, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(262, 41);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Añadir productos";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.ImageKey = "add_png_64.png";
            this.materialButton1.ImageList = this.imageList1;
            this.materialButton1.Location = new System.Drawing.Point(422, 262);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(96, 36);
            this.materialButton1.TabIndex = 21;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_png_64.png");
            this.imageList1.Images.SetKeyName(1, "huella_png_64.png");
            this.imageList1.Images.SetKeyName(2, "money_png_64.png");
            this.imageList1.Images.SetKeyName(3, "product_png_64.png");
            this.imageList1.Images.SetKeyName(4, "user_png_64.png");
            // 
            // cbxProducts
            // 
            this.cbxProducts.AutoResize = false;
            this.cbxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxProducts.Depth = 0;
            this.cbxProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxProducts.DropDownHeight = 174;
            this.cbxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducts.DropDownWidth = 121;
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Hint = "Producto";
            this.cbxProducts.IntegralHeight = false;
            this.cbxProducts.ItemHeight = 43;
            this.cbxProducts.Location = new System.Drawing.Point(17, 69);
            this.cbxProducts.MaxDropDownItems = 4;
            this.cbxProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(303, 49);
            this.cbxProducts.StartIndex = 0;
            this.cbxProducts.TabIndex = 13;
            this.cbxProducts.Tag = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddProduct.Depth = 0;
            this.btnAddProduct.HighEmphasis = true;
            this.btnAddProduct.Icon = null;
            this.btnAddProduct.ImageKey = "add_png_64.png";
            this.btnAddProduct.ImageList = this.imageList1;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 188);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Size = new System.Drawing.Size(74, 36);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Añadir";
            this.btnAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProduct.UseAccentColor = false;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // orderForm
            // 
            this.orderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderForm.Controls.Add(this.lblOrderMsg);
            this.orderForm.Controls.Add(this.materialLabel8);
            this.orderForm.Controls.Add(this.cbxCustomerOrder);
            this.orderForm.Controls.Add(this.btnRegisterOrder);
            this.orderForm.Depth = 0;
            this.orderForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orderForm.Location = new System.Drawing.Point(833, 70);
            this.orderForm.Margin = new System.Windows.Forms.Padding(14);
            this.orderForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderForm.Name = "orderForm";
            this.orderForm.Padding = new System.Windows.Forms.Padding(14);
            this.orderForm.Size = new System.Drawing.Size(550, 244);
            this.orderForm.TabIndex = 22;
            // 
            // lblOrderMsg
            // 
            this.lblOrderMsg.AutoSize = true;
            this.lblOrderMsg.Depth = 0;
            this.lblOrderMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrderMsg.Location = new System.Drawing.Point(18, 144);
            this.lblOrderMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderMsg.Name = "lblOrderMsg";
            this.lblOrderMsg.Size = new System.Drawing.Size(152, 19);
            this.lblOrderMsg.TabIndex = 26;
            this.lblOrderMsg.Text = "Information Message";
            this.lblOrderMsg.Visible = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel8.Location = new System.Drawing.Point(17, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(238, 41);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Registrar Orden";
            // 
            // cbxCustomerOrder
            // 
            this.cbxCustomerOrder.AutoResize = false;
            this.cbxCustomerOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCustomerOrder.Depth = 0;
            this.cbxCustomerOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCustomerOrder.DropDownHeight = 174;
            this.cbxCustomerOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerOrder.DropDownWidth = 121;
            this.cbxCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCustomerOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCustomerOrder.FormattingEnabled = true;
            this.cbxCustomerOrder.Hint = "Cliente";
            this.cbxCustomerOrder.IntegralHeight = false;
            this.cbxCustomerOrder.ItemHeight = 43;
            this.cbxCustomerOrder.Location = new System.Drawing.Point(17, 71);
            this.cbxCustomerOrder.MaxDropDownItems = 4;
            this.cbxCustomerOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCustomerOrder.Name = "cbxCustomerOrder";
            this.cbxCustomerOrder.Size = new System.Drawing.Size(283, 49);
            this.cbxCustomerOrder.StartIndex = 0;
            this.cbxCustomerOrder.TabIndex = 12;
            this.cbxCustomerOrder.Tag = "";
            // 
            // btnRegisterOrder
            // 
            this.btnRegisterOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterOrder.Depth = 0;
            this.btnRegisterOrder.HighEmphasis = true;
            this.btnRegisterOrder.Icon = null;
            this.btnRegisterOrder.ImageKey = "add_png_64.png";
            this.btnRegisterOrder.ImageList = this.imageList1;
            this.btnRegisterOrder.Location = new System.Drawing.Point(18, 188);
            this.btnRegisterOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterOrder.Name = "btnRegisterOrder";
            this.btnRegisterOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterOrder.Size = new System.Drawing.Size(99, 36);
            this.btnRegisterOrder.TabIndex = 17;
            this.btnRegisterOrder.Text = "Registrar";
            this.btnRegisterOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterOrder.UseAccentColor = false;
            this.btnRegisterOrder.UseVisualStyleBackColor = true;
            this.btnRegisterOrder.Click += new System.EventHandler(this.btnRegisterOrder_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(21, 13);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(144, 41);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Resumen";
            // 
            // dataGridSummary
            // 
            this.dataGridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSummary.Location = new System.Drawing.Point(21, 70);
            this.dataGridSummary.Name = "dataGridSummary";
            this.dataGridSummary.RowHeadersWidth = 51;
            this.dataGridSummary.RowTemplate.Height = 29;
            this.dataGridSummary.Size = new System.Drawing.Size(795, 531);
            this.dataGridSummary.TabIndex = 16;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 944);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 85, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.tabMascotas.ResumeLayout(false);
            this.tabMascotas.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPets)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.tabSale.ResumeLayout(false);
            this.tabSale.PerformLayout();
            this.orderDetailsForm.ResumeLayout(false);
            this.orderDetailsForm.PerformLayout();
            this.orderForm.ResumeLayout(false);
            this.orderForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabClients;
        private TabPage tabProducts;
        private DataGridView dataGridCustomers;
        private MaterialSkin.Controls.MaterialComboBox cbxProductCategory;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductStock;
        private MaterialSkin.Controls.MaterialButton btnRegisterProduct;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DataGridView dataGridProducts;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductSalePrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductPurchasePrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabMascotas;
        private MaterialSkin.Controls.MaterialComboBox cbxPetOwner;
        private MaterialSkin.Controls.MaterialButton btnRegisterPet;
        private MaterialSkin.Controls.MaterialTextBox2 txtPetName;
        private ImageList imageList1;
        private TabPage tabSale;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialTextBox2 txtPetWeight;
        private MaterialSkin.Controls.MaterialComboBox cbxPetSpecie;
        private MaterialSkin.Controls.MaterialComboBox cbxPetSex;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DataGridView dataGridPets;
        private DataGridView dataGridSummary;
        private MaterialSkin.Controls.MaterialButton btnAddProduct;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialComboBox cbxProducts;
        private MaterialSkin.Controls.MaterialComboBox cbxCustomerOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnRegisterOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnRegisterClient;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerEmail;
        private MaterialSkin.Controls.MaterialComboBox cbxCustomerLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerName;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerDNI;
        private MaterialSkin.Controls.MaterialLabel lblCusMsg;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerPhone;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblPetMsg;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox2 txtAlmQuantity;
        private MaterialSkin.Controls.MaterialComboBox cbxAlmProduct;
        private MaterialSkin.Controls.MaterialLabel lblPrdMsg;
        private MaterialSkin.Controls.MaterialCard orderDetailsForm;
        private MaterialSkin.Controls.MaterialCard orderForm;
        private MaterialSkin.Controls.MaterialLabel lblOrderMsg;
        private MaterialSkin.Controls.MaterialLabel lblOdMsg;
    }
}