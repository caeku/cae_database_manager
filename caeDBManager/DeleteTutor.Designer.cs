namespace caeDBManager
{
    partial class DeleteTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTutor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.Resetbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete a Tutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(145, 48);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(158, 22);
            this.IDtextBox.TabIndex = 4;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(145, 85);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(158, 22);
            this.firstNametextBox.TabIndex = 5;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBttn.ForeColor = System.Drawing.Color.White;
            this.DeleteBttn.Location = new System.Drawing.Point(16, 128);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(173, 34);
            this.DeleteBttn.TabIndex = 10;
            this.DeleteBttn.Text = "Delete Tutor";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_ClickAsync);
            // 
            // Resetbttn
            // 
            this.Resetbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbttn.ForeColor = System.Drawing.Color.White;
            this.Resetbttn.Location = new System.Drawing.Point(213, 128);
            this.Resetbttn.Name = "Resetbttn";
            this.Resetbttn.Size = new System.Drawing.Size(90, 34);
            this.Resetbttn.TabIndex = 11;
            this.Resetbttn.Text = "Reset";
            this.Resetbttn.UseVisualStyleBackColor = true;
            this.Resetbttn.Click += new System.EventHandler(this.Resetbttn_Click);
            // 
            // DeleteTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.Resetbttn);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.firstNametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteTutor";
            this.Text = "Delete Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Button Resetbttn;
    }
}