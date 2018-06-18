
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.IO;
using DfProcessImporterConfig;

namespace Devart.Data.Universal.Common {
  /// <summary>
  /// Summary description for ConnectForm.
  /// </summary>
  public class ConnectForm : System.Windows.Forms.Form {

    public ProcessImporterConfig config;
    public UniConnection connection = null;
    private System.ComponentModel.Container components = null;
    private System.Windows.Forms.Button btConnect;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.GroupBox panel1;
    private System.Windows.Forms.ComboBox cbSelProvider;
    private System.Windows.Forms.Label lbProvider;
    private int retries = 3;
        private Panel panel2;
        private static Hashtable connStrings;

    static ConnectForm() {
      connStrings = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
            /*
      connStrings.Add("MySql", "Provider=MySql;Host=server;User Id=root;Password=;Database=test;Port=3306");
      connStrings.Add("PostgreSql", "Provider=PostgreSQL;Host=server;User Id=postgres;Password=;Database=test;Port=5432");
      connStrings.Add("Oracle", "Provider=Oracle;Data Source=ora;User Id=scott;Password=tiger;Direct=true;SID=;Port=1521");
      connStrings.Add("OracleClient", "Provider=OracleClient;Data Source=ora;User Id=scott;Password=tiger");
      connStrings.Add("ODP", "Provider=Odp;Data Source=ora;User Id=scott;Password=tiger");
      connStrings.Add("SQLite", "Provider=SQLite;Data Source=test.db");
      connStrings.Add("SQL Server", "Provider=Sql Server;Data Source=server;Initial Catalog=pubs;User Id=sa");
      connStrings.Add("ODBC", "Provider=ODBC;Driver={Sql Server};UID=sa;Server=server;Database=pubs");
      connStrings.Add("OLE DB", "Provider=Ole Db;User Id=sa;Data Source=server;Initial Catalog=pubs;Ole Db Provider=SQLOLEDB.1");*/
      connStrings.Add("FirebirdClient", "Provider=Firebird;Server=127.0.0.1;User=sysdba;Password=masterkey;Port=3050;database=test.data");


        }

    public ConnectForm() {
            InitializeComponent();
            this.connection = new UniConnection();
            this.config = new ProcessImporterConfig();
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing) {

      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.btConnect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.cbSelProvider = new System.Windows.Forms.ComboBox();
            this.lbProvider = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConnect.Location = new System.Drawing.Point(50, 374);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 22);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Conectar";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(212, 374);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 22);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancelar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(10, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 251);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = false;
            // 
            // cbSelProvider
            // 
            this.cbSelProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelProvider.Location = new System.Drawing.Point(18, 27);
            this.cbSelProvider.Name = "cbSelProvider";
            this.cbSelProvider.Size = new System.Drawing.Size(184, 21);
            this.cbSelProvider.TabIndex = 0;
            this.cbSelProvider.SelectedIndexChanged += new System.EventHandler(this.cbSelProvider_SelectedIndexChanged);
            // 
            // lbProvider
            // 
            this.lbProvider.AutoSize = true;
            this.lbProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbProvider.Location = new System.Drawing.Point(16, 10);
            this.lbProvider.Name = "lbProvider";
            this.lbProvider.Size = new System.Drawing.Size(138, 13);
            this.lbProvider.TabIndex = 4;
            this.lbProvider.Text = "Proveeedor Base de Datos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSelProvider);
            this.panel2.Controls.Add(this.lbProvider);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 56);
            this.panel2.TabIndex = 8;
            // 
            // ConnectForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(336, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de conexión";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }
    #endregion

    private void ConnectForm_Load(object sender, EventArgs e) {

      if (cbSelProvider.Items.Count == 0) {
        ArrayList providerNamesList = ProviderManager.GetProviderNames(true);
        string[] providerNames = new string[providerNamesList.Count];
        providerNamesList.CopyTo(providerNames);
        cbSelProvider.Items.AddRange(providerNames);
        cbSelProvider.SelectedItem = "FirebirdClient";
      }
    }

    private void btConnect_Click(object sender, System.EventArgs e) {

      connection.Close();
      string oldConnectionString = connection.ConnectionString;

      try {
        connection.ConnectionString = BuildConnectString();
        config.sourceOptions.Add(new KeyValuePair<string, string>("sourceType", "Base de datos"));
        config.sourceOptions.Add(new KeyValuePair<string, string>("connectionString", connection.ConnectionString));

        Cursor.Current = Cursors.WaitCursor;
        connection.Open();
        Cursor.Current = Cursors.Default;

       connection.Close();
       DialogResult = DialogResult.OK;
      }
      catch (Exception exception) {
        if (oldConnectionString != String.Empty)
          connection.ConnectionString = oldConnectionString;

        Cursor.Current = Cursors.Default;
        retries--;

        if (retries == 0)
          DialogResult = DialogResult.Cancel;

        MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void cbSelProvider_SelectedIndexChanged(object sender, EventArgs e) {

      if (connStrings.Contains(cbSelProvider.Text))
        InitConnectionStringControls(connStrings[cbSelProvider.Text].ToString());
      else
        InitConnectionStringControls(String.Empty);
    }

    private void cbDatabase_DropDown(object sender, System.EventArgs e) {
      try {
        ComboBox combo = (ComboBox)sender;
        connection.ConnectionString = BuildConnectString();
        connection.Database = "";
        connection.Open();
        System.Data.DataTable databases = connection.GetSchema("Databases");
        combo.Items.Clear();

        foreach (System.Data.DataRow row in databases.Rows)
          combo.Items.Add(row[0]);
      }
      catch (Exception) {
      }
    }

    private void cbDataSource_DropDown(object sender, System.EventArgs e) {

      ComboBox combo = (ComboBox)sender;
      combo.Items.Clear();

      if (UniDataSourceEnumerator.CanCreateDataSourceEnumerator(cbSelProvider.Text)) {
        foreach (System.Data.DataRow row in UniDataSourceEnumerator.GetDataSources(cbSelProvider.Text).Rows) {
          combo.Items.Add(row[0]);
        }
      }
    }

    private void btBrowse_Click(object sender, System.EventArgs e) {
      try {
        TextBox control = (TextBox)((Button)sender).Tag;
        OpenFileDialog openDlg = new OpenFileDialog();
        openDlg.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
        openDlg.FilterIndex = 2;

        if (File.Exists(control.Text))
          openDlg.FileName = control.Text;

        openDlg.CheckFileExists = false;
        openDlg.CheckPathExists = false;

        if (openDlg.ShowDialog() == DialogResult.OK) {
          control.Text = openDlg.FileName;
        }
      }
      catch {
      }
    }

    private void InitConnectionStringControls(string providerConnectionString) {

      Dictionary<string, string> parameters = new Dictionary<string, string>();
      int shiftY = 10;
      int shiftX = 90;
      int index = 1;
      int labelWidth = 75;
      int addedWidth = 0;
      string provider = string.Empty;
      Button button = null;
      panel1.Controls.Clear();
      SetDefaultConnectionDialogSize();

      if (providerConnectionString == string.Empty) {
        Label label = new Label();
        label.Location = new Point(12, shiftY);
        label.Size = new Size(75, 19);
        label.Text = "Cadena de conexión:";
        label.TextAlign = ContentAlignment.MiddleLeft;

        TextBox textBox = new TextBox();
        textBox.Location = new Point(shiftX, shiftY);
        textBox.Size = new Size(187, 20);
        textBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label.AutoSize = true;
        textBox.TabIndex = index + 1;
        textBox.Tag = "Cadena de conexión:";

        panel1.Controls.Add(textBox);
        panel1.Controls.Add(label);

        if (label.Width - labelWidth > addedWidth)
          addedWidth = label.Width - labelWidth;

        if (addedWidth > 0)
          this.Width += addedWidth;


        this.Height = this.Height -( panel1.Height - (shiftY + 25));
      }
      else {
        string[] parts = providerConnectionString.Trim(';').Split('=', ';');
        if (parts.Length % 2 != 0)
          return;

        int keyCount = parts.Length / 2;
        for (int i = 0; i < keyCount; i++)
          parameters.Add(parts[i * 2].Trim(), parts[i * 2 + 1]);

        foreach (string key in parameters.Keys) {
          if (key.ToLower() == "provider") {
            provider = parameters[key].Trim();
            continue;
          }

          button = null;
          // Key
          Label label = new Label();
          label.Location = new Point(12, shiftY);
          label.Size = new Size(labelWidth, 20);
          label.TextAlign = ContentAlignment.MiddleLeft;
          label.AutoSize = true;
          label.Text = key;
          panel1.Controls.Add(label);

          if (label.Width - labelWidth > addedWidth)
            addedWidth = label.Width - labelWidth;

          // Value
          Control comp;
          string value = parameters[key];
          Int64 intValue;
          bool boolValue;

          if (Int64.TryParse(value, out intValue)) {
            NumericUpDown numeric = new NumericUpDown();
            numeric.Maximum = 65535;
            numeric.Value = intValue;
            comp = numeric;
          }
          else
            if (Boolean.TryParse(value, out boolValue)) {
              CheckBox checkbox = new CheckBox();
              checkbox.Checked = boolValue;
              comp = checkbox;
            }
            else
              if (key.ToLower().Contains("data source") || key.ToLower().Contains("host") || key.ToLower().Contains("serevr")) {
                if (provider.ToLower() == "sqlite" && key.ToLower().Contains("data source")) {
                  TextBox textBox = new TextBox();
                  textBox.Text = value;
                  comp = textBox;
                  button = new Button();
                  button.Tag = comp;
                }
                else {
                  ComboBox comBox = new ComboBox();
                  comBox.DropDown += new System.EventHandler(this.cbDataSource_DropDown);
                  comBox.Text = value;
                  comp = comBox;
                }
              }
              else
                if (key.ToLower().Contains("database") || key.ToLower().Contains("initial catalog")) {
                  ComboBox comBox = new ComboBox();
                  comBox.DropDown += new System.EventHandler(this.cbDatabase_DropDown);
                  comBox.Text = value;
                  comp = comBox;
                }
                else {
                  TextBox textBox = new TextBox();
                  if (key.ToLower().Contains("password"))
                    textBox.PasswordChar = '*';

                  textBox.Text = value;
                  comp = textBox;
                }

          comp.Location = new Point(shiftX, shiftY);
          comp.Size = new Size(187, 20);
          comp.TabIndex = index + 1;
          comp.Tag = key;
          comp.Anchor = AnchorStyles.Top | AnchorStyles.Right;

          if (button != null) {
            button.Size = new System.Drawing.Size(22, 20);
            comp.Width -= button.Width;
            button.Location = new System.Drawing.Point(shiftX + comp.Width, shiftY);
            button.TabIndex = index + 2;
            button.Text = "...";
            button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button.Click += new System.EventHandler(this.btBrowse_Click);
            panel1.Controls.Add(button);
          }

          panel1.Controls.Add(comp);

          shiftY += 25;
          index++;
        }

        if (addedWidth > 0)
          this.Width += addedWidth;

        if (shiftY > panel1.Height)
          this.Height = this.Height + (shiftY - panel1.Height);
      }
    }

    private string BuildConnectString() {

      int index = 0;
      string key = String.Empty;
      string text = String.Empty;
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("{0}={1};", "Provider", cbSelProvider.Text);

      foreach (Control comp in panel1.Controls) {
        if (comp.Tag == null || comp.Tag is TextBox)
          continue;

        key = (string)comp.Tag;
        text = String.Empty;

        if (comp is TextBox)
          text = (comp as TextBox).Text;
        else
          if (comp is ComboBox)
            text = (comp as ComboBox).Text;
          else
            if (comp is CheckBox)
              text = (comp as CheckBox).Checked ? "True" : "False";
            else
              if (comp is NumericUpDown)
                text = (comp as NumericUpDown).Value.ToString();

        if (key.ToLower() == "connection string")
          sb.AppendFormat("{0};", text);
        else
          sb.AppendFormat("{0}={1};", key, text);

        index++;
      }

      return sb.ToString();
    }

    private void SetDefaultConnectionDialogSize() {

      this.Size = new Size(350, 300);
    }
  }
}
