namespace GDN_LOGTEST
{
    partial class SEARCH_S
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
            this.G_TABLE = new System.Windows.Forms.GroupBox();
            this.DGV_ACCOUNT = new System.Windows.Forms.DataGridView();
            this.COL_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_KEY = new System.Windows.Forms.GroupBox();
            this.B_KEY_OK = new System.Windows.Forms.Button();
            this.L_SEARCH = new System.Windows.Forms.Label();
            this.SEARCH = new System.Windows.Forms.TextBox();
            this.G_TABLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ACCOUNT)).BeginInit();
            this.G_KEY.SuspendLayout();
            this.SuspendLayout();
            // 
            // G_TABLE
            // 
            this.G_TABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_TABLE.Controls.Add(this.DGV_ACCOUNT);
            this.G_TABLE.Location = new System.Drawing.Point(18, 125);
            this.G_TABLE.Name = "G_TABLE";
            this.G_TABLE.Size = new System.Drawing.Size(455, 482);
            this.G_TABLE.TabIndex = 4;
            this.G_TABLE.TabStop = false;
            this.G_TABLE.Text = "ACCOUNTS";
            // 
            // DGV_ACCOUNT
            // 
            this.DGV_ACCOUNT.AllowUserToAddRows = false;
            this.DGV_ACCOUNT.AllowUserToDeleteRows = false;
            this.DGV_ACCOUNT.AllowUserToResizeColumns = false;
            this.DGV_ACCOUNT.AllowUserToResizeRows = false;
            this.DGV_ACCOUNT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ACCOUNT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ACCOUNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ACCOUNT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_USERNAME,
            this.COL_PASSWORD});
            this.DGV_ACCOUNT.GridColor = System.Drawing.SystemColors.Desktop;
            this.DGV_ACCOUNT.Location = new System.Drawing.Point(6, 19);
            this.DGV_ACCOUNT.Name = "DGV_ACCOUNT";
            this.DGV_ACCOUNT.ReadOnly = true;
            this.DGV_ACCOUNT.Size = new System.Drawing.Size(443, 457);
            this.DGV_ACCOUNT.TabIndex = 0;
            this.DGV_ACCOUNT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ACCOUNT_CellDoubleClick);
            // 
            // COL_USERNAME
            // 
            this.COL_USERNAME.DataPropertyName = "USERNAME";
            this.COL_USERNAME.HeaderText = "USERNAME";
            this.COL_USERNAME.Name = "COL_USERNAME";
            this.COL_USERNAME.ReadOnly = true;
            this.COL_USERNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // COL_PASSWORD
            // 
            this.COL_PASSWORD.DataPropertyName = "PASSWORD";
            this.COL_PASSWORD.HeaderText = "PASSWORD";
            this.COL_PASSWORD.Name = "COL_PASSWORD";
            this.COL_PASSWORD.ReadOnly = true;
            // 
            // G_KEY
            // 
            this.G_KEY.Controls.Add(this.B_KEY_OK);
            this.G_KEY.Controls.Add(this.L_SEARCH);
            this.G_KEY.Controls.Add(this.SEARCH);
            this.G_KEY.Location = new System.Drawing.Point(18, 13);
            this.G_KEY.Name = "G_KEY";
            this.G_KEY.Size = new System.Drawing.Size(444, 112);
            this.G_KEY.TabIndex = 5;
            this.G_KEY.TabStop = false;
            this.G_KEY.Text = "KEY";
            // 
            // B_KEY_OK
            // 
            this.B_KEY_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_KEY_OK.Location = new System.Drawing.Point(337, 78);
            this.B_KEY_OK.Margin = new System.Windows.Forms.Padding(4);
            this.B_KEY_OK.Name = "B_KEY_OK";
            this.B_KEY_OK.Size = new System.Drawing.Size(100, 27);
            this.B_KEY_OK.TabIndex = 7;
            this.B_KEY_OK.Text = "OK";
            this.B_KEY_OK.UseVisualStyleBackColor = true;
            this.B_KEY_OK.Click += new System.EventHandler(this.B_KEY_OK_Click);
            // 
            // L_SEARCH
            // 
            this.L_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SEARCH.Location = new System.Drawing.Point(7, 16);
            this.L_SEARCH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_SEARCH.Name = "L_SEARCH";
            this.L_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_SEARCH.Size = new System.Drawing.Size(173, 27);
            this.L_SEARCH.TabIndex = 5;
            this.L_SEARCH.Text = "Search key";
            this.L_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SEARCH
            // 
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(184, 18);
            this.SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(254, 22);
            this.SEARCH.TabIndex = 6;
            this.SEARCH.Text = "12345678901234567890";
            // 
            // SEARCH_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 619);
            this.Controls.Add(this.G_KEY);
            this.Controls.Add(this.G_TABLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SEARCH_S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SEARCH_S";
            this.Shown += new System.EventHandler(this.SEARCH_S_Shown);
            this.G_TABLE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ACCOUNT)).EndInit();
            this.G_KEY.ResumeLayout(false);
            this.G_KEY.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox G_TABLE;
        private System.Windows.Forms.DataGridView DGV_ACCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PASSWORD;
        private System.Windows.Forms.GroupBox G_KEY;
        private System.Windows.Forms.Button B_KEY_OK;
        private System.Windows.Forms.Label L_SEARCH;
        private System.Windows.Forms.TextBox SEARCH;
    }
}