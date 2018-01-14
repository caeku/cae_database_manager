namespace caeDBManager
{
    partial class AddTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTutor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.AddBttn = new System.Windows.Forms.Button();
            this.Resetbttn = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Required Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(186, 51);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(149, 22);
            this.IDtextBox.TabIndex = 2;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Class*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(186, 88);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(149, 22);
            this.firstNametextBox.TabIndex = 6;
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(186, 125);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(149, 22);
            this.lastNametextBox.TabIndex = 7;
            // 
            // AddBttn
            // 
            this.AddBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBttn.ForeColor = System.Drawing.Color.White;
            this.AddBttn.Location = new System.Drawing.Point(20, 221);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(90, 34);
            this.AddBttn.TabIndex = 9;
            this.AddBttn.Text = "Add";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // Resetbttn
            // 
            this.Resetbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbttn.ForeColor = System.Drawing.Color.White;
            this.Resetbttn.Location = new System.Drawing.Point(131, 221);
            this.Resetbttn.Name = "Resetbttn";
            this.Resetbttn.Size = new System.Drawing.Size(90, 34);
            this.Resetbttn.TabIndex = 10;
            this.Resetbttn.Text = "Reset";
            this.Resetbttn.UseVisualStyleBackColor = true;
            this.Resetbttn.Click += new System.EventHandler(this.Resetbttn_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.classComboBox.Location = new System.Drawing.Point(186, 165);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 24);
            this.classComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Not required";
            // 
            // AddTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(420, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.Resetbttn);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.lastNametextBox);
            this.Controls.Add(this.firstNametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTutor";
            this.Text = "Add Tutor";
            this.Load += new System.EventHandler(this.AddTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button Resetbttn;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label6;
    }
}