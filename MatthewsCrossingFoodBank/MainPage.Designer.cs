namespace MatthewsCrossingFoodBank
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.txtFilenamePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.dataGridViewEntries = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.BackColor = System.Drawing.Color.Lime;
            this.btnSendEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmails.Location = new System.Drawing.Point(463, 477);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmails.TabIndex = 0;
            this.btnSendEmails.Text = "Send Emails";
            this.btnSendEmails.UseVisualStyleBackColor = false;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // txtFilenamePath
            // 
            this.txtFilenamePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilenamePath.Location = new System.Drawing.Point(200, 250);
            this.txtFilenamePath.Name = "txtFilenamePath";
            this.txtFilenamePath.ReadOnly = true;
            this.txtFilenamePath.Size = new System.Drawing.Size(257, 20);
            this.txtFilenamePath.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(463, 248);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 189);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Location = new System.Drawing.Point(200, 231);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(132, 13);
            this.lblOpenFile.TabIndex = 5;
            this.lblOpenFile.Text = "Chose a CSV file to import:";
            // 
            // dataGridViewEntries
            // 
            this.dataGridViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colAmount});
            this.dataGridViewEntries.Location = new System.Drawing.Point(217, 299);
            this.dataGridViewEntries.Name = "dataGridViewEntries";
            this.dataGridViewEntries.Size = new System.Drawing.Size(340, 150);
            this.dataGridViewEntries.TabIndex = 6;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First name";
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Location = new System.Drawing.Point(217, 477);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEntry.TabIndex = 7;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(779, 581);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.dataGridViewEntries);
            this.Controls.Add(this.lblOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFilenamePath);
            this.Controls.Add(this.btnSendEmails);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.TextBox txtFilenamePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.DataGridView dataGridViewEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Button btnDeleteEntry;
    }
}