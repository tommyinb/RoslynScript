namespace RoslynScript
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addExplorerCommandCheckBox = new System.Windows.Forms.CheckBox();
            this.addShellCommandCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.namespacesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.referencesTextBox = new System.Windows.Forms.TextBox();
            this.saveConfigureButton = new System.Windows.Forms.Button();
            this.runScriptButton = new System.Windows.Forms.Button();
            this.runScriptWorker = new System.ComponentModel.BackgroundWorker();
            this.runScriptProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 368);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 66);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Explorer Integration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.addExplorerCommandCheckBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addShellCommandCheckBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // addExplorerCommandCheckBox
            // 
            this.addExplorerCommandCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addExplorerCommandCheckBox.AutoSize = true;
            this.addExplorerCommandCheckBox.Location = new System.Drawing.Point(3, 3);
            this.addExplorerCommandCheckBox.Name = "addExplorerCommandCheckBox";
            this.addExplorerCommandCheckBox.Size = new System.Drawing.Size(161, 17);
            this.addExplorerCommandCheckBox.TabIndex = 0;
            this.addExplorerCommandCheckBox.Text = "add command to file explorer";
            this.addExplorerCommandCheckBox.UseVisualStyleBackColor = true;
            this.addExplorerCommandCheckBox.CheckedChanged += new System.EventHandler(this.addExplorerCommandCheckBox_CheckedChanged);
            // 
            // addShellCommandCheckBox
            // 
            this.addShellCommandCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addShellCommandCheckBox.AutoSize = true;
            this.addShellCommandCheckBox.Location = new System.Drawing.Point(3, 26);
            this.addShellCommandCheckBox.Name = "addShellCommandCheckBox";
            this.addShellCommandCheckBox.Size = new System.Drawing.Size(129, 17);
            this.addShellCommandCheckBox.TabIndex = 1;
            this.addShellCommandCheckBox.Text = "add command to shell";
            this.addShellCommandCheckBox.UseVisualStyleBackColor = true;
            this.addShellCommandCheckBox.CheckedChanged += new System.EventHandler(this.addShellCommandCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.namespacesTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Namespaces";
            // 
            // namespacesTextBox
            // 
            this.namespacesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namespacesTextBox.Location = new System.Drawing.Point(3, 16);
            this.namespacesTextBox.Multiline = true;
            this.namespacesTextBox.Name = "namespacesTextBox";
            this.namespacesTextBox.Size = new System.Drawing.Size(332, 153);
            this.namespacesTextBox.TabIndex = 0;
            this.namespacesTextBox.TextChanged += new System.EventHandler(this.namespacesTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.referencesTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script Dependencies";
            // 
            // referencesTextBox
            // 
            this.referencesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referencesTextBox.Location = new System.Drawing.Point(3, 16);
            this.referencesTextBox.Multiline = true;
            this.referencesTextBox.Name = "referencesTextBox";
            this.referencesTextBox.Size = new System.Drawing.Size(332, 93);
            this.referencesTextBox.TabIndex = 0;
            this.referencesTextBox.TextChanged += new System.EventHandler(this.referencesTextBox_TextChanged);
            // 
            // saveConfigureButton
            // 
            this.saveConfigureButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveConfigureButton.Location = new System.Drawing.Point(0, 368);
            this.saveConfigureButton.Name = "saveConfigureButton";
            this.saveConfigureButton.Size = new System.Drawing.Size(344, 23);
            this.saveConfigureButton.TabIndex = 0;
            this.saveConfigureButton.Text = "Save Configure";
            this.saveConfigureButton.UseVisualStyleBackColor = true;
            this.saveConfigureButton.Click += new System.EventHandler(this.saveConfigureButton_Click);
            // 
            // runScriptButton
            // 
            this.runScriptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.runScriptButton.Location = new System.Drawing.Point(0, 391);
            this.runScriptButton.Name = "runScriptButton";
            this.runScriptButton.Size = new System.Drawing.Size(344, 23);
            this.runScriptButton.TabIndex = 0;
            this.runScriptButton.Text = "Run Script";
            this.runScriptButton.UseVisualStyleBackColor = true;
            this.runScriptButton.Click += new System.EventHandler(this.runScriptButton_Click);
            // 
            // runScriptWorker
            // 
            this.runScriptWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runScriptWorker_DoWork);
            this.runScriptWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.runScriptWorker_RunWorkerCompleted);
            // 
            // runScriptProgressBar
            // 
            this.runScriptProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.runScriptProgressBar.Location = new System.Drawing.Point(0, 414);
            this.runScriptProgressBar.Name = "runScriptProgressBar";
            this.runScriptProgressBar.Size = new System.Drawing.Size(344, 10);
            this.runScriptProgressBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.saveConfigureButton);
            this.Controls.Add(this.runScriptButton);
            this.Controls.Add(this.runScriptProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Roslyn Script";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox addExplorerCommandCheckBox;
        private System.Windows.Forms.CheckBox addShellCommandCheckBox;
        private System.Windows.Forms.Button saveConfigureButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox namespacesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox referencesTextBox;
        private System.Windows.Forms.Button runScriptButton;
        private System.ComponentModel.BackgroundWorker runScriptWorker;
        private System.Windows.Forms.ProgressBar runScriptProgressBar;
    }
}