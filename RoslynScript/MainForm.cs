using RoslynScript.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoslynScript
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfigure();
            LoadExplorerCommand();
            LoadShellCommand();

            saveConfigureButton.Enabled = false;
        }

        private Configure GetConfigure()
        {
            var imports = namespacesTextBox.Lines.Select(t => t.Trim()).Where(t => t.Length > 0);

            var references = referencesTextBox.Lines.Select(t => t.Trim()).Where(t => t.Length > 0);

            return new Configure
            {
                Imports = imports.ToArray(),
                References = references.ToArray()
            };
        }
        private void LoadConfigure()
        {
            var configure = Program.GetConfigure();
            namespacesTextBox.Lines = configure.Imports;
            referencesTextBox.Lines = configure.References;
        }
        private void SaveConfigure()
        {
            var configure = GetConfigure();
            var configurePath = Program.GetConfigurePath();
            XmlUtil.WriteFile(configure, configurePath);
        }

        private const string commandName = "Roslyn Script";
        private void LoadExplorerCommand()
        {
            var programAssembly = Assembly.GetExecutingAssembly();
            var commandValue = @"""" + programAssembly.Location + @""" ""%1"" %*";

            var fileCommand = FileCommand.Get(commandName);
            var commandMatched = string.Equals(commandValue, fileCommand.Command, StringComparison.OrdinalIgnoreCase);

            addExplorerCommandCheckBox.Checked = commandMatched;
        }
        private bool SaveExplorerCommand()
        {
            try
            {
                if (addExplorerCommandCheckBox.Checked)
                {
                    var programAssembly = Assembly.GetExecutingAssembly();
                    var commandValue = @"""" + programAssembly.Location + @""" ""%1"" %*";

                    var fileCommand = new FileCommand
                    {
                        Name = commandName,
                        Command = commandValue,
                        Extension = ".cs"
                    };
                    fileCommand.Save();
                }
                else
                {
                    FileCommand.Remove(commandName);
                }
                return true;
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is SecurityException)
            {
                MessageBox.Show("Cannot access explorer without administrator right.", Text);
                return false;
            }
        }

        private const string ShellVariable = "RoslynScriptDirectory";
        private void LoadShellCommand()
        {
            var pathValue = Environment.GetEnvironmentVariable("PATH");
            var pathValues = pathValue.Split(';');
            if (pathValues.Contains(ShellVariable) == false)
            {
                addShellCommandCheckBox.Checked = false;
                return;
            }

            var programAssembly = Assembly.GetExecutingAssembly();
            var programDirectory = Path.GetDirectoryName(programAssembly.Location);

            var shellValue = Environment.GetEnvironmentVariable(ShellVariable);
            var shellMatched = string.Equals(shellValue, programDirectory, StringComparison.OrdinalIgnoreCase);

            addShellCommandCheckBox.Checked = shellMatched;
        }
        private void SaveShellCommand()
        {
            var pathValue = Environment.GetEnvironmentVariable("PATH");
            var pathValues = pathValue.Split(';');

            if (addShellCommandCheckBox.Checked)
            {
                var programAssembly = Assembly.GetExecutingAssembly();
                var programDirectory = Path.GetDirectoryName(programAssembly.Location);
                Environment.SetEnvironmentVariable(ShellVariable, programDirectory);

                if (pathValues.Contains(ShellVariable) == false)
                {
                    var includingValues = pathValues.Concat(new[] { ShellVariable });
                    var includingValue = string.Join(";", includingValues);
                    Environment.SetEnvironmentVariable(ShellVariable, includingValue);
                }
            }
            else
            {
                if (pathValues.Contains(ShellVariable))
                {
                    var remainingValues = pathValues.Except(new[] { ShellVariable });
                    var remainingValue = string.Join(";", remainingValues);
                    Environment.SetEnvironmentVariable(ShellVariable, remainingValue);
                }

                Environment.SetEnvironmentVariable(ShellVariable, string.Empty);
            }
        }

        private void namespacesTextBox_TextChanged(object sender, EventArgs e)
        {
            saveConfigureButton.Enabled = true;
        }
        private void referencesTextBox_TextChanged(object sender, EventArgs e)
        {
            saveConfigureButton.Enabled = true;
        }
        private void addExplorerCommandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saveConfigureButton.Enabled = true;
        }
        private void addShellCommandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saveConfigureButton.Enabled = true;
        }
        private void saveConfigureButton_Click(object sender, EventArgs e)
        {
            SaveConfigure();

            if (SaveExplorerCommand() == false) return;

            SaveShellCommand();

            saveConfigureButton.Enabled = false;
        }

        OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Script File|*.cs" };
        private void runScriptButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var configure = GetConfigure();

            runScriptProgressBar.Style = ProgressBarStyle.Marquee;
            runScriptButton.Enabled = false;

            runScriptWorker.RunWorkerAsync(configure);
        }
        private void runScriptWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var configure = (Configure)e.Argument;

            Program.RunScript(openFileDialog.FileName, configure);
        }
        private void runScriptWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            runScriptProgressBar.Style = ProgressBarStyle.Blocks;
            runScriptButton.Enabled = true;
        }
    }
}
