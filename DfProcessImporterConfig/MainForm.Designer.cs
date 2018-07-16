namespace DfProcessImporterConfig
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfigTabControl = new System.Windows.Forms.TabControl();
            this.QueryTabPage = new System.Windows.Forms.TabPage();
            this.DataBaseQueryPanel = new System.Windows.Forms.Panel();
            this.DbColumnIdTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.XmlQueryPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.XmlPathLabel = new System.Windows.Forms.Label();
            this.ExcelQueryPanel = new System.Windows.Forms.Panel();
            this.excelColumnIdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ExcelSheetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExcelPathLabel = new System.Windows.Forms.Label();
            this.PreviewTabPage = new System.Windows.Forms.TabPage();
            this.PreviewDataGridView = new System.Windows.Forms.DataGridView();
            this.ApiTabPage = new System.Windows.Forms.TabPage();
            this.MaxAttempsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.superAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.initWfCheckBox = new System.Windows.Forms.CheckBox();
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.communityComboBox = new System.Windows.Forms.ComboBox();
            this.apiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apiUserTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.apiUrlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SourceConfigButton = new System.Windows.Forms.Button();
            this.SourceComboBox = new System.Windows.Forms.ComboBox();
            this.complexNodesTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ConfigTabControl.SuspendLayout();
            this.QueryTabPage.SuspendLayout();
            this.DataBaseQueryPanel.SuspendLayout();
            this.XmlQueryPanel.SuspendLayout();
            this.ExcelQueryPanel.SuspendLayout();
            this.PreviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewDataGridView)).BeginInit();
            this.ApiTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAttempsNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SaveConfigButton);
            this.panel1.Location = new System.Drawing.Point(116, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 49);
            this.panel1.TabIndex = 2;
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveConfigButton.Location = new System.Drawing.Point(580, 12);
            this.SaveConfigButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(195, 26);
            this.SaveConfigButton.TabIndex = 0;
            this.SaveConfigButton.Text = "Guardar configuración";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origen de Datos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigTabControl
            // 
            this.ConfigTabControl.Controls.Add(this.QueryTabPage);
            this.ConfigTabControl.Controls.Add(this.PreviewTabPage);
            this.ConfigTabControl.Controls.Add(this.ApiTabPage);
            this.ConfigTabControl.Location = new System.Drawing.Point(12, 113);
            this.ConfigTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfigTabControl.Name = "ConfigTabControl";
            this.ConfigTabControl.SelectedIndex = 0;
            this.ConfigTabControl.Size = new System.Drawing.Size(888, 306);
            this.ConfigTabControl.TabIndex = 7;
            this.ConfigTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.ConfigTabControl_Selected);
            // 
            // QueryTabPage
            // 
            this.QueryTabPage.AllowDrop = true;
            this.QueryTabPage.Controls.Add(this.XmlQueryPanel);
            this.QueryTabPage.Controls.Add(this.ExcelQueryPanel);
            this.QueryTabPage.Controls.Add(this.DataBaseQueryPanel);
            this.QueryTabPage.Location = new System.Drawing.Point(4, 25);
            this.QueryTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryTabPage.Name = "QueryTabPage";
            this.QueryTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryTabPage.Size = new System.Drawing.Size(880, 277);
            this.QueryTabPage.TabIndex = 0;
            this.QueryTabPage.Text = "Consulta de Datos";
            this.QueryTabPage.UseVisualStyleBackColor = true;
            // 
            // DataBaseQueryPanel
            // 
            this.DataBaseQueryPanel.Controls.Add(this.DbColumnIdTextBox);
            this.DataBaseQueryPanel.Controls.Add(this.label11);
            this.DataBaseQueryPanel.Controls.Add(this.label4);
            this.DataBaseQueryPanel.Controls.Add(this.label3);
            this.DataBaseQueryPanel.Controls.Add(this.queryTextBox);
            this.DataBaseQueryPanel.Controls.Add(this.connectionStringLabel);
            this.DataBaseQueryPanel.Location = new System.Drawing.Point(11, 9);
            this.DataBaseQueryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataBaseQueryPanel.Name = "DataBaseQueryPanel";
            this.DataBaseQueryPanel.Size = new System.Drawing.Size(745, 254);
            this.DataBaseQueryPanel.TabIndex = 1;
            // 
            // DbColumnIdTextBox
            // 
            this.DbColumnIdTextBox.Location = new System.Drawing.Point(161, 215);
            this.DbColumnIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DbColumnIdTextBox.Name = "DbColumnIdTextBox";
            this.DbColumnIdTextBox.Size = new System.Drawing.Size(249, 22);
            this.DbColumnIdTextBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Columna Identificador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consulta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cadena de conexión:";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(15, 62);
            this.queryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryTextBox.Size = new System.Drawing.Size(695, 142);
            this.queryTextBox.TabIndex = 0;
            this.queryTextBox.Text = "select * from DATOS;";
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.Location = new System.Drawing.Point(157, 4);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(552, 55);
            this.connectionStringLabel.TabIndex = 2;
            // 
            // XmlQueryPanel
            // 
            this.XmlQueryPanel.Controls.Add(this.complexNodesTextBox);
            this.XmlQueryPanel.Controls.Add(this.label14);
            this.XmlQueryPanel.Controls.Add(this.label16);
            this.XmlQueryPanel.Controls.Add(this.XmlPathLabel);
            this.XmlQueryPanel.Location = new System.Drawing.Point(11, 9);
            this.XmlQueryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XmlQueryPanel.Name = "XmlQueryPanel";
            this.XmlQueryPanel.Size = new System.Drawing.Size(755, 127);
            this.XmlQueryPanel.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(3, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ruta:";
            // 
            // XmlPathLabel
            // 
            this.XmlPathLabel.Location = new System.Drawing.Point(60, 11);
            this.XmlPathLabel.Name = "XmlPathLabel";
            this.XmlPathLabel.Size = new System.Drawing.Size(669, 48);
            this.XmlPathLabel.TabIndex = 1;
            this.XmlPathLabel.Text = "C:\\";
            // 
            // ExcelQueryPanel
            // 
            this.ExcelQueryPanel.Controls.Add(this.excelColumnIdTextBox);
            this.ExcelQueryPanel.Controls.Add(this.label12);
            this.ExcelQueryPanel.Controls.Add(this.ExcelSheetTextBox);
            this.ExcelQueryPanel.Controls.Add(this.label6);
            this.ExcelQueryPanel.Controls.Add(this.label5);
            this.ExcelQueryPanel.Controls.Add(this.ExcelPathLabel);
            this.ExcelQueryPanel.Location = new System.Drawing.Point(11, 9);
            this.ExcelQueryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExcelQueryPanel.Name = "ExcelQueryPanel";
            this.ExcelQueryPanel.Size = new System.Drawing.Size(755, 144);
            this.ExcelQueryPanel.TabIndex = 2;
            // 
            // excelColumnIdTextBox
            // 
            this.excelColumnIdTextBox.Location = new System.Drawing.Point(281, 89);
            this.excelColumnIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.excelColumnIdTextBox.Name = "excelColumnIdTextBox";
            this.excelColumnIdTextBox.Size = new System.Drawing.Size(249, 22);
            this.excelColumnIdTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Columna Identificador:";
            // 
            // ExcelSheetTextBox
            // 
            this.ExcelSheetTextBox.Location = new System.Drawing.Point(5, 89);
            this.ExcelSheetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExcelSheetTextBox.Name = "ExcelSheetTextBox";
            this.ExcelSheetTextBox.Size = new System.Drawing.Size(231, 22);
            this.ExcelSheetTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hoja de Excel:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ruta:";
            // 
            // ExcelPathLabel
            // 
            this.ExcelPathLabel.Location = new System.Drawing.Point(60, 11);
            this.ExcelPathLabel.Name = "ExcelPathLabel";
            this.ExcelPathLabel.Size = new System.Drawing.Size(669, 48);
            this.ExcelPathLabel.TabIndex = 1;
            this.ExcelPathLabel.Text = "C:\\";
            // 
            // PreviewTabPage
            // 
            this.PreviewTabPage.Controls.Add(this.PreviewDataGridView);
            this.PreviewTabPage.Location = new System.Drawing.Point(4, 25);
            this.PreviewTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviewTabPage.Name = "PreviewTabPage";
            this.PreviewTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviewTabPage.Size = new System.Drawing.Size(880, 277);
            this.PreviewTabPage.TabIndex = 1;
            this.PreviewTabPage.Text = "Vista previa";
            this.PreviewTabPage.UseVisualStyleBackColor = true;
            // 
            // PreviewDataGridView
            // 
            this.PreviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviewDataGridView.Location = new System.Drawing.Point(5, 6);
            this.PreviewDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviewDataGridView.Name = "PreviewDataGridView";
            this.PreviewDataGridView.RowTemplate.Height = 24;
            this.PreviewDataGridView.Size = new System.Drawing.Size(757, 266);
            this.PreviewDataGridView.TabIndex = 0;
            // 
            // ApiTabPage
            // 
            this.ApiTabPage.Controls.Add(this.MaxAttempsNumericUpDown);
            this.ApiTabPage.Controls.Add(this.label13);
            this.ApiTabPage.Controls.Add(this.superAdminCheckBox);
            this.ApiTabPage.Controls.Add(this.label10);
            this.ApiTabPage.Controls.Add(this.label9);
            this.ApiTabPage.Controls.Add(this.initWfCheckBox);
            this.ApiTabPage.Controls.Add(this.processComboBox);
            this.ApiTabPage.Controls.Add(this.communityComboBox);
            this.ApiTabPage.Controls.Add(this.apiPasswordTextBox);
            this.ApiTabPage.Controls.Add(this.label8);
            this.ApiTabPage.Controls.Add(this.apiUserTextBox);
            this.ApiTabPage.Controls.Add(this.label7);
            this.ApiTabPage.Controls.Add(this.apiUrlTextBox);
            this.ApiTabPage.Controls.Add(this.label2);
            this.ApiTabPage.Location = new System.Drawing.Point(4, 25);
            this.ApiTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApiTabPage.Name = "ApiTabPage";
            this.ApiTabPage.Size = new System.Drawing.Size(880, 277);
            this.ApiTabPage.TabIndex = 2;
            this.ApiTabPage.Text = "Api Dokuflex";
            this.ApiTabPage.UseVisualStyleBackColor = true;
            // 
            // MaxAttempsNumericUpDown
            // 
            this.MaxAttempsNumericUpDown.Location = new System.Drawing.Point(404, 169);
            this.MaxAttempsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxAttempsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxAttempsNumericUpDown.Name = "MaxAttempsNumericUpDown";
            this.MaxAttempsNumericUpDown.Size = new System.Drawing.Size(48, 22);
            this.MaxAttempsNumericUpDown.TabIndex = 14;
            this.MaxAttempsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxAttempsNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Máximo de intentos:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // superAdminCheckBox
            // 
            this.superAdminCheckBox.AutoSize = true;
            this.superAdminCheckBox.Location = new System.Drawing.Point(631, 50);
            this.superAdminCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superAdminCheckBox.Name = "superAdminCheckBox";
            this.superAdminCheckBox.Size = new System.Drawing.Size(106, 21);
            this.superAdminCheckBox.TabIndex = 12;
            this.superAdminCheckBox.Text = "Superadmin";
            this.superAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Community:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Process:";
            // 
            // initWfCheckBox
            // 
            this.initWfCheckBox.AutoSize = true;
            this.initWfCheckBox.Location = new System.Drawing.Point(32, 170);
            this.initWfCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initWfCheckBox.Name = "initWfCheckBox";
            this.initWfCheckBox.Size = new System.Drawing.Size(105, 21);
            this.initWfCheckBox.TabIndex = 9;
            this.initWfCheckBox.Text = "InitWorkflow";
            this.initWfCheckBox.UseVisualStyleBackColor = true;
            // 
            // processComboBox
            // 
            this.processComboBox.DisplayMember = "title";
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(97, 107);
            this.processComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(184, 24);
            this.processComboBox.TabIndex = 6;
            this.processComboBox.ValueMember = "id";
            this.processComboBox.DropDown += new System.EventHandler(this.processComboBox_DropDown);
            // 
            // communityComboBox
            // 
            this.communityComboBox.DisplayMember = "name";
            this.communityComboBox.FormattingEnabled = true;
            this.communityComboBox.Location = new System.Drawing.Point(404, 107);
            this.communityComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.communityComboBox.Name = "communityComboBox";
            this.communityComboBox.Size = new System.Drawing.Size(184, 24);
            this.communityComboBox.TabIndex = 8;
            this.communityComboBox.ValueMember = "id";
            this.communityComboBox.DropDown += new System.EventHandler(this.communityComboBox_DropDown);
            this.communityComboBox.SelectedIndexChanged += new System.EventHandler(this.communityComboBox_SelectedIndexChanged);
            // 
            // apiPasswordTextBox
            // 
            this.apiPasswordTextBox.Location = new System.Drawing.Point(404, 48);
            this.apiPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apiPasswordTextBox.Name = "apiPasswordTextBox";
            this.apiPasswordTextBox.PasswordChar = '*';
            this.apiPasswordTextBox.Size = new System.Drawing.Size(184, 22);
            this.apiPasswordTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contraseña:";
            // 
            // apiUserTextBox
            // 
            this.apiUserTextBox.Location = new System.Drawing.Point(97, 48);
            this.apiUserTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apiUserTextBox.Name = "apiUserTextBox";
            this.apiUserTextBox.Size = new System.Drawing.Size(184, 22);
            this.apiUserTextBox.TabIndex = 3;
            this.apiUserTextBox.Text = "nuria.alcantara@dokuflex.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuario:";
            // 
            // apiUrlTextBox
            // 
            this.apiUrlTextBox.Location = new System.Drawing.Point(97, 11);
            this.apiUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apiUrlTextBox.Name = "apiUrlTextBox";
            this.apiUrlTextBox.Size = new System.Drawing.Size(491, 22);
            this.apiUrlTextBox.TabIndex = 1;
            this.apiUrlTextBox.Text = "https://dev.dokuflex.com/services/rest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Api Url:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SourceConfigButton);
            this.panel2.Controls.Add(this.SourceComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(469, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 50);
            this.panel2.TabIndex = 8;
            // 
            // SourceConfigButton
            // 
            this.SourceConfigButton.Location = new System.Drawing.Point(312, 12);
            this.SourceConfigButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SourceConfigButton.Name = "SourceConfigButton";
            this.SourceConfigButton.Size = new System.Drawing.Size(105, 26);
            this.SourceConfigButton.TabIndex = 6;
            this.SourceConfigButton.Text = "Configurar";
            this.SourceConfigButton.UseVisualStyleBackColor = true;
            this.SourceConfigButton.Click += new System.EventHandler(this.SourceConfigButton_Click);
            // 
            // SourceComboBox
            // 
            this.SourceComboBox.FormattingEnabled = true;
            this.SourceComboBox.Items.AddRange(new object[] {
            "Base de datos",
            "Ficheros Excel",
            "Ficheros XML"});
            this.SourceComboBox.Location = new System.Drawing.Point(163, 12);
            this.SourceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SourceComboBox.Name = "SourceComboBox";
            this.SourceComboBox.Size = new System.Drawing.Size(143, 24);
            this.SourceComboBox.TabIndex = 5;
            this.SourceComboBox.Text = "Seleccione...";
            // 
            // complexNodesTextBox
            // 
            this.complexNodesTextBox.Location = new System.Drawing.Point(7, 67);
            this.complexNodesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.complexNodesTextBox.Name = "complexNodesTextBox";
            this.complexNodesTextBox.Size = new System.Drawing.Size(738, 22);
            this.complexNodesTextBox.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(345, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nodos de multiples elementos (separados por coma )";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(907, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ConfigTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Configuración de Importación";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ConfigTabControl.ResumeLayout(false);
            this.QueryTabPage.ResumeLayout(false);
            this.DataBaseQueryPanel.ResumeLayout(false);
            this.DataBaseQueryPanel.PerformLayout();
            this.XmlQueryPanel.ResumeLayout(false);
            this.XmlQueryPanel.PerformLayout();
            this.ExcelQueryPanel.ResumeLayout(false);
            this.ExcelQueryPanel.PerformLayout();
            this.PreviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewDataGridView)).EndInit();
            this.ApiTabPage.ResumeLayout(false);
            this.ApiTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAttempsNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl ConfigTabControl;
        private System.Windows.Forms.TabPage QueryTabPage;
        private System.Windows.Forms.TabPage PreviewTabPage;
        private System.Windows.Forms.DataGridView PreviewDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DataBaseQueryPanel;
        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SourceConfigButton;
        private System.Windows.Forms.ComboBox SourceComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExcelPathLabel;
        private System.Windows.Forms.TextBox ExcelSheetTextBox;
        private System.Windows.Forms.Panel ExcelQueryPanel;
        private System.Windows.Forms.TabPage ApiTabPage;
        private System.Windows.Forms.CheckBox initWfCheckBox;
        private System.Windows.Forms.ComboBox communityComboBox;
        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.TextBox apiPasswordTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apiUserTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox apiUrlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DbColumnIdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox excelColumnIdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox superAdminCheckBox;
        private System.Windows.Forms.NumericUpDown MaxAttempsNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel XmlQueryPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label XmlPathLabel;
        private System.Windows.Forms.TextBox complexNodesTextBox;
        private System.Windows.Forms.Label label14;
    }
}

