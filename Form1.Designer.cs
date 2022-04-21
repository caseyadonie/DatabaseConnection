namespace DatabaseElev8
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
            this.bttnInsert = new System.Windows.Forms.Button();
            this.bttnRead = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.bttnRead1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnInsert
            // 
            this.bttnInsert.Location = new System.Drawing.Point(944, 43);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(164, 56);
            this.bttnInsert.TabIndex = 0;
            this.bttnInsert.Text = "Insert Statement";
            this.bttnInsert.UseVisualStyleBackColor = true;
            this.bttnInsert.Click += new System.EventHandler(this.bttnInsert_Click);
            // 
            // bttnRead
            // 
            this.bttnRead.Location = new System.Drawing.Point(944, 240);
            this.bttnRead.Name = "bttnRead";
            this.bttnRead.Size = new System.Drawing.Size(164, 56);
            this.bttnRead.TabIndex = 1;
            this.bttnRead.Text = "Read Statement";
            this.bttnRead.UseVisualStyleBackColor = true;
            this.bttnRead.Click += new System.EventHandler(this.bttnRead_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(944, 492);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(164, 56);
            this.bttnUpdate.TabIndex = 2;
            this.bttnUpdate.Text = "Update Statement";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(944, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Statement";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create, Read, Update and Delete (CRUD)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(433, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(218, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Location = new System.Drawing.Point(433, 96);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(218, 20);
            this.txtOtherNames.TabIndex = 7;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(433, 164);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(218, 20);
            this.txtMobileNo.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(433, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(433, 122);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(218, 21);
            this.cmbGender.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(147, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Other Names";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(147, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(147, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mobile No";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(147, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(54, 258);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 45;
            this.dgView.Size = new System.Drawing.Size(884, 465);
            this.dgView.TabIndex = 16;
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(433, 231);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(158, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 18;
            this.lblId.Visible = false;
            // 
            // bttnRead1
            // 
            this.bttnRead1.Location = new System.Drawing.Point(944, 319);
            this.bttnRead1.Name = "bttnRead1";
            this.bttnRead1.Size = new System.Drawing.Size(164, 56);
            this.bttnRead1.TabIndex = 19;
            this.bttnRead1.Text = "Read Statement 1";
            this.bttnRead1.UseVisualStyleBackColor = true;
            this.bttnRead1.Click += new System.EventHandler(this.bttnRead1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 783);
            this.Controls.Add(this.bttnRead1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtOtherNames);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnRead);
            this.Controls.Add(this.bttnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Button bttnRead;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button bttnRead1;
    }
}

