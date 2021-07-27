namespace Test
{
    partial class ExampleWithControl
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewGrouperControl1 = new DevDash.Controls.DataGridViewGrouperControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewGrouperControl1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AString";
            this.dataGridViewTextBoxColumn1.HeaderText = "AString";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ADate";
            this.dataGridViewTextBoxColumn2.HeaderText = "ADate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnInt";
            this.dataGridViewTextBoxColumn3.HeaderText = "AnInt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewGrouperControl1
            // 
            this.dataGridViewGrouperControl1.AllowDrop = true;
            this.dataGridViewGrouperControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewGrouperControl1.DataGridView = this.dataGridView1;
            this.dataGridViewGrouperControl1.Location = new System.Drawing.Point(58, 13);
            this.dataGridViewGrouperControl1.Name = "dataGridViewGrouperControl1";
            this.dataGridViewGrouperControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewGrouperControl1.Size = new System.Drawing.Size(209, 20);
            this.dataGridViewGrouperControl1.TabIndex = 0;
            // 
            // ExampleWithControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 389);
            this.Name = "ExampleWithControl";
            this.Text = "ExampleWithControl";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevDash.Controls.DataGridViewGrouperControl dataGridViewGrouperControl1;
    }
}