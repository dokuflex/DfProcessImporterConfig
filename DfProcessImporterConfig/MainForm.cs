using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Devart.Data.Universal;
using Devart.Data.Universal.Common;
using Newtonsoft.Json;
using DfProcessImporterConfig.DfApiC;

namespace DfProcessImporterConfig
{
    public partial class MainForm : Form
    {

        private DfApi dfApi;
        private UniConnection connection { get; set; }

        private ConnectForm connectForm { get; set; }

        private Stream excelStream { get; set; } = null;


        public ProcessImporterConfig config { get; set; }
        public MainForm()
        {           
            InitializeComponent();

            config = new ProcessImporterConfig();

            ConfigTabControl.Hide();

            if (LoadConfig())
            {
                RefreshUI();
                InitApiConfigUI();
            }
        }

        private bool LoadConfig()
        {
            if (File.Exists("ProcessImporter.config"))
            {
                var textFile = File.ReadAllText("ProcessImporter.config");
                try
                {
                    config = JsonConvert.DeserializeObject<ProcessImporterConfig>(textFile);
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private void InitApiConfigUI()
        {
            apiUrlTextBox.Text = config.apiUrl;
            apiUserTextBox.Text = config.apiUser;
            apiPasswordTextBox.Text = config.apiPassword;
            processComboBox.Text = config.processName;
            communityComboBox.Text = config.communityName;
            initWfCheckBox.Checked = config.initWF;
            superAdminCheckBox.Checked = config.superAdmin;
            if (config.maxAttempts > 0)
            {
                MaxAttempsNumericUpDown.Value = config.maxAttempts;
            }
            else
            {
                MaxAttempsNumericUpDown.Value = 1;
            }
        }
        private void RefreshUI()
        {
            if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Base de datos")
            {
                SourceComboBox.Text = "Base de datos";
                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "query").Value))
                {
                    queryTextBox.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "query").Value;
                    if (!String.IsNullOrWhiteSpace(config.columnId))
                    {
                        DbColumnIdTextBox.Text = config.columnId;
                    }
                }
                

                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "connectionString").Value))
                {
                    connectionStringLabel.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "connectionString").Value;
                    if (!String.IsNullOrWhiteSpace(config.columnId))
                    {
                        excelColumnIdTextBox.Text = config.columnId;
                    }
                }

                
                    ExcelQueryPanel.Hide();
                XmlQueryPanel.Hide();
                DataBaseQueryPanel.Show();
                ConfigTabControl.Show();
            }

            if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Ficheros Excel")
            {
                SourceComboBox.Text = "Ficheros Excel";

                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "excelPath").Value))
                {
                    ExcelPathLabel.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "excelPath").Value;
                }
                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "excelSheet").Value))
                {
                    ExcelSheetTextBox.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "excelSheet").Value;
                }

                ExcelQueryPanel.Show();
                DataBaseQueryPanel.Hide();
                XmlQueryPanel.Hide();

                ConfigTabControl.Show();
            }

            if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Ficheros XML")
            {
                SourceComboBox.Text = "Ficheros XML";

                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "xmlPath").Value))
                {
                    XmlPathLabel.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "xmlPath").Value;
                }

                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "complexNodes").Value))
                {
                    complexNodesTextBox.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "complexNodes").Value;
                }

                XmlQueryPanel.Show();
                complexNodesTextBox.Show();
                labelComplexNodes.Show();
                ExcelQueryPanel.Hide();
                DataBaseQueryPanel.Hide();
                ConfigTabControl.Show();
            }

            if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Ficheros JSON")
            {
                SourceComboBox.Text = "Ficheros JSON";

                if (!String.IsNullOrWhiteSpace(config.sourceOptions?.FirstOrDefault(p => p.Key == "jsonPath").Value))
                {
                    XmlPathLabel.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "jsonPath").Value;
                }

                XmlQueryPanel.Show();
                complexNodesTextBox.Hide();
                labelComplexNodes.Hide();
                ExcelQueryPanel.Hide();
                DataBaseQueryPanel.Hide();
                ConfigTabControl.Show();
            }

        }

       

        private void ConfigTabControl_Selected(object sender, TabControlEventArgs e)
        {
            SourceComboBox.Text = config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value;
            if (ConfigTabControl.SelectedIndex == 1) //Preview Tab Selected
            {
                PreviewDataGridView.DataSource = null;
                if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Base de datos")
                {
                        var query = queryTextBox.Text;
                        if (!String.IsNullOrEmpty(query))
                        {
                            try
                            {
                                connection = new UniConnection(config.sourceOptions?.FirstOrDefault(p => p.Key == "connectionString").Value);
                                connection.Open();
                                UniCommand cmd = new UniCommand(query, connection);
                                UniDataAdapter uniDataAdapter = new UniDataAdapter(cmd);
                                DataSet dataSet = new DataSet("PreviewTable");
                                uniDataAdapter.Fill(dataSet, "PreviewTable");
                                PreviewDataGridView.DataSource = dataSet.Tables["PreviewTable"];
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocurrió un error al ejecutar la consulta. Descripción del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                }
                if (config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value == "Ficheros Excel")
                {
                    MessageBox.Show("Opción en desarrollo.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ConfigTabControl.SelectedTab = QueryTabPage;
                }


                }  
        }

        private void SaveConfigButton_Click_1(object sender, EventArgs e)
        {
            ProcessImporterConfig newConfig = new ProcessImporterConfig();

            var sourceType = config.sourceOptions?.FirstOrDefault(p => p.Key == "sourceType").Value;

            if (sourceType == null)
            {
                MessageBox.Show("Configuración incompleta. Debe configurar un origen de datos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newConfig.sourceOptions.Add(config.sourceOptions.FirstOrDefault(p => p.Key == "sourceType"));

            if (sourceType == "Base de datos")
            {
                newConfig.sourceOptions.Add(config.sourceOptions.FirstOrDefault(p => p.Key == "connectionString"));

                if (String.IsNullOrWhiteSpace(queryTextBox.Text))
                {
                    MessageBox.Show("Configuración incompleta. La consulta de datos no debe estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newConfig.sourceOptions.Add(new KeyValuePair<string, string>("query", queryTextBox.Text));
            }

            if (sourceType == "Ficheros Excel")
            {
                newConfig.sourceOptions.Add(config.sourceOptions.FirstOrDefault(p => p.Key == "excelPath"));

                if (String.IsNullOrWhiteSpace(ExcelSheetTextBox.Text))
                {
                    MessageBox.Show("Configuración incompleta. Debe definir un titulo de hoja a procesar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newConfig.sourceOptions.Add(new KeyValuePair<string, string>("excelSheet", ExcelSheetTextBox.Text));
            }

            if (sourceType == "Ficheros XML")
            {
                newConfig.sourceOptions.Add(config.sourceOptions.FirstOrDefault(p => p.Key == "xmlPath"));
                newConfig.sourceOptions.Add(new KeyValuePair<string, string>("complexNodes", complexNodesTextBox.Text));
            }

            if (sourceType == "Ficheros JSON")
            {
                newConfig.sourceOptions.Add(config.sourceOptions.FirstOrDefault(p => p.Key == "jsonPath"));
            }

            if (string.IsNullOrWhiteSpace(apiUrlTextBox.Text)
                || string.IsNullOrWhiteSpace(apiUserTextBox.Text)
                || string.IsNullOrWhiteSpace(apiPasswordTextBox.Text)
                )
            {
                MessageBox.Show("Hay errores en los datos de configuración de la API. Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(excelColumnIdTextBox.Text)
                && string.IsNullOrWhiteSpace(DbColumnIdTextBox.Text)
                && sourceType != "Ficheros XML" && sourceType != "Ficheros JSON")
            {
                MessageBox.Show("Hay errores en la consulta. La columna identificador no puede estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!string.IsNullOrWhiteSpace(excelColumnIdTextBox.Text))
                newConfig.columnId = excelColumnIdTextBox.Text;

            if (!string.IsNullOrWhiteSpace(DbColumnIdTextBox.Text))
                newConfig.columnId = DbColumnIdTextBox.Text;


            newConfig.apiUrl = apiUrlTextBox.Text;
            newConfig.apiUser = apiUserTextBox.Text;
            newConfig.apiPassword = apiPasswordTextBox.Text;
            newConfig.processName = processComboBox.Text;
            newConfig.communityName = communityComboBox.Text;
            newConfig.initWF = initWfCheckBox.Checked;
            newConfig.superAdmin = superAdminCheckBox.Checked;
            newConfig.maxAttempts = int.Parse(MaxAttempsNumericUpDown.Value.ToString());
            

            string json = JsonConvert.SerializeObject(newConfig);

            try
            {
                File.WriteAllText("ProcessImporter.config", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrión un error mientras se guardaba la configuración. \n Descripción del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                var dialogResult = MessageBox.Show("Se guardó correctamente la configuración. ¿Desea cerrar el asistente de configuración? ", "Configuración guardada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                    Application.Exit();
            }       
        }

        private void SourceConfigButton_Click(object sender, EventArgs e)
        {
            ConfigTabControl.Hide();
            if (SourceComboBox.Text == "Base de datos")
            {
                connectForm = new ConnectForm();
                if (connectForm.ShowDialog() == DialogResult.OK)
                {
                    connection = connectForm.connection;
                    config = connectForm.config;
                    ExcelQueryPanel.Hide();
                    DataBaseQueryPanel.Show();
                }
                RefreshUI();
            }
            else if (SourceComboBox.Text == "Ficheros Excel" || SourceComboBox.Text == "Ficheros XML" || SourceComboBox.Text == "Ficheros JSON")
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(folderBrowserDialog.SelectedPath))
                    {
                        MessageBox.Show("El directorio seleccionado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        config = new ProcessImporterConfig();
                        if (SourceComboBox.Text == "Ficheros Excel")
                        {
                            config.sourceOptions.Add(new KeyValuePair<string, string>("sourceType", "Ficheros Excel"));
                            config.sourceOptions.Add(new KeyValuePair<string, string>("excelPath", folderBrowserDialog.SelectedPath));
                            ExcelPathLabel.Text = folderBrowserDialog.SelectedPath;
                        }
                        else if (SourceComboBox.Text == "Ficheros XML")
                        {
                            config.sourceOptions.Add(new KeyValuePair<string, string>("sourceType", "Ficheros XML"));
                            config.sourceOptions.Add(new KeyValuePair<string, string>("xmlPath", folderBrowserDialog.SelectedPath));
                            XmlPathLabel.Text = folderBrowserDialog.SelectedPath;
                        }
                        else if (SourceComboBox.Text == "Ficheros JSON")
                        {
                            config.sourceOptions.Add(new KeyValuePair<string, string>("sourceType", "Ficheros JSON"));
                            config.sourceOptions.Add(new KeyValuePair<string, string>("jsonPath", folderBrowserDialog.SelectedPath));
                            XmlPathLabel.Text = folderBrowserDialog.SelectedPath;
                        }

                    }
  
                }
                RefreshUI();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un origen de datos.", "Seleccione un origen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void processComboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                RefreshComboBoxDataFromDfApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private async void RefreshComboBoxDataFromDfApi()
        {
            
            if (dfApi == null || dfApi.apiUrl != apiUrlTextBox.Text)
            {
                if (string.IsNullOrWhiteSpace(apiUrlTextBox.Text)
                || string.IsNullOrWhiteSpace(apiUserTextBox.Text)
                || string.IsNullOrWhiteSpace(apiPasswordTextBox.Text))
                {
                    MessageBox.Show("Los campos ApiUrl, Usuario y Contraseña no pueden estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dfApi = new DfApi(apiUrlTextBox.Text);

                if ( !(await dfApi.loginAsync(apiUserTextBox.Text, apiPasswordTextBox.Text)))
                {
                    MessageBox.Show("Ocurrió un error al chequear las credenciales de la Api Dokuflex. Por favor revice los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dfApi = null;
                    return;
                }

                var userGroups = await dfApi.getUserGroups();
                communityComboBox.DataSource = new BindingList<UserGroup>(userGroups);

                var process = await dfApi.getProcess();
                processComboBox.DataSource = new BindingList<Process>(process);

            }
            
        }

        private void communityComboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                RefreshComboBoxDataFromDfApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void communityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
