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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.cbxClientLocation = new MaterialSkin.Controls.MaterialComboBox();
            this.txtClientEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtClientDNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegisterClient = new MaterialSkin.Controls.MaterialButton();
            this.txtClientName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabMascotas = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridPets = new System.Windows.Forms.DataGridView();
            this.txtPetWeight = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxPetSpecie = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxPetSex = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxPetOwner = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegisterPet = new MaterialSkin.Controls.MaterialButton();
            this.txtPetName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.txtProductSalePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductPurchasePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbxProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.txtProductStock = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegisterProduct = new MaterialSkin.Controls.MaterialButton();
            this.txtProductDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegisterOrder = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxClients = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.tabMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPets)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.tabSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1160, 657);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.materialLabel5);
            this.tabClients.Controls.Add(this.materialLabel2);
            this.tabClients.Controls.Add(this.dataGridClients);
            this.tabClients.Controls.Add(this.cbxClientLocation);
            this.tabClients.Controls.Add(this.txtClientEmail);
            this.tabClients.Controls.Add(this.txtClientDNI);
            this.tabClients.Controls.Add(this.btnRegisterClient);
            this.tabClients.Controls.Add(this.txtClientName);
            this.tabClients.ImageKey = "user_png_64.png";
            this.tabClients.Location = new System.Drawing.Point(4, 39);
            this.tabClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClients.Size = new System.Drawing.Size(1152, 614);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Clientes";
            this.tabClients.UseVisualStyleBackColor = true;
            this.tabClients.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(21, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(251, 41);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Registrar Cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(21, 292);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 41);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Clientes";
            // 
            // dataGridClients
            // 
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Location = new System.Drawing.Point(21, 357);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.RowTemplate.Height = 29;
            this.dataGridClients.Size = new System.Drawing.Size(795, 188);
            this.dataGridClients.TabIndex = 8;
            // 
            // cbxClientLocation
            // 
            this.cbxClientLocation.AutoResize = false;
            this.cbxClientLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxClientLocation.Depth = 0;
            this.cbxClientLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxClientLocation.DropDownHeight = 174;
            this.cbxClientLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientLocation.DropDownWidth = 121;
            this.cbxClientLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxClientLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxClientLocation.FormattingEnabled = true;
            this.cbxClientLocation.Hint = "Distrito";
            this.cbxClientLocation.IntegralHeight = false;
            this.cbxClientLocation.ItemHeight = 43;
            this.cbxClientLocation.Items.AddRange(new object[] {
            "Cercado de Lima",
            "Los Olivos",
            "San Martín de Porres"});
            this.cbxClientLocation.Location = new System.Drawing.Point(386, 154);
            this.cbxClientLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxClientLocation.MaxDropDownItems = 4;
            this.cbxClientLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxClientLocation.Name = "cbxClientLocation";
            this.cbxClientLocation.Size = new System.Drawing.Size(207, 49);
            this.cbxClientLocation.StartIndex = 0;
            this.cbxClientLocation.TabIndex = 7;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.AnimateReadOnly = false;
            this.txtClientEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClientEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClientEmail.Depth = 0;
            this.txtClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientEmail.HelperText = "Nombre";
            this.txtClientEmail.HideSelection = true;
            this.txtClientEmail.Hint = "Email";
            this.txtClientEmail.LeadingIcon = null;
            this.txtClientEmail.Location = new System.Drawing.Point(21, 154);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientEmail.MaxLength = 32767;
            this.txtClientEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.PasswordChar = '\0';
            this.txtClientEmail.PrefixSuffixText = null;
            this.txtClientEmail.ReadOnly = false;
            this.txtClientEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientEmail.SelectedText = "";
            this.txtClientEmail.SelectionLength = 0;
            this.txtClientEmail.SelectionStart = 0;
            this.txtClientEmail.ShortcutsEnabled = true;
            this.txtClientEmail.Size = new System.Drawing.Size(359, 48);
            this.txtClientEmail.TabIndex = 6;
            this.txtClientEmail.TabStop = false;
            this.txtClientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientEmail.TrailingIcon = null;
            this.txtClientEmail.UseSystemPasswordChar = false;
            // 
            // txtClientDNI
            // 
            this.txtClientDNI.AnimateReadOnly = false;
            this.txtClientDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClientDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClientDNI.Depth = 0;
            this.txtClientDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientDNI.HelperText = "Nombre";
            this.txtClientDNI.HideSelection = true;
            this.txtClientDNI.Hint = "DNI";
            this.txtClientDNI.LeadingIcon = null;
            this.txtClientDNI.Location = new System.Drawing.Point(386, 82);
            this.txtClientDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientDNI.MaxLength = 32767;
            this.txtClientDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClientDNI.Name = "txtClientDNI";
            this.txtClientDNI.PasswordChar = '\0';
            this.txtClientDNI.PrefixSuffixText = null;
            this.txtClientDNI.ReadOnly = false;
            this.txtClientDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientDNI.SelectedText = "";
            this.txtClientDNI.SelectionLength = 0;
            this.txtClientDNI.SelectionStart = 0;
            this.txtClientDNI.ShortcutsEnabled = true;
            this.txtClientDNI.Size = new System.Drawing.Size(208, 48);
            this.txtClientDNI.TabIndex = 5;
            this.txtClientDNI.TabStop = false;
            this.txtClientDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientDNI.TrailingIcon = null;
            this.txtClientDNI.UseSystemPasswordChar = false;
            this.txtClientDNI.Click += new System.EventHandler(this.txtDNIClient_Click);
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterClient.Depth = 0;
            this.btnRegisterClient.HighEmphasis = true;
            this.btnRegisterClient.Icon = null;
            this.btnRegisterClient.Location = new System.Drawing.Point(21, 232);
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
            // 
            // txtClientName
            // 
            this.txtClientName.AnimateReadOnly = false;
            this.txtClientName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClientName.Depth = 0;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientName.HideSelection = true;
            this.txtClientName.Hint = "Nombre";
            this.txtClientName.LeadingIcon = null;
            this.txtClientName.Location = new System.Drawing.Point(21, 82);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientName.MaxLength = 32767;
            this.txtClientName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PasswordChar = '\0';
            this.txtClientName.PrefixSuffixText = null;
            this.txtClientName.ReadOnly = false;
            this.txtClientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientName.SelectedText = "";
            this.txtClientName.SelectionLength = 0;
            this.txtClientName.SelectionStart = 0;
            this.txtClientName.ShortcutsEnabled = true;
            this.txtClientName.Size = new System.Drawing.Size(359, 48);
            this.txtClientName.TabIndex = 0;
            this.txtClientName.TabStop = false;
            this.txtClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientName.TrailingIcon = null;
            this.txtClientName.UseSystemPasswordChar = false;
            // 
            // tabMascotas
            // 
            this.tabMascotas.Controls.Add(this.materialLabel6);
            this.tabMascotas.Controls.Add(this.materialLabel3);
            this.tabMascotas.Controls.Add(this.dataGridPets);
            this.tabMascotas.Controls.Add(this.txtPetWeight);
            this.tabMascotas.Controls.Add(this.cbxPetSpecie);
            this.tabMascotas.Controls.Add(this.cbxPetSex);
            this.tabMascotas.Controls.Add(this.cbxPetOwner);
            this.tabMascotas.Controls.Add(this.btnRegisterPet);
            this.tabMascotas.Controls.Add(this.txtPetName);
            this.tabMascotas.ImageKey = "huella_png_64.png";
            this.tabMascotas.Location = new System.Drawing.Point(4, 39);
            this.tabMascotas.Name = "tabMascotas";
            this.tabMascotas.Size = new System.Drawing.Size(1152, 614);
            this.tabMascotas.TabIndex = 2;
            this.tabMascotas.Text = "Mascotas";
            this.tabMascotas.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(19, 287);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(153, 41);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Mascotas";
            // 
            // dataGridPets
            // 
            this.dataGridPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPets.Location = new System.Drawing.Point(19, 345);
            this.dataGridPets.Name = "dataGridPets";
            this.dataGridPets.RowHeadersWidth = 51;
            this.dataGridPets.RowTemplate.Height = 29;
            this.dataGridPets.Size = new System.Drawing.Size(795, 188);
            this.dataGridPets.TabIndex = 21;
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
            this.txtPetWeight.Location = new System.Drawing.Point(420, 155);
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
            this.cbxPetSpecie.Location = new System.Drawing.Point(19, 154);
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
            this.cbxPetSex.Location = new System.Drawing.Point(217, 154);
            this.cbxPetSex.MaxDropDownItems = 4;
            this.cbxPetSex.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPetSex.Name = "cbxPetSex";
            this.cbxPetSex.Size = new System.Drawing.Size(197, 49);
            this.cbxPetSex.StartIndex = 0;
            this.cbxPetSex.TabIndex = 18;
            this.cbxPetSex.Tag = "";
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
            this.cbxPetOwner.Location = new System.Drawing.Point(384, 89);
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
            this.btnRegisterPet.Location = new System.Drawing.Point(19, 228);
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
            this.txtPetName.Location = new System.Drawing.Point(19, 90);
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
            this.txtPetName.Size = new System.Drawing.Size(359, 48);
            this.txtPetName.TabIndex = 14;
            this.txtPetName.TabStop = false;
            this.txtPetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPetName.TrailingIcon = null;
            this.txtPetName.UseSystemPasswordChar = false;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.materialLabel7);
            this.tabProducts.Controls.Add(this.materialLabel1);
            this.tabProducts.Controls.Add(this.dataGridProducts);
            this.tabProducts.Controls.Add(this.txtProductSalePrice);
            this.tabProducts.Controls.Add(this.txtProductPurchasePrice);
            this.tabProducts.Controls.Add(this.cbxProductCategory);
            this.tabProducts.Controls.Add(this.txtProductStock);
            this.tabProducts.Controls.Add(this.btnRegisterProduct);
            this.tabProducts.Controls.Add(this.txtProductDescription);
            this.tabProducts.ImageKey = "product_png_64.png";
            this.tabProducts.Location = new System.Drawing.Point(4, 39);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Size = new System.Drawing.Size(1152, 614);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Productos";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(16, 288);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(157, 41);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Productos";
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(16, 342);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 29;
            this.dataGridProducts.Size = new System.Drawing.Size(746, 252);
            this.dataGridProducts.TabIndex = 14;
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
            this.txtProductSalePrice.Location = new System.Drawing.Point(359, 162);
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
            this.txtProductPurchasePrice.Location = new System.Drawing.Point(153, 162);
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
            this.txtProductPurchasePrice.Size = new System.Drawing.Size(200, 48);
            this.txtProductPurchasePrice.TabIndex = 12;
            this.txtProductPurchasePrice.TabStop = false;
            this.txtProductPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductPurchasePrice.TrailingIcon = null;
            this.txtProductPurchasePrice.UseSystemPasswordChar = false;
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
            this.cbxProductCategory.Location = new System.Drawing.Point(392, 93);
            this.cbxProductCategory.MaxDropDownItems = 4;
            this.cbxProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(212, 49);
            this.cbxProductCategory.StartIndex = 0;
            this.cbxProductCategory.TabIndex = 11;
            this.cbxProductCategory.Tag = "";
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
            this.txtProductStock.Location = new System.Drawing.Point(16, 162);
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
            // 
            // btnRegisterProduct
            // 
            this.btnRegisterProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterProduct.Depth = 0;
            this.btnRegisterProduct.HighEmphasis = true;
            this.btnRegisterProduct.Icon = null;
            this.btnRegisterProduct.Location = new System.Drawing.Point(16, 234);
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
            this.txtProductDescription.Location = new System.Drawing.Point(16, 94);
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
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.materialLabel8);
            this.tabSale.Controls.Add(this.materialLabel4);
            this.tabSale.Controls.Add(this.btnRegisterOrder);
            this.tabSale.Controls.Add(this.dataGridView4);
            this.tabSale.Controls.Add(this.btnAddProduct);
            this.tabSale.Controls.Add(this.txtAmount);
            this.tabSale.Controls.Add(this.cbxProducts);
            this.tabSale.Controls.Add(this.cbxClients);
            this.tabSale.ImageKey = "money_png_64.png";
            this.tabSale.Location = new System.Drawing.Point(4, 39);
            this.tabSale.Name = "tabSale";
            this.tabSale.Size = new System.Drawing.Size(1152, 614);
            this.tabSale.TabIndex = 3;
            this.tabSale.Text = "Venta";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(21, 291);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(144, 41);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Resumen";
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
            this.btnRegisterOrder.Location = new System.Drawing.Point(717, 572);
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
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "huella_png_64.png");
            this.imageList1.Images.SetKeyName(1, "product_png_64.png");
            this.imageList1.Images.SetKeyName(2, "user_png_64.png");
            this.imageList1.Images.SetKeyName(3, "money_png_64.png");
            this.imageList1.Images.SetKeyName(4, "add_png_64.png");
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(21, 346);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(795, 287);
            this.dataGridView4.TabIndex = 16;
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
            this.btnAddProduct.Location = new System.Drawing.Point(21, 239);
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
            // 
            // txtAmount
            // 
            this.txtAmount.AnimateReadOnly = false;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Hint = "Cantidad";
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(258, 174);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(125, 50);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.Text = "";
            this.txtAmount.TrailingIcon = null;
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
            this.cbxProducts.Location = new System.Drawing.Point(21, 175);
            this.cbxProducts.MaxDropDownItems = 4;
            this.cbxProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(219, 49);
            this.cbxProducts.StartIndex = 0;
            this.cbxProducts.TabIndex = 13;
            this.cbxProducts.Tag = "";
            // 
            // cbxClients
            // 
            this.cbxClients.AutoResize = false;
            this.cbxClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxClients.Depth = 0;
            this.cbxClients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxClients.DropDownHeight = 174;
            this.cbxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClients.DropDownWidth = 121;
            this.cbxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxClients.FormattingEnabled = true;
            this.cbxClients.Hint = "Cliente";
            this.cbxClients.IntegralHeight = false;
            this.cbxClients.ItemHeight = 43;
            this.cbxClients.Location = new System.Drawing.Point(21, 104);
            this.cbxClients.MaxDropDownItems = 4;
            this.cbxClients.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(219, 49);
            this.cbxClients.StartIndex = 0;
            this.cbxClients.TabIndex = 12;
            this.cbxClients.Tag = "";
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
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(19, 19);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(281, 41);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "Registrar Mascota";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(16, 25);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(285, 41);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Registrar Producto";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel8.Location = new System.Drawing.Point(21, 31);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(238, 41);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Registrar Orden";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 746);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 85, 3, 4);
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.tabMascotas.ResumeLayout(false);
            this.tabMascotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPets)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.tabSale.ResumeLayout(false);
            this.tabSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabClients;
        private TabPage tabProducts;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientName;
        private MaterialSkin.Controls.MaterialButton btnRegisterClient;
        private MaterialSkin.Controls.MaterialComboBox cbxClientLocation;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientDNI;
        private DataGridView dataGridClients;
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
        private DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialButton btnAddProduct;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private MaterialSkin.Controls.MaterialComboBox cbxProducts;
        private MaterialSkin.Controls.MaterialComboBox cbxClients;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnRegisterOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}