namespace Albert_DealPOS
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
            this.components = new System.ComponentModel.Container();
            this.dealPOSTestDataSet = new Albert_DealPOS.DealPOSTestDataSet();
            this.dealPOSTestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone2_label = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.phone1_field = new System.Windows.Forms.TextBox();
            this.phone2_field = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.error1_label = new System.Windows.Forms.Label();
            this.error2_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.error3_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dealPOSTestDataSet
            // 
            this.dealPOSTestDataSet.DataSetName = "DealPOSTestDataSet";
            this.dealPOSTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealPOSTestDataSetBindingSource
            // 
            this.dealPOSTestDataSetBindingSource.DataSource = this.dealPOSTestDataSet;
            this.dealPOSTestDataSetBindingSource.Position = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(37, 69);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(51, 20);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            this.name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(37, 130);
            this.phone_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(68, 20);
            this.phone_label.TabIndex = 1;
            this.phone_label.Text = "Phone 1";
            // 
            // phone2_label
            // 
            this.phone2_label.AutoSize = true;
            this.phone2_label.Location = new System.Drawing.Point(37, 199);
            this.phone2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone2_label.Name = "phone2_label";
            this.phone2_label.Size = new System.Drawing.Size(68, 20);
            this.phone2_label.TabIndex = 2;
            this.phone2_label.Text = "Phone 2";
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(128, 69);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(127, 26);
            this.name_field.TabIndex = 3;
            // 
            // phone1_field
            // 
            this.phone1_field.Location = new System.Drawing.Point(128, 130);
            this.phone1_field.Name = "phone1_field";
            this.phone1_field.Size = new System.Drawing.Size(127, 26);
            this.phone1_field.TabIndex = 4;
            // 
            // phone2_field
            // 
            this.phone2_field.Location = new System.Drawing.Point(128, 196);
            this.phone2_field.Name = "phone2_field";
            this.phone2_field.Size = new System.Drawing.Size(127, 26);
            this.phone2_field.TabIndex = 5;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(150, 272);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(85, 45);
            this.submit_button.TabIndex = 6;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(74, 323);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(120, 45);
            this.view_button.TabIndex = 7;
            this.view_button.Text = "View Page";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(47, 23);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(113, 26);
            this.title.TabIndex = 8;
            this.title.Text = "Input Page";
            // 
            // error1_label
            // 
            this.error1_label.AutoSize = true;
            this.error1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.error1_label.ForeColor = System.Drawing.Color.Red;
            this.error1_label.Location = new System.Drawing.Point(129, 98);
            this.error1_label.Name = "error1_label";
            this.error1_label.Size = new System.Drawing.Size(99, 13);
            this.error1_label.TabIndex = 9;
            this.error1_label.Text = "Name must be filled";
            this.error1_label.Visible = false;
            // 
            // error2_label
            // 
            this.error2_label.AutoSize = true;
            this.error2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.error2_label.ForeColor = System.Drawing.Color.Red;
            this.error2_label.Location = new System.Drawing.Point(129, 159);
            this.error2_label.Name = "error2_label";
            this.error2_label.Size = new System.Drawing.Size(111, 13);
            this.error2_label.TabIndex = 10;
            this.error2_label.Text = "Phone 1 must be filled";
            this.error2_label.Visible = false;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(36, 272);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(85, 45);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // error3_label
            // 
            this.error3_label.AutoSize = true;
            this.error3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.error3_label.ForeColor = System.Drawing.Color.Red;
            this.error3_label.Location = new System.Drawing.Point(129, 225);
            this.error3_label.Name = "error3_label";
            this.error3_label.Size = new System.Drawing.Size(193, 13);
            this.error3_label.TabIndex = 12;
            this.error3_label.Text = "Phone 2 must be filled only with number";
            this.error3_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 380);
            this.Controls.Add(this.error3_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.error2_label);
            this.Controls.Add(this.error1_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.phone2_field);
            this.Controls.Add(this.phone1_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.phone2_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Input Page";
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealPOSTestDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DealPOSTestDataSet dealPOSTestDataSet;
        private System.Windows.Forms.BindingSource dealPOSTestDataSetBindingSource;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label phone2_label;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.TextBox phone1_field;
        private System.Windows.Forms.TextBox phone2_field;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label error1_label;
        private System.Windows.Forms.Label error2_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label error3_label;
    }
}

