namespace Albert_DealPOS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dealPOSTestDataSet = new Albert_DealPOS.DealPOSTestDataSet();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new Albert_DealPOS.DealPOSTestDataSetTableAdapters.PersonTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealPOSTestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPhonePersonID4BAC3F29BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTableAdapter = new Albert_DealPOS.DealPOSTestDataSetTableAdapters.PhoneTableAdapter();
            this.fKPhonePersonID4BAC3F29BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhonePersonID4BAC3F29BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhonePersonID4BAC3F29BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dealPOSTestDataSet
            // 
            this.dealPOSTestDataSet.DataSetName = "DealPOSTestDataSet";
            this.dealPOSTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.dealPOSTestDataSet;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(334, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(35, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.PhoneID,
            this.Phone_2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 202);
            this.dataGridView1.TabIndex = 5;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Width = 120;
            // 
            // PhoneID
            // 
            this.PhoneID.HeaderText = "Phone";
            this.PhoneID.Name = "PhoneID";
            this.PhoneID.ReadOnly = true;
            this.PhoneID.Width = 150;
            // 
            // Phone_2
            // 
            this.Phone_2.HeaderText = "Phone 2";
            this.Phone_2.Name = "Phone_2";
            this.Phone_2.ReadOnly = true;
            this.Phone_2.Width = 150;
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.dealPOSTestDataSetBindingSource;
            // 
            // dealPOSTestDataSetBindingSource
            // 
            this.dealPOSTestDataSetBindingSource.DataSource = this.dealPOSTestDataSet;
            this.dealPOSTestDataSetBindingSource.Position = 0;
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "Person";
            this.personBindingSource1.DataSource = this.dealPOSTestDataSetBindingSource;
            // 
            // fKPhonePersonID4BAC3F29BindingSource
            // 
            this.fKPhonePersonID4BAC3F29BindingSource.DataMember = "FK__Phone__PersonID__4BAC3F29";
            this.fKPhonePersonID4BAC3F29BindingSource.DataSource = this.personBindingSource1;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhonePersonID4BAC3F29BindingSource1
            // 
            this.fKPhonePersonID4BAC3F29BindingSource1.DataMember = "FK__Phone__PersonID__4BAC3F29";
            this.fKPhonePersonID4BAC3F29BindingSource1.DataSource = this.personBindingSource;
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataMember = "Person";
            this.personBindingSource2.DataSource = this.dealPOSTestDataSetBindingSource;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "View Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhonePersonID4BAC3F29BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhonePersonID4BAC3F29BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DealPOSTestDataSet dealPOSTestDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private DealPOSTestDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dealPOSTestDataSetBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.BindingSource fKPhonePersonID4BAC3F29BindingSource;
        private DealPOSTestDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.BindingSource fKPhonePersonID4BAC3F29BindingSource1;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_2;
    }
}