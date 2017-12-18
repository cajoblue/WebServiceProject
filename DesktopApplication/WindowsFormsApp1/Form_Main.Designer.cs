﻿namespace WindowsFormsApp1
{
    partial class Form_Main
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxIMC = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.minAge = new System.Windows.Forms.Label();
            this.maxAge = new System.Windows.Forms.NumericUpDown();
            this.minIMC = new System.Windows.Forms.NumericUpDown();
            this.searchAge_UpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_SearchImc = new System.Windows.Forms.Button();
            this.btn_SearchAge = new System.Windows.Forms.Button();
            this.btn_SearchName = new System.Windows.Forms.Button();
            this.searchBloodComp_cbx = new System.Windows.Forms.ComboBox();
            this.searchBloodType_cbx = new System.Windows.Forms.ComboBox();
            this.searchName_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateList = new System.Windows.Forms.Button();
            this.btn_AddDonor = new System.Windows.Forms.Button();
            this.btn_DeleteDonor = new System.Windows.Forms.Button();
            this.btn_DonorDetails = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAge_UpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(809, 425);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GivenName";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 215;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Age";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BloodType";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IMC";
            this.columnHeader6.Width = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asXMLToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // asXMLToolStripMenuItem
            // 
            this.asXMLToolStripMenuItem.Name = "asXMLToolStripMenuItem";
            this.asXMLToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.asXMLToolStripMenuItem.Text = "As XML";
            this.asXMLToolStripMenuItem.Click += new System.EventHandler(this.asXMLToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxIMC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.minAge);
            this.groupBox1.Controls.Add(this.maxAge);
            this.groupBox1.Controls.Add(this.minIMC);
            this.groupBox1.Controls.Add(this.searchAge_UpDown);
            this.groupBox1.Controls.Add(this.btn_SearchImc);
            this.groupBox1.Controls.Add(this.btn_SearchAge);
            this.groupBox1.Controls.Add(this.btn_SearchName);
            this.groupBox1.Controls.Add(this.searchBloodComp_cbx);
            this.groupBox1.Controls.Add(this.searchBloodType_cbx);
            this.groupBox1.Controls.Add(this.searchName_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(825, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search donors by";
            // 
            // maxIMC
            // 
            this.maxIMC.DecimalPlaces = 2;
            this.maxIMC.Location = new System.Drawing.Point(146, 117);
            this.maxIMC.Name = "maxIMC";
            this.maxIMC.Size = new System.Drawing.Size(50, 20);
            this.maxIMC.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max";
            // 
            // minAge
            // 
            this.minAge.AutoSize = true;
            this.minAge.Location = new System.Drawing.Point(62, 61);
            this.minAge.Name = "minAge";
            this.minAge.Size = new System.Drawing.Size(24, 13);
            this.minAge.TabIndex = 16;
            this.minAge.Text = "Min";
            // 
            // maxAge
            // 
            this.maxAge.Location = new System.Drawing.Point(146, 76);
            this.maxAge.Name = "maxAge";
            this.maxAge.Size = new System.Drawing.Size(50, 20);
            this.maxAge.TabIndex = 15;
            // 
            // minIMC
            // 
            this.minIMC.DecimalPlaces = 2;
            this.minIMC.Location = new System.Drawing.Point(53, 118);
            this.minIMC.Name = "minIMC";
            this.minIMC.Size = new System.Drawing.Size(73, 20);
            this.minIMC.TabIndex = 14;
            // 
            // searchAge_UpDown
            // 
            this.searchAge_UpDown.Location = new System.Drawing.Point(53, 77);
            this.searchAge_UpDown.Name = "searchAge_UpDown";
            this.searchAge_UpDown.Size = new System.Drawing.Size(73, 20);
            this.searchAge_UpDown.TabIndex = 13;
            // 
            // btn_SearchImc
            // 
            this.btn_SearchImc.Location = new System.Drawing.Point(214, 117);
            this.btn_SearchImc.Name = "btn_SearchImc";
            this.btn_SearchImc.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchImc.TabIndex = 12;
            this.btn_SearchImc.Text = "Search";
            this.btn_SearchImc.UseVisualStyleBackColor = true;
            this.btn_SearchImc.Click += new System.EventHandler(this.btn_SearchImc_Click);
            // 
            // btn_SearchAge
            // 
            this.btn_SearchAge.Location = new System.Drawing.Point(214, 76);
            this.btn_SearchAge.Name = "btn_SearchAge";
            this.btn_SearchAge.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchAge.TabIndex = 11;
            this.btn_SearchAge.Text = "Search";
            this.btn_SearchAge.UseVisualStyleBackColor = true;
            this.btn_SearchAge.Click += new System.EventHandler(this.btn_SearchAge_Click);
            // 
            // btn_SearchName
            // 
            this.btn_SearchName.Location = new System.Drawing.Point(214, 35);
            this.btn_SearchName.Name = "btn_SearchName";
            this.btn_SearchName.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchName.TabIndex = 10;
            this.btn_SearchName.Text = "Search";
            this.btn_SearchName.UseVisualStyleBackColor = true;
            this.btn_SearchName.Click += new System.EventHandler(this.btn_SearchName_Click);
            // 
            // searchBloodComp_cbx
            // 
            this.searchBloodComp_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBloodComp_cbx.FormattingEnabled = true;
            this.searchBloodComp_cbx.Location = new System.Drawing.Point(132, 200);
            this.searchBloodComp_cbx.Name = "searchBloodComp_cbx";
            this.searchBloodComp_cbx.Size = new System.Drawing.Size(157, 21);
            this.searchBloodComp_cbx.TabIndex = 9;
            this.searchBloodComp_cbx.SelectedIndexChanged += new System.EventHandler(this.searchBloodComp_cbx_SelectedIndexChanged);
            // 
            // searchBloodType_cbx
            // 
            this.searchBloodType_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBloodType_cbx.FormattingEnabled = true;
            this.searchBloodType_cbx.Location = new System.Drawing.Point(132, 159);
            this.searchBloodType_cbx.Name = "searchBloodType_cbx";
            this.searchBloodType_cbx.Size = new System.Drawing.Size(157, 21);
            this.searchBloodType_cbx.TabIndex = 8;
            this.searchBloodType_cbx.SelectedIndexChanged += new System.EventHandler(this.searchBloodType_cbx_SelectedIndexChanged);
            // 
            // searchName_tb
            // 
            this.searchName_tb.Location = new System.Drawing.Point(53, 36);
            this.searchName_tb.Name = "searchName_tb";
            this.searchName_tb.Size = new System.Drawing.Size(143, 20);
            this.searchName_tb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BloodGroup compatible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BloodType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_UpdateList);
            this.groupBox2.Controls.Add(this.btn_AddDonor);
            this.groupBox2.Controls.Add(this.btn_DeleteDonor);
            this.groupBox2.Controls.Add(this.btn_DonorDetails);
            this.groupBox2.Location = new System.Drawing.Point(825, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other options";
            // 
            // btn_UpdateList
            // 
            this.btn_UpdateList.Location = new System.Drawing.Point(167, 86);
            this.btn_UpdateList.Name = "btn_UpdateList";
            this.btn_UpdateList.Size = new System.Drawing.Size(82, 40);
            this.btn_UpdateList.TabIndex = 3;
            this.btn_UpdateList.Text = "Update list";
            this.btn_UpdateList.UseVisualStyleBackColor = true;
            this.btn_UpdateList.Click += new System.EventHandler(this.btn_UpdateList_Click);
            // 
            // btn_AddDonor
            // 
            this.btn_AddDonor.Location = new System.Drawing.Point(51, 86);
            this.btn_AddDonor.Name = "btn_AddDonor";
            this.btn_AddDonor.Size = new System.Drawing.Size(82, 40);
            this.btn_AddDonor.TabIndex = 2;
            this.btn_AddDonor.Text = "Add donor";
            this.btn_AddDonor.UseVisualStyleBackColor = true;
            this.btn_AddDonor.Click += new System.EventHandler(this.btn_AddDonor_Click);
            // 
            // btn_DeleteDonor
            // 
            this.btn_DeleteDonor.Location = new System.Drawing.Point(167, 31);
            this.btn_DeleteDonor.Name = "btn_DeleteDonor";
            this.btn_DeleteDonor.Size = new System.Drawing.Size(82, 40);
            this.btn_DeleteDonor.TabIndex = 1;
            this.btn_DeleteDonor.Text = "Delete donor";
            this.btn_DeleteDonor.UseVisualStyleBackColor = true;
            this.btn_DeleteDonor.Click += new System.EventHandler(this.btn_DeleteDonor_Click);
            // 
            // btn_DonorDetails
            // 
            this.btn_DonorDetails.Location = new System.Drawing.Point(51, 31);
            this.btn_DonorDetails.Name = "btn_DonorDetails";
            this.btn_DonorDetails.Size = new System.Drawing.Size(82, 40);
            this.btn_DonorDetails.TabIndex = 0;
            this.btn_DonorDetails.Text = "Donor details";
            this.btn_DonorDetails.UseVisualStyleBackColor = true;
            this.btn_DonorDetails.Click += new System.EventHandler(this.btn_DonorDetails_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "BloodCrowd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAge_UpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown minIMC;
        private System.Windows.Forms.NumericUpDown searchAge_UpDown;
        private System.Windows.Forms.Button btn_SearchImc;
        private System.Windows.Forms.Button btn_SearchAge;
        private System.Windows.Forms.Button btn_SearchName;
        private System.Windows.Forms.ComboBox searchBloodComp_cbx;
        private System.Windows.Forms.ComboBox searchBloodType_cbx;
        private System.Windows.Forms.TextBox searchName_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_UpdateList;
        private System.Windows.Forms.Button btn_AddDonor;
        private System.Windows.Forms.Button btn_DeleteDonor;
        private System.Windows.Forms.Button btn_DonorDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minAge;
        private System.Windows.Forms.NumericUpDown maxAge;
        private System.Windows.Forms.NumericUpDown maxIMC;
    }
}

