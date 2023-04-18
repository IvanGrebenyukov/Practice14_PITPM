namespace Practice14_Forms
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.textBoxTermCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYearcar = new System.Windows.Forms.NumericUpDown();
            this.textBoxPriceCar = new System.Windows.Forms.TextBox();
            this.textBoxNameOfTheSubjectOfInsuranceCar = new System.Windows.Forms.TextBox();
            this.textBoxSurnameCar = new System.Windows.Forms.TextBox();
            this.textBoxBrandCar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate = new System.Windows.Forms.ComboBox();
            this.buttonAddRealEState = new System.Windows.Forms.Button();
            this.textBoxTermRealEstate = new System.Windows.Forms.TextBox();
            this.textBoxPriceRealEstate = new System.Windows.Forms.TextBox();
            this.textBoxSurnameRealEstate = new System.Windows.Forms.TextBox();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonTermLowRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonTermHighRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonPriceLowRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonPriceHighRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonItemRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonSurnameRealEstate = new System.Windows.Forms.RadioButton();
            this.radioButtonAdrressRealEstate = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonTermLowCar = new System.Windows.Forms.RadioButton();
            this.radioButtontermHighCar = new System.Windows.Forms.RadioButton();
            this.radioButtonPriceLowCar = new System.Windows.Forms.RadioButton();
            this.radioButtonPriceHighCar = new System.Windows.Forms.RadioButton();
            this.radioButtonItemCar = new System.Windows.Forms.RadioButton();
            this.radioButtonSurnameCar = new System.Windows.Forms.RadioButton();
            this.radioButtonYearCar = new System.Windows.Forms.RadioButton();
            this.radioButtonBrandCar = new System.Windows.Forms.RadioButton();
            this.comboBoxChoiceOfInsurance = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРедактированиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearcar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Машина";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCar);
            this.groupBox1.Controls.Add(this.textBoxTermCar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownYearcar);
            this.groupBox1.Controls.Add(this.textBoxPriceCar);
            this.groupBox1.Controls.Add(this.textBoxNameOfTheSubjectOfInsuranceCar);
            this.groupBox1.Controls.Add(this.textBoxSurnameCar);
            this.groupBox1.Controls.Add(this.textBoxBrandCar);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 308);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание страховки на машину";
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(7, 277);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(365, 23);
            this.AddCar.TabIndex = 14;
            this.AddCar.Text = "Создать страховку на машину";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // textBoxTermCar
            // 
            this.textBoxTermCar.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTermCar.Location = new System.Drawing.Point(6, 239);
            this.textBoxTermCar.Name = "textBoxTermCar";
            this.textBoxTermCar.Size = new System.Drawing.Size(365, 23);
            this.textBoxTermCar.TabIndex = 11;
            this.textBoxTermCar.Text = "Введите срок страховки в годах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите год изготовления";
            // 
            // numericUpDownYearcar
            // 
            this.numericUpDownYearcar.Location = new System.Drawing.Point(7, 82);
            this.numericUpDownYearcar.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYearcar.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYearcar.Name = "numericUpDownYearcar";
            this.numericUpDownYearcar.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownYearcar.TabIndex = 9;
            this.numericUpDownYearcar.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // textBoxPriceCar
            // 
            this.textBoxPriceCar.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPriceCar.Location = new System.Drawing.Point(6, 199);
            this.textBoxPriceCar.Name = "textBoxPriceCar";
            this.textBoxPriceCar.Size = new System.Drawing.Size(365, 23);
            this.textBoxPriceCar.TabIndex = 6;
            this.textBoxPriceCar.Text = "Введите стоимость страховки";
            // 
            // textBoxNameOfTheSubjectOfInsuranceCar
            // 
            this.textBoxNameOfTheSubjectOfInsuranceCar.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNameOfTheSubjectOfInsuranceCar.Location = new System.Drawing.Point(7, 161);
            this.textBoxNameOfTheSubjectOfInsuranceCar.Name = "textBoxNameOfTheSubjectOfInsuranceCar";
            this.textBoxNameOfTheSubjectOfInsuranceCar.Size = new System.Drawing.Size(364, 23);
            this.textBoxNameOfTheSubjectOfInsuranceCar.TabIndex = 7;
            this.textBoxNameOfTheSubjectOfInsuranceCar.Text = "Введите предмет страховки";
            // 
            // textBoxSurnameCar
            // 
            this.textBoxSurnameCar.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurnameCar.Location = new System.Drawing.Point(6, 122);
            this.textBoxSurnameCar.Name = "textBoxSurnameCar";
            this.textBoxSurnameCar.Size = new System.Drawing.Size(365, 23);
            this.textBoxSurnameCar.TabIndex = 8;
            this.textBoxSurnameCar.Text = "Введите фамилию страховщика";
            // 
            // textBoxBrandCar
            // 
            this.textBoxBrandCar.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBrandCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBrandCar.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBrandCar.Location = new System.Drawing.Point(7, 32);
            this.textBoxBrandCar.Name = "textBoxBrandCar";
            this.textBoxBrandCar.Size = new System.Drawing.Size(364, 23);
            this.textBoxBrandCar.TabIndex = 0;
            this.textBoxBrandCar.Text = "Введите марку машины";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Недвижимость";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate);
            this.groupBox2.Controls.Add(this.buttonAddRealEState);
            this.groupBox2.Controls.Add(this.textBoxTermRealEstate);
            this.groupBox2.Controls.Add(this.textBoxPriceRealEstate);
            this.groupBox2.Controls.Add(this.textBoxSurnameRealEstate);
            this.groupBox2.Controls.Add(this.textBoxAddres);
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 308);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание страховки на недвижимость";
            // 
            // ComboBoxNameOfTheSubjectOfInsuranceRealEstate
            // 
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.FormattingEnabled = true;
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Items.AddRange(new object[] {
            "Квартира",
            "Частный дом",
            "Офис",
            "Ангар",
            "Склад"});
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Location = new System.Drawing.Point(7, 116);
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Name = "ComboBoxNameOfTheSubjectOfInsuranceRealEstate";
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Size = new System.Drawing.Size(364, 23);
            this.ComboBoxNameOfTheSubjectOfInsuranceRealEstate.TabIndex = 15;
            // 
            // buttonAddRealEState
            // 
            this.buttonAddRealEState.Location = new System.Drawing.Point(6, 244);
            this.buttonAddRealEState.Name = "buttonAddRealEState";
            this.buttonAddRealEState.Size = new System.Drawing.Size(365, 23);
            this.buttonAddRealEState.TabIndex = 14;
            this.buttonAddRealEState.Text = "Создать страховку на машину";
            this.buttonAddRealEState.UseVisualStyleBackColor = true;
            this.buttonAddRealEState.Click += new System.EventHandler(this.buttonAddRealEState_Click);
            // 
            // textBoxTermRealEstate
            // 
            this.textBoxTermRealEstate.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTermRealEstate.Location = new System.Drawing.Point(6, 205);
            this.textBoxTermRealEstate.Name = "textBoxTermRealEstate";
            this.textBoxTermRealEstate.Size = new System.Drawing.Size(365, 23);
            this.textBoxTermRealEstate.TabIndex = 11;
            this.textBoxTermRealEstate.Text = "Введите срок страховки в годах";
            // 
            // textBoxPriceRealEstate
            // 
            this.textBoxPriceRealEstate.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPriceRealEstate.Location = new System.Drawing.Point(8, 161);
            this.textBoxPriceRealEstate.Name = "textBoxPriceRealEstate";
            this.textBoxPriceRealEstate.Size = new System.Drawing.Size(365, 23);
            this.textBoxPriceRealEstate.TabIndex = 6;
            this.textBoxPriceRealEstate.Text = "Введите стоимость страховки";
            // 
            // textBoxSurnameRealEstate
            // 
            this.textBoxSurnameRealEstate.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurnameRealEstate.Location = new System.Drawing.Point(7, 71);
            this.textBoxSurnameRealEstate.Name = "textBoxSurnameRealEstate";
            this.textBoxSurnameRealEstate.Size = new System.Drawing.Size(365, 23);
            this.textBoxSurnameRealEstate.TabIndex = 8;
            this.textBoxSurnameRealEstate.Text = "Введите фамилию страховщика";
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddres.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddres.Location = new System.Drawing.Point(7, 32);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(364, 23);
            this.textBoxAddres.TabIndex = 0;
            this.textBoxAddres.Text = "Введите адрес недвижимости";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(980, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Данные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(974, 496);
            this.splitContainer2.SplitterDistance = 121;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.comboBoxChoiceOfInsurance);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 121);
            this.panel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonTermLowRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonTermHighRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonPriceLowRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonPriceHighRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonItemRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonSurnameRealEstate);
            this.groupBox4.Controls.Add(this.radioButtonAdrressRealEstate);
            this.groupBox4.Location = new System.Drawing.Point(422, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 115);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск недвижимость";
            this.groupBox4.Visible = false;
            // 
            // radioButtonTermLowRealEstate
            // 
            this.radioButtonTermLowRealEstate.AutoSize = true;
            this.radioButtonTermLowRealEstate.Location = new System.Drawing.Point(355, 47);
            this.radioButtonTermLowRealEstate.Name = "radioButtonTermLowRealEstate";
            this.radioButtonTermLowRealEstate.Size = new System.Drawing.Size(151, 19);
            this.radioButtonTermLowRealEstate.TabIndex = 6;
            this.radioButtonTermLowRealEstate.TabStop = true;
            this.radioButtonTermLowRealEstate.Text = "По сроку страховки(>)";
            this.radioButtonTermLowRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonTermHighRealEstate
            // 
            this.radioButtonTermHighRealEstate.AutoSize = true;
            this.radioButtonTermHighRealEstate.Location = new System.Drawing.Point(185, 48);
            this.radioButtonTermHighRealEstate.Name = "radioButtonTermHighRealEstate";
            this.radioButtonTermHighRealEstate.Size = new System.Drawing.Size(151, 19);
            this.radioButtonTermHighRealEstate.TabIndex = 5;
            this.radioButtonTermHighRealEstate.TabStop = true;
            this.radioButtonTermHighRealEstate.Text = "По сроку страховки(<)";
            this.radioButtonTermHighRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriceLowRealEstate
            // 
            this.radioButtonPriceLowRealEstate.AutoSize = true;
            this.radioButtonPriceLowRealEstate.Location = new System.Drawing.Point(355, 22);
            this.radioButtonPriceLowRealEstate.Name = "radioButtonPriceLowRealEstate";
            this.radioButtonPriceLowRealEstate.Size = new System.Drawing.Size(145, 19);
            this.radioButtonPriceLowRealEstate.TabIndex = 4;
            this.radioButtonPriceLowRealEstate.TabStop = true;
            this.radioButtonPriceLowRealEstate.Text = "По цене страховки(>)";
            this.radioButtonPriceLowRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriceHighRealEstate
            // 
            this.radioButtonPriceHighRealEstate.AutoSize = true;
            this.radioButtonPriceHighRealEstate.Location = new System.Drawing.Point(185, 23);
            this.radioButtonPriceHighRealEstate.Name = "radioButtonPriceHighRealEstate";
            this.radioButtonPriceHighRealEstate.Size = new System.Drawing.Size(145, 19);
            this.radioButtonPriceHighRealEstate.TabIndex = 3;
            this.radioButtonPriceHighRealEstate.TabStop = true;
            this.radioButtonPriceHighRealEstate.Text = "По цене страховки(<)";
            this.radioButtonPriceHighRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonItemRealEstate
            // 
            this.radioButtonItemRealEstate.AutoSize = true;
            this.radioButtonItemRealEstate.Location = new System.Drawing.Point(10, 70);
            this.radioButtonItemRealEstate.Name = "radioButtonItemRealEstate";
            this.radioButtonItemRealEstate.Size = new System.Drawing.Size(153, 19);
            this.radioButtonItemRealEstate.TabIndex = 2;
            this.radioButtonItemRealEstate.TabStop = true;
            this.radioButtonItemRealEstate.Text = "по предмету страховки";
            this.radioButtonItemRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSurnameRealEstate
            // 
            this.radioButtonSurnameRealEstate.AutoSize = true;
            this.radioButtonSurnameRealEstate.Location = new System.Drawing.Point(10, 47);
            this.radioButtonSurnameRealEstate.Name = "radioButtonSurnameRealEstate";
            this.radioButtonSurnameRealEstate.Size = new System.Drawing.Size(172, 19);
            this.radioButtonSurnameRealEstate.TabIndex = 2;
            this.radioButtonSurnameRealEstate.TabStop = true;
            this.radioButtonSurnameRealEstate.Text = "По фамилии страховщика";
            this.radioButtonSurnameRealEstate.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdrressRealEstate
            // 
            this.radioButtonAdrressRealEstate.AutoSize = true;
            this.radioButtonAdrressRealEstate.Location = new System.Drawing.Point(10, 23);
            this.radioButtonAdrressRealEstate.Name = "radioButtonAdrressRealEstate";
            this.radioButtonAdrressRealEstate.Size = new System.Drawing.Size(79, 19);
            this.radioButtonAdrressRealEstate.TabIndex = 0;
            this.radioButtonAdrressRealEstate.TabStop = true;
            this.radioButtonAdrressRealEstate.Text = "по адресу";
            this.radioButtonAdrressRealEstate.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(213, 69);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(203, 23);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(213, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(203, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonTermLowCar);
            this.groupBox3.Controls.Add(this.radioButtontermHighCar);
            this.groupBox3.Controls.Add(this.radioButtonPriceLowCar);
            this.groupBox3.Controls.Add(this.radioButtonPriceHighCar);
            this.groupBox3.Controls.Add(this.radioButtonItemCar);
            this.groupBox3.Controls.Add(this.radioButtonSurnameCar);
            this.groupBox3.Controls.Add(this.radioButtonYearCar);
            this.groupBox3.Controls.Add(this.radioButtonBrandCar);
            this.groupBox3.Location = new System.Drawing.Point(422, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 115);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск машина";
            this.groupBox3.Visible = false;
            // 
            // radioButtonTermLowCar
            // 
            this.radioButtonTermLowCar.AutoSize = true;
            this.radioButtonTermLowCar.Location = new System.Drawing.Point(349, 72);
            this.radioButtonTermLowCar.Name = "radioButtonTermLowCar";
            this.radioButtonTermLowCar.Size = new System.Drawing.Size(151, 19);
            this.radioButtonTermLowCar.TabIndex = 6;
            this.radioButtonTermLowCar.TabStop = true;
            this.radioButtonTermLowCar.Text = "По сроку страховки(>)";
            this.radioButtonTermLowCar.UseVisualStyleBackColor = true;
            // 
            // radioButtontermHighCar
            // 
            this.radioButtontermHighCar.AutoSize = true;
            this.radioButtontermHighCar.Location = new System.Drawing.Point(185, 70);
            this.radioButtontermHighCar.Name = "radioButtontermHighCar";
            this.radioButtontermHighCar.Size = new System.Drawing.Size(151, 19);
            this.radioButtontermHighCar.TabIndex = 5;
            this.radioButtontermHighCar.TabStop = true;
            this.radioButtontermHighCar.Text = "По сроку страховки(<)";
            this.radioButtontermHighCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriceLowCar
            // 
            this.radioButtonPriceLowCar.AutoSize = true;
            this.radioButtonPriceLowCar.Location = new System.Drawing.Point(349, 47);
            this.radioButtonPriceLowCar.Name = "radioButtonPriceLowCar";
            this.radioButtonPriceLowCar.Size = new System.Drawing.Size(145, 19);
            this.radioButtonPriceLowCar.TabIndex = 4;
            this.radioButtonPriceLowCar.TabStop = true;
            this.radioButtonPriceLowCar.Text = "По цене страховки(>)";
            this.radioButtonPriceLowCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriceHighCar
            // 
            this.radioButtonPriceHighCar.AutoSize = true;
            this.radioButtonPriceHighCar.Location = new System.Drawing.Point(185, 47);
            this.radioButtonPriceHighCar.Name = "radioButtonPriceHighCar";
            this.radioButtonPriceHighCar.Size = new System.Drawing.Size(145, 19);
            this.radioButtonPriceHighCar.TabIndex = 3;
            this.radioButtonPriceHighCar.TabStop = true;
            this.radioButtonPriceHighCar.Text = "По цене страховки(<)";
            this.radioButtonPriceHighCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonItemCar
            // 
            this.radioButtonItemCar.AutoSize = true;
            this.radioButtonItemCar.Location = new System.Drawing.Point(185, 22);
            this.radioButtonItemCar.Name = "radioButtonItemCar";
            this.radioButtonItemCar.Size = new System.Drawing.Size(153, 19);
            this.radioButtonItemCar.TabIndex = 2;
            this.radioButtonItemCar.TabStop = true;
            this.radioButtonItemCar.Text = "по предмету страховки";
            this.radioButtonItemCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonSurnameCar
            // 
            this.radioButtonSurnameCar.AutoSize = true;
            this.radioButtonSurnameCar.Location = new System.Drawing.Point(10, 70);
            this.radioButtonSurnameCar.Name = "radioButtonSurnameCar";
            this.radioButtonSurnameCar.Size = new System.Drawing.Size(172, 19);
            this.radioButtonSurnameCar.TabIndex = 2;
            this.radioButtonSurnameCar.TabStop = true;
            this.radioButtonSurnameCar.Text = "По фамилии страховщика";
            this.radioButtonSurnameCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonYearCar
            // 
            this.radioButtonYearCar.AutoSize = true;
            this.radioButtonYearCar.Location = new System.Drawing.Point(10, 46);
            this.radioButtonYearCar.Name = "radioButtonYearCar";
            this.radioButtonYearCar.Size = new System.Drawing.Size(131, 19);
            this.radioButtonYearCar.TabIndex = 1;
            this.radioButtonYearCar.TabStop = true;
            this.radioButtonYearCar.Text = "по году выпуска(<)";
            this.radioButtonYearCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrandCar
            // 
            this.radioButtonBrandCar.AutoSize = true;
            this.radioButtonBrandCar.Location = new System.Drawing.Point(10, 23);
            this.radioButtonBrandCar.Name = "radioButtonBrandCar";
            this.radioButtonBrandCar.Size = new System.Drawing.Size(84, 19);
            this.radioButtonBrandCar.TabIndex = 0;
            this.radioButtonBrandCar.TabStop = true;
            this.radioButtonBrandCar.Text = "по модели";
            this.radioButtonBrandCar.UseVisualStyleBackColor = true;
            // 
            // comboBoxChoiceOfInsurance
            // 
            this.comboBoxChoiceOfInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceOfInsurance.FormattingEnabled = true;
            this.comboBoxChoiceOfInsurance.Items.AddRange(new object[] {
            "Страховка на машину",
            "Страховка на недвижимость"});
            this.comboBoxChoiceOfInsurance.Location = new System.Drawing.Point(5, 69);
            this.comboBoxChoiceOfInsurance.Name = "comboBoxChoiceOfInsurance";
            this.comboBoxChoiceOfInsurance.Size = new System.Drawing.Size(183, 23);
            this.comboBoxChoiceOfInsurance.TabIndex = 0;
            this.comboBoxChoiceOfInsurance.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiceOfInsurance_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(974, 371);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(974, 371);
            this.dataGridView3.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьРедактированиеToolStripMenuItem,
            this.отменитьРедактированиеToolStripMenuItem,
            this.сохранитьРедактированиеToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Редактировать";
            // 
            // сохранитьРедактированиеToolStripMenuItem
            // 
            this.сохранитьРедактированиеToolStripMenuItem.Name = "сохранитьРедактированиеToolStripMenuItem";
            this.сохранитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьРедактированиеToolStripMenuItem.Text = "Начать редактирование";
            this.сохранитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРедактированиеToolStripMenuItem_Click);
            // 
            // отменитьРедактированиеToolStripMenuItem
            // 
            this.отменитьРедактированиеToolStripMenuItem.Name = "отменитьРедактированиеToolStripMenuItem";
            this.отменитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.отменитьРедактированиеToolStripMenuItem.Text = "Отменить редактирование";
            this.отменитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.отменитьРедактированиеToolStripMenuItem_Click);
            // 
            // сохранитьРедактированиеToolStripMenuItem1
            // 
            this.сохранитьРедактированиеToolStripMenuItem1.Name = "сохранитьРедактированиеToolStripMenuItem1";
            this.сохранитьРедактированиеToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.сохранитьРедактированиеToolStripMenuItem1.Text = "Сохранить редактирование";
            this.сохранитьРедактированиеToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьРедактированиеToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(988, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearcar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private Panel panel2;
        private Button buttonAddRealEState;
        private Button button2;
        private ListBox listBox1;
        private TextBox textBoxBrandCar;
        private Button AddCar;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private TextBox textBoxTermCar;
        private Label label3;
        private NumericUpDown numericUpDownYearcar;
        private TextBox textBoxPriceCar;
        private TextBox textBoxNameOfTheSubjectOfInsuranceCar;
        private TextBox textBoxSurnameCar;
        private GroupBox groupBox2;
        private TextBox textBoxTermRealEstate;
        private TextBox textBoxPriceRealEstate;
        private TextBox textBoxSurnameRealEstate;
        private TextBox textBoxAddres;
        private ComboBox ComboBoxNameOfTheSubjectOfInsuranceRealEstate;
        private SplitContainer splitContainer2;
        private Panel panel3;
        private ComboBox comboBoxChoiceOfInsurance;
        private Panel panel4;
        private DataGridView dataGridView3;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem сохранитьРедактированиеToolStripMenuItem;
        private ToolStripMenuItem отменитьРедактированиеToolStripMenuItem;
        private ToolStripMenuItem сохранитьРедактированиеToolStripMenuItem1;
        private GroupBox groupBox3;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private GroupBox groupBox4;
        private RadioButton radioButtonTermLowRealEstate;
        private RadioButton radioButtonTermHighRealEstate;
        private RadioButton radioButtonPriceLowRealEstate;
        private RadioButton radioButtonPriceHighRealEstate;
        private RadioButton radioButtonItemRealEstate;
        private RadioButton radioButtonSurnameRealEstate;
        private RadioButton radioButtonAdrressRealEstate;
        private RadioButton radioButtonTermLowCar;
        private RadioButton radioButtontermHighCar;
        private RadioButton radioButtonPriceLowCar;
        private RadioButton radioButtonPriceHighCar;
        private RadioButton radioButtonItemCar;
        private RadioButton radioButtonSurnameCar;
        private RadioButton radioButtonYearCar;
        private RadioButton radioButtonBrandCar;
    }
}