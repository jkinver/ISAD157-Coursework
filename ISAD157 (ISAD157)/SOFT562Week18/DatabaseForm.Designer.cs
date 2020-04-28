namespace SOFT562Week18
{
    partial class DatabaseForm
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.comboBoxQueryChoice = new System.Windows.Forms.ComboBox();
            this.dataGridViewWorkplaces = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchoolOrUni = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolOrUni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(20, 15);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(368, 370);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Location = new System.Drawing.Point(414, 15);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.RowHeadersWidth = 51;
            this.dataGridViewFriends.RowTemplate.Height = 24;
            this.dataGridViewFriends.Size = new System.Drawing.Size(368, 370);
            this.dataGridViewFriends.TabIndex = 1;
            // 
            // comboBoxQueryChoice
            // 
            this.comboBoxQueryChoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQueryChoice.FormattingEnabled = true;
            this.comboBoxQueryChoice.Items.AddRange(new object[] {
            "Users Table",
            "Friends Table",
            "Workplaces Table",
            "Schools/Universities Table",
            "Messages Table"});
            this.comboBoxQueryChoice.Location = new System.Drawing.Point(20, 767);
            this.comboBoxQueryChoice.Name = "comboBoxQueryChoice";
            this.comboBoxQueryChoice.Size = new System.Drawing.Size(762, 34);
            this.comboBoxQueryChoice.TabIndex = 2;
            this.comboBoxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryChoice_SelectedIndexChanged);
            // 
            // dataGridViewWorkplaces
            // 
            this.dataGridViewWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplaces.Location = new System.Drawing.Point(804, 15);
            this.dataGridViewWorkplaces.Name = "dataGridViewWorkplaces";
            this.dataGridViewWorkplaces.RowHeadersWidth = 51;
            this.dataGridViewWorkplaces.RowTemplate.Height = 24;
            this.dataGridViewWorkplaces.Size = new System.Drawing.Size(368, 370);
            this.dataGridViewWorkplaces.TabIndex = 3;
            // 
            // dataGridViewSchoolOrUni
            // 
            this.dataGridViewSchoolOrUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchoolOrUni.Location = new System.Drawing.Point(20, 391);
            this.dataGridViewSchoolOrUni.Name = "dataGridViewSchoolOrUni";
            this.dataGridViewSchoolOrUni.RowHeadersWidth = 51;
            this.dataGridViewSchoolOrUni.RowTemplate.Height = 24;
            this.dataGridViewSchoolOrUni.Size = new System.Drawing.Size(368, 370);
            this.dataGridViewSchoolOrUni.TabIndex = 4;
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(414, 391);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.RowHeadersWidth = 51;
            this.dataGridViewMessages.RowTemplate.Height = 24;
            this.dataGridViewMessages.Size = new System.Drawing.Size(368, 370);
            this.dataGridViewMessages.TabIndex = 5;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 813);
            this.Controls.Add(this.dataGridViewMessages);
            this.Controls.Add(this.dataGridViewSchoolOrUni);
            this.Controls.Add(this.dataGridViewWorkplaces);
            this.Controls.Add(this.comboBoxQueryChoice);
            this.Controls.Add(this.dataGridViewFriends);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "DatabaseForm";
            this.Text = "Database Form Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolOrUni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.ComboBox comboBoxQueryChoice;
        private System.Windows.Forms.DataGridView dataGridViewWorkplaces;
        private System.Windows.Forms.DataGridView dataGridViewSchoolOrUni;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
    }
}

