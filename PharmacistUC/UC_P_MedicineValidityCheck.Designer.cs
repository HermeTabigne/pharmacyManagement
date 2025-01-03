﻿namespace PharmacyManagementSystem.PharmacistUC
{
    partial class UC_P_MedicineValidityCheck
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valid_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.valid_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.set_txt = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.valid_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medicine Validity Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Check";
            // 
            // valid_comboBox
            // 
            this.valid_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.valid_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.valid_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valid_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valid_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valid_comboBox.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.valid_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.valid_comboBox.ItemHeight = 30;
            this.valid_comboBox.Items.AddRange(new object[] {
            "Valid Medicines",
            "Expired Medicines",
            "View All Medicines"});
            this.valid_comboBox.Location = new System.Drawing.Point(252, 80);
            this.valid_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valid_comboBox.Name = "valid_comboBox";
            this.valid_comboBox.Size = new System.Drawing.Size(258, 36);
            this.valid_comboBox.TabIndex = 25;
            this.valid_comboBox.SelectedIndexChanged += new System.EventHandler(this.valid_comboBox_SelectedIndexChanged);
            // 
            // valid_grid
            // 
            this.valid_grid.AllowUserToAddRows = false;
            this.valid_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.valid_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.valid_grid.BackgroundColor = System.Drawing.Color.Azure;
            this.valid_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.valid_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.valid_grid.ColumnHeadersHeight = 4;
            this.valid_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.valid_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.valid_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valid_grid.Location = new System.Drawing.Point(2, 124);
            this.valid_grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valid_grid.Name = "valid_grid";
            this.valid_grid.ReadOnly = true;
            this.valid_grid.RowHeadersVisible = false;
            this.valid_grid.RowHeadersWidth = 51;
            this.valid_grid.RowTemplate.Height = 24;
            this.valid_grid.Size = new System.Drawing.Size(716, 471);
            this.valid_grid.TabIndex = 26;
            this.valid_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.valid_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.valid_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.valid_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.valid_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.valid_grid.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.valid_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valid_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.valid_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.valid_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.valid_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.valid_grid.ThemeStyle.HeaderStyle.Height = 4;
            this.valid_grid.ThemeStyle.ReadOnly = true;
            this.valid_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.valid_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.valid_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.valid_grid.ThemeStyle.RowsStyle.Height = 24;
            this.valid_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.valid_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // set_txt
            // 
            this.set_txt.AutoSize = true;
            this.set_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_txt.Location = new System.Drawing.Point(3, 96);
            this.set_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.set_txt.Name = "set_txt";
            this.set_txt.Size = new System.Drawing.Size(40, 24);
            this.set_txt.TabIndex = 27;
            this.set_txt.Text = "Set";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_MedicineValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.set_txt);
            this.Controls.Add(this.valid_grid);
            this.Controls.Add(this.valid_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_P_MedicineValidityCheck";
            this.Size = new System.Drawing.Size(720, 618);
            this.Load += new System.EventHandler(this.UC_P_MedicineValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valid_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox valid_comboBox;
        private Guna.UI2.WinForms.Guna2DataGridView valid_grid;
        private System.Windows.Forms.Label set_txt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
