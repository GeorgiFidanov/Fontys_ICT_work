﻿
namespace Bakery
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnShowOfferedSandwiches = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cbbBreadFilter = new System.Windows.Forms.ComboBox();
            btnAddSandwich = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lbxMenu = new System.Windows.Forms.ListBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            chkIncludeVAT = new System.Windows.Forms.CheckBox();
            lstSandwiches = new System.Windows.Forms.ListBox();
            btnRevenue = new System.Windows.Forms.Button();
            btnSell = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowOfferedSandwiches);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbBreadFilter);
            groupBox1.Controls.Add(btnAddSandwich);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(lbxMenu);
            groupBox1.Location = new System.Drawing.Point(7, 1);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox1.Size = new System.Drawing.Size(345, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnShowOfferedSandwiches
            // 
            btnShowOfferedSandwiches.Location = new System.Drawing.Point(5, 52);
            btnShowOfferedSandwiches.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            btnShowOfferedSandwiches.Size = new System.Drawing.Size(337, 29);
            btnShowOfferedSandwiches.TabIndex = 6;
            btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            btnShowOfferedSandwiches.Click += btnShowOfferedSandwiches_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 27);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Bread filter:";
            // 
            // cbbBreadFilter
            // 
            cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbBreadFilter.FormattingEnabled = true;
            cbbBreadFilter.Location = new System.Drawing.Point(86, 24);
            cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cbbBreadFilter.Name = "cbbBreadFilter";
            cbbBreadFilter.Size = new System.Drawing.Size(255, 28);
            cbbBreadFilter.TabIndex = 4;
            // 
            // btnAddSandwich
            // 
            btnAddSandwich.Location = new System.Drawing.Point(5, 219);
            btnAddSandwich.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnAddSandwich.Name = "btnAddSandwich";
            btnAddSandwich.Size = new System.Drawing.Size(337, 29);
            btnAddSandwich.TabIndex = 3;
            btnAddSandwich.Text = "Add new Sandwich";
            btnAddSandwich.UseVisualStyleBackColor = true;
            btnAddSandwich.Click += btnAddSandwich_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(174, 251);
            btnLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(167, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(5, 251);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(166, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save data";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbxMenu
            // 
            lbxMenu.FormattingEnabled = true;
            lbxMenu.ItemHeight = 20;
            lbxMenu.Location = new System.Drawing.Point(5, 85);
            lbxMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            lbxMenu.Name = "lbxMenu";
            lbxMenu.Size = new System.Drawing.Size(339, 124);
            lbxMenu.TabIndex = 0;
            lbxMenu.SelectedIndexChanged += lbxMenu_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkIncludeVAT);
            groupBox2.Controls.Add(lstSandwiches);
            groupBox2.Controls.Add(btnRevenue);
            groupBox2.Controls.Add(btnSell);
            groupBox2.Location = new System.Drawing.Point(362, 1);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Size = new System.Drawing.Size(299, 284);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cart";
            // 
            // chkIncludeVAT
            // 
            chkIncludeVAT.AutoSize = true;
            chkIncludeVAT.Location = new System.Drawing.Point(5, 194);
            chkIncludeVAT.Name = "chkIncludeVAT";
            chkIncludeVAT.Size = new System.Drawing.Size(108, 24);
            chkIncludeVAT.TabIndex = 4;
            chkIncludeVAT.Text = "Include VAT";
            chkIncludeVAT.UseVisualStyleBackColor = true;
            // 
            // lstSandwiches
            // 
            lstSandwiches.FormattingEnabled = true;
            lstSandwiches.ItemHeight = 20;
            lstSandwiches.Location = new System.Drawing.Point(5, 24);
            lstSandwiches.Name = "lstSandwiches";
            lstSandwiches.Size = new System.Drawing.Size(289, 164);
            lstSandwiches.TabIndex = 3;
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new System.Drawing.Point(5, 251);
            btnRevenue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new System.Drawing.Size(293, 29);
            btnRevenue.TabIndex = 2;
            btnRevenue.Text = "Show total revenue";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnSell
            // 
            btnSell.Location = new System.Drawing.Point(5, 219);
            btnSell.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSell.Name = "btnSell";
            btnSell.Size = new System.Drawing.Size(293, 29);
            btnSell.TabIndex = 1;
            btnSell.Text = "Sell selected sandwhich";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(673, 293);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnAddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
        private System.Windows.Forms.ListBox lstSandwiches;
        private System.Windows.Forms.CheckBox chkIncludeVAT;
    }
}