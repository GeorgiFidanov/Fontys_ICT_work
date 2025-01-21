
namespace BickingTrip
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
            lbxMyTrips = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            nudRating = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            nudDistance = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbxTo = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnShowAll = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbxSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            gbxActions = new System.Windows.Forms.GroupBox();
            btnInfo = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistance).BeginInit();
            groupBox2.SuspendLayout();
            gbxActions.SuspendLayout();
            SuspendLayout();
            // 
            // lbxMyTrips
            // 
            lbxMyTrips.FormattingEnabled = true;
            lbxMyTrips.ItemHeight = 15;
            lbxMyTrips.Location = new System.Drawing.Point(11, 20);
            lbxMyTrips.Name = "lbxMyTrips";
            lbxMyTrips.Size = new System.Drawing.Size(325, 139);
            lbxMyTrips.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nudRating);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudDistance);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxTo);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new System.Drawing.Point(12, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            groupBox1.Size = new System.Drawing.Size(267, 131);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add trip";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(12, 80);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 16);
            label5.TabIndex = 48;
            label5.Text = "Rating:";
            // 
            // nudRating
            // 
            nudRating.DecimalPlaces = 1;
            nudRating.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudRating.Location = new System.Drawing.Point(96, 78);
            nudRating.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new System.Drawing.Size(148, 23);
            nudRating.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(216, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 16);
            label4.TabIndex = 46;
            label4.Text = "KM";
            // 
            // nudDistance
            // 
            nudDistance.DecimalPlaces = 3;
            nudDistance.Location = new System.Drawing.Point(96, 54);
            nudDistance.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            nudDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDistance.Name = "nudDistance";
            nudDistance.Size = new System.Drawing.Size(115, 23);
            nudDistance.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 16);
            label2.TabIndex = 19;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 16);
            label3.TabIndex = 18;
            label3.Text = "To:";
            // 
            // tbxTo
            // 
            tbxTo.Location = new System.Drawing.Point(96, 27);
            tbxTo.Name = "tbxTo";
            tbxTo.PlaceholderText = "location";
            tbxTo.Size = new System.Drawing.Size(150, 23);
            tbxTo.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 101);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(232, 21);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShowAll);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbxSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(lbxMyTrips);
            groupBox2.Location = new System.Drawing.Point(292, 10);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            groupBox2.Size = new System.Drawing.Size(349, 230);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "My trips";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new System.Drawing.Point(11, 165);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(324, 21);
            btnShowAll.TabIndex = 23;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(11, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 16);
            label1.TabIndex = 22;
            label1.Text = "To:";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new System.Drawing.Point(44, 193);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "location";
            tbxSearch.Size = new System.Drawing.Size(182, 23);
            tbxSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(231, 192);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(104, 21);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbxActions
            // 
            gbxActions.Controls.Add(btnInfo);
            gbxActions.Controls.Add(btnDelete);
            gbxActions.Location = new System.Drawing.Point(12, 151);
            gbxActions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            gbxActions.Name = "gbxActions";
            gbxActions.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            gbxActions.Size = new System.Drawing.Size(267, 89);
            gbxActions.TabIndex = 43;
            gbxActions.TabStop = false;
            gbxActions.Text = "Selected trip";
            // 
            // btnInfo
            // 
            btnInfo.Location = new System.Drawing.Point(12, 23);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(232, 21);
            btnInfo.TabIndex = 45;
            btnInfo.Text = "Show info of selected trip";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(12, 51);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(232, 21);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete selected trip";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(657, 251);
            Controls.Add(gbxActions);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "The bike app";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistance).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ListBox lbxMyTrips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnShowAll;
    }
}

