namespace DockerRegistryTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelEndpoint = new System.Windows.Forms.Label();
            this.chkAnonymous = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEndpoint = new System.Windows.Forms.ComboBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLayers = new System.Windows.Forms.Label();
            this.gridConfig = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLayers = new System.Windows.Forms.DataGridView();
            this.MediaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lstTags = new System.Windows.Forms.ListBox();
            this.cxtmenuTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRepositories = new System.Windows.Forms.ListBox();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayers)).BeginInit();
            this.cxtmenuTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(15, 52);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelEndpoint
            // 
            this.labelEndpoint.AutoSize = true;
            this.labelEndpoint.Location = new System.Drawing.Point(12, 15);
            this.labelEndpoint.Name = "labelEndpoint";
            this.labelEndpoint.Size = new System.Drawing.Size(52, 13);
            this.labelEndpoint.TabIndex = 2;
            this.labelEndpoint.Text = "Endpoint:";
            // 
            // chkAnonymous
            // 
            this.chkAnonymous.AutoSize = true;
            this.chkAnonymous.Checked = true;
            this.chkAnonymous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnonymous.Location = new System.Drawing.Point(344, 14);
            this.chkAnonymous.Name = "chkAnonymous";
            this.chkAnonymous.Size = new System.Drawing.Size(81, 17);
            this.chkAnonymous.TabIndex = 1;
            this.chkAnonymous.Text = "Anonymous";
            this.chkAnonymous.UseVisualStyleBackColor = true;
            this.chkAnonymous.CheckedChanged += new System.EventHandler(this.chkAnonymous_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(1004, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(165, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(1004, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(938, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 90;
            this.lblUserName.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(942, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Password:";
            // 
            // comboEndpoint
            // 
            this.comboEndpoint.FormattingEnabled = true;
            this.comboEndpoint.Items.AddRange(new object[] {
            "registry.hub.docker.com",
            "localhost:5000",
            "localhost:5001"});
            this.comboEndpoint.Location = new System.Drawing.Point(70, 12);
            this.comboEndpoint.Name = "comboEndpoint";
            this.comboEndpoint.Size = new System.Drawing.Size(233, 21);
            this.comboEndpoint.TabIndex = 0;
            this.comboEndpoint.SelectedIndexChanged += new System.EventHandler(this.comboEndpoint_SelectedIndexChanged);
            // 
            // grpControls
            // 
            this.grpControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpControls.Controls.Add(this.label2);
            this.grpControls.Controls.Add(this.lblLayers);
            this.grpControls.Controls.Add(this.gridConfig);
            this.grpControls.Controls.Add(this.gridLayers);
            this.grpControls.Controls.Add(this.lblConfig);
            this.grpControls.Controls.Add(this.lblTags);
            this.grpControls.Controls.Add(this.lstTags);
            this.grpControls.Controls.Add(this.lstRepositories);
            this.grpControls.Enabled = false;
            this.grpControls.Location = new System.Drawing.Point(13, 110);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1156, 464);
            this.grpControls.TabIndex = 6;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Repositories";
            // 
            // lblLayers
            // 
            this.lblLayers.AutoSize = true;
            this.lblLayers.Location = new System.Drawing.Point(664, 91);
            this.lblLayers.Name = "lblLayers";
            this.lblLayers.Size = new System.Drawing.Size(81, 13);
            this.lblLayers.TabIndex = 95;
            this.lblLayers.Text = "Manifest Layers";
            // 
            // gridConfig
            // 
            this.gridConfig.AllowUserToAddRows = false;
            this.gridConfig.AllowUserToDeleteRows = false;
            this.gridConfig.AllowUserToOrderColumns = true;
            this.gridConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gridConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridConfig.Location = new System.Drawing.Point(259, 32);
            this.gridConfig.Name = "gridConfig";
            this.gridConfig.RowHeadersVisible = false;
            this.gridConfig.RowHeadersWidth = 100;
            this.gridConfig.Size = new System.Drawing.Size(891, 45);
            this.gridConfig.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Media Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Digest";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridLayers
            // 
            this.gridLayers.AllowUserToAddRows = false;
            this.gridLayers.AllowUserToDeleteRows = false;
            this.gridLayers.AllowUserToOrderColumns = true;
            this.gridLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MediaType,
            this.Size,
            this.Digest});
            this.gridLayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayers.Location = new System.Drawing.Point(259, 107);
            this.gridLayers.MultiSelect = false;
            this.gridLayers.Name = "gridLayers";
            this.gridLayers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridLayers.ShowEditingIcon = false;
            this.gridLayers.ShowRowErrors = false;
            this.gridLayers.Size = new System.Drawing.Size(891, 345);
            this.gridLayers.TabIndex = 7;
            // 
            // MediaType
            // 
            this.MediaType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.MediaType.HeaderText = "Media Type";
            this.MediaType.MinimumWidth = 100;
            this.MediaType.Name = "MediaType";
            this.MediaType.ReadOnly = true;
            this.MediaType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 50;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Size.Width = 50;
            // 
            // Digest
            // 
            this.Digest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Digest.HeaderText = "Digest";
            this.Digest.Name = "Digest";
            this.Digest.ReadOnly = true;
            this.Digest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(664, 16);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(80, 13);
            this.lblConfig.TabIndex = 94;
            this.lblConfig.Text = "Manifest Config";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(178, 16);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(31, 13);
            this.lblTags.TabIndex = 93;
            this.lblTags.Text = "Tags";
            // 
            // lstTags
            // 
            this.lstTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTags.ContextMenuStrip = this.cxtmenuTags;
            this.lstTags.FormattingEnabled = true;
            this.lstTags.Location = new System.Drawing.Point(133, 32);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(120, 420);
            this.lstTags.TabIndex = 1;
            this.lstTags.SelectedIndexChanged += new System.EventHandler(this.lstTags_SelectedIndexChanged);
            // 
            // cxtmenuTags
            // 
            this.cxtmenuTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTagToolStripMenuItem});
            this.cxtmenuTags.Name = "cxtmenuTags";
            this.cxtmenuTags.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteTagToolStripMenuItem
            // 
            this.deleteTagToolStripMenuItem.Name = "deleteTagToolStripMenuItem";
            this.deleteTagToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteTagToolStripMenuItem.Text = "Delete";
            this.deleteTagToolStripMenuItem.ToolTipText = "Delete the selected Tag";
            this.deleteTagToolStripMenuItem.Click += new System.EventHandler(this.deleteTagToolStripMenuItem_Click);
            // 
            // lstRepositories
            // 
            this.lstRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRepositories.FormattingEnabled = true;
            this.lstRepositories.Location = new System.Drawing.Point(7, 32);
            this.lstRepositories.Name = "lstRepositories";
            this.lstRepositories.Size = new System.Drawing.Size(120, 420);
            this.lstRepositories.TabIndex = 0;
            this.lstRepositories.SelectedIndexChanged += new System.EventHandler(this.lstRepositories_SelectedIndexChanged);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(15, 81);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(75, 23);
            this.btnCatalog.TabIndex = 5;
            this.btnCatalog.Text = "Catalog";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 586);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.comboEndpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.chkAnonymous);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.labelEndpoint);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayers)).EndInit();
            this.cxtmenuTags.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelEndpoint;
        private System.Windows.Forms.CheckBox chkAnonymous;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEndpoint;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.ListBox lstRepositories;
        private System.Windows.Forms.ListBox lstTags;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.DataGridView gridLayers;
        private System.Windows.Forms.DataGridView gridConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digest;
        private System.Windows.Forms.Label lblLayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cxtmenuTags;
        private System.Windows.Forms.ToolStripMenuItem deleteTagToolStripMenuItem;
    }
}

