namespace GDN_LOGTEST
{
    partial class LOGTEST_F
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
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.L_USERNAME = new System.Windows.Forms.Label();
            this.L_PASSWORD = new System.Windows.Forms.Label();
            this.G_KEY = new System.Windows.Forms.GroupBox();
            this.B_GDNLOGTEST_SEARCH = new System.Windows.Forms.Button();
            this.B_OK_KEY = new System.Windows.Forms.Button();
            this.G_DATA = new System.Windows.Forms.GroupBox();
            this.B_OK_DATA = new System.Windows.Forms.Button();
            this.P_CONTROLS_DATA = new System.Windows.Forms.Panel();
            this.B_MODE = new System.Windows.Forms.Button();
            this.G_KEY.SuspendLayout();
            this.G_DATA.SuspendLayout();
            this.P_CONTROLS_DATA.SuspendLayout();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(184, 20);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(257, 22);
            this.USERNAME.TabIndex = 1;
            this.USERNAME.Text = "12345678901234567890";
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(184, 20);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(257, 22);
            this.PASSWORD.TabIndex = 3;
            this.PASSWORD.Text = "12345678901234567890";
            // 
            // L_USERNAME
            // 
            this.L_USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_USERNAME.Location = new System.Drawing.Point(8, 20);
            this.L_USERNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_USERNAME.Name = "L_USERNAME";
            this.L_USERNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_USERNAME.Size = new System.Drawing.Size(173, 27);
            this.L_USERNAME.TabIndex = 0;
            this.L_USERNAME.Text = "User name";
            this.L_USERNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_PASSWORD
            // 
            this.L_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PASSWORD.Location = new System.Drawing.Point(8, 20);
            this.L_PASSWORD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_PASSWORD.Name = "L_PASSWORD";
            this.L_PASSWORD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_PASSWORD.Size = new System.Drawing.Size(173, 27);
            this.L_PASSWORD.TabIndex = 2;
            this.L_PASSWORD.Text = "Passowrd";
            this.L_PASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // G_KEY
            // 
            this.G_KEY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_KEY.Controls.Add(this.B_GDNLOGTEST_SEARCH);
            this.G_KEY.Controls.Add(this.B_OK_KEY);
            this.G_KEY.Controls.Add(this.L_USERNAME);
            this.G_KEY.Controls.Add(this.USERNAME);
            this.G_KEY.Location = new System.Drawing.Point(17, 93);
            this.G_KEY.Margin = new System.Windows.Forms.Padding(4);
            this.G_KEY.Name = "G_KEY";
            this.G_KEY.Padding = new System.Windows.Forms.Padding(4);
            this.G_KEY.Size = new System.Drawing.Size(654, 146);
            this.G_KEY.TabIndex = 0;
            this.G_KEY.TabStop = false;
            this.G_KEY.Text = "KEY";
            // 
            // B_GDNLOGTEST_SEARCH
            // 
            this.B_GDNLOGTEST_SEARCH.BackgroundImage = global::GDN_LOGTEST.Properties.Resources.search;
            this.B_GDNLOGTEST_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_GDNLOGTEST_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_GDNLOGTEST_SEARCH.Location = new System.Drawing.Point(444, 20);
            this.B_GDNLOGTEST_SEARCH.Name = "B_GDNLOGTEST_SEARCH";
            this.B_GDNLOGTEST_SEARCH.Size = new System.Drawing.Size(22, 22);
            this.B_GDNLOGTEST_SEARCH.TabIndex = 5;
            this.B_GDNLOGTEST_SEARCH.UseVisualStyleBackColor = true;
            this.B_GDNLOGTEST_SEARCH.Click += new System.EventHandler(this.B_GDNLOGTEST_SEARCH_Click);
            // 
            // B_OK_KEY
            // 
            this.B_OK_KEY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_OK_KEY.Location = new System.Drawing.Point(542, 112);
            this.B_OK_KEY.Margin = new System.Windows.Forms.Padding(4);
            this.B_OK_KEY.Name = "B_OK_KEY";
            this.B_OK_KEY.Size = new System.Drawing.Size(100, 27);
            this.B_OK_KEY.TabIndex = 4;
            this.B_OK_KEY.Text = "OK";
            this.B_OK_KEY.UseVisualStyleBackColor = true;
            this.B_OK_KEY.Click += new System.EventHandler(this.B_OK_KEY_Click);
            // 
            // G_DATA
            // 
            this.G_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_DATA.Controls.Add(this.L_PASSWORD);
            this.G_DATA.Controls.Add(this.PASSWORD);
            this.G_DATA.Location = new System.Drawing.Point(17, 247);
            this.G_DATA.Margin = new System.Windows.Forms.Padding(4);
            this.G_DATA.Name = "G_DATA";
            this.G_DATA.Padding = new System.Windows.Forms.Padding(4);
            this.G_DATA.Size = new System.Drawing.Size(653, 408);
            this.G_DATA.TabIndex = 1;
            this.G_DATA.TabStop = false;
            this.G_DATA.Text = "DATA";
            // 
            // B_OK_DATA
            // 
            this.B_OK_DATA.Dock = System.Windows.Forms.DockStyle.Left;
            this.B_OK_DATA.Location = new System.Drawing.Point(0, 0);
            this.B_OK_DATA.Margin = new System.Windows.Forms.Padding(4);
            this.B_OK_DATA.Name = "B_OK_DATA";
            this.B_OK_DATA.Size = new System.Drawing.Size(100, 27);
            this.B_OK_DATA.TabIndex = 4;
            this.B_OK_DATA.Text = "OK";
            this.B_OK_DATA.UseVisualStyleBackColor = true;
            this.B_OK_DATA.Click += new System.EventHandler(this.B_OK_DATA_Click);
            // 
            // P_CONTROLS_DATA
            // 
            this.P_CONTROLS_DATA.Controls.Add(this.B_OK_DATA);
            this.P_CONTROLS_DATA.Location = new System.Drawing.Point(558, 564);
            this.P_CONTROLS_DATA.Margin = new System.Windows.Forms.Padding(4);
            this.P_CONTROLS_DATA.Name = "P_CONTROLS_DATA";
            this.P_CONTROLS_DATA.Size = new System.Drawing.Size(100, 27);
            this.P_CONTROLS_DATA.TabIndex = 4;
            // 
            // B_MODE
            // 
            this.B_MODE.Location = new System.Drawing.Point(13, 13);
            this.B_MODE.Name = "B_MODE";
            this.B_MODE.Size = new System.Drawing.Size(100, 50);
            this.B_MODE.TabIndex = 5;
            this.B_MODE.Text = "Mode";
            this.B_MODE.UseVisualStyleBackColor = true;
            this.B_MODE.Click += new System.EventHandler(this.B_MODE_Click);
            // 
            // LOGTEST_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 668);
            this.Controls.Add(this.B_MODE);
            this.Controls.Add(this.P_CONTROLS_DATA);
            this.Controls.Add(this.G_DATA);
            this.Controls.Add(this.G_KEY);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LOGTEST_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGTEST_F";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGTEST_F_FormClosing);
            this.Load += new System.EventHandler(this.LOGTEST_F_Load);
            this.Shown += new System.EventHandler(this.LOGTEST_F_Shown);
            this.G_KEY.ResumeLayout(false);
            this.G_KEY.PerformLayout();
            this.G_DATA.ResumeLayout(false);
            this.G_DATA.PerformLayout();
            this.P_CONTROLS_DATA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.Label L_USERNAME;
        private System.Windows.Forms.Label L_PASSWORD;
        private System.Windows.Forms.GroupBox G_KEY;
        private System.Windows.Forms.GroupBox G_DATA;
        private System.Windows.Forms.Button B_OK_KEY;
        private System.Windows.Forms.Button B_OK_DATA;
        private System.Windows.Forms.Panel P_CONTROLS_DATA;
        private System.Windows.Forms.Button B_GDNLOGTEST_SEARCH;
        private System.Windows.Forms.Button B_MODE;
    }
}

