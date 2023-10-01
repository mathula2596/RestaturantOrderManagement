namespace Project
{
    partial class Kitchen_Food_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen_Food_Management));
            this.label10 = new System.Windows.Forms.Label();
            this.txtfoodid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkname = new System.Windows.Forms.TextBox();
            this.txtkid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbfoodname = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 31);
            this.label10.TabIndex = 37;
            this.label10.Text = "Manage Food Items";
            // 
            // txtfoodid
            // 
            this.txtfoodid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtfoodid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtfoodid.Location = new System.Drawing.Point(573, 165);
            this.txtfoodid.Name = "txtfoodid";
            this.txtfoodid.ReadOnly = true;
            this.txtfoodid.Size = new System.Drawing.Size(151, 20);
            this.txtfoodid.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Food Name :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(442, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "Quantity :";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(533, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 42);
            this.button7.TabIndex = 34;
            this.button7.Text = "Done";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(573, 212);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(151, 20);
            this.txtquantity.TabIndex = 31;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 469);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.cmbfoodname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.txtkname);
            this.tabPage1.Controls.Add(this.txtkid);
            this.tabPage1.Controls.Add(this.txtquantity);
            this.tabPage1.Controls.Add(this.txtfoodid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1211, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Food ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kitchen Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kitchen ID :";
            // 
            // txtkname
            // 
            this.txtkname.Location = new System.Drawing.Point(573, 301);
            this.txtkname.Name = "txtkname";
            this.txtkname.ReadOnly = true;
            this.txtkname.Size = new System.Drawing.Size(151, 20);
            this.txtkname.TabIndex = 31;
            // 
            // txtkid
            // 
            this.txtkid.Location = new System.Drawing.Point(573, 256);
            this.txtkid.Name = "txtkid";
            this.txtkid.ReadOnly = true;
            this.txtkid.Size = new System.Drawing.Size(151, 20);
            this.txtkid.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(444, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Food ID :";
            // 
            // cmbfoodname
            // 
            this.cmbfoodname.FormattingEnabled = true;
            this.cmbfoodname.Location = new System.Drawing.Point(573, 114);
            this.cmbfoodname.Name = "cmbfoodname";
            this.cmbfoodname.Size = new System.Drawing.Size(151, 21);
            this.cmbfoodname.TabIndex = 42;
            this.cmbfoodname.SelectedValueChanged += new System.EventHandler(this.cmbfoodname_SelectedValueChanged);
            // 
            // Kitchen_Food_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1239, 481);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitchen_Food_Management";
            this.Text = "Kitchen_Food_Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfoodid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkname;
        private System.Windows.Forms.TextBox txtkid;
        private System.Windows.Forms.ComboBox cmbfoodname;
    }
}