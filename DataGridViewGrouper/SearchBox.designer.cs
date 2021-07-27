namespace DevDash.Controls
{
    partial class SearchBoxBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBoxBase));
            this.txt = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsInner = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(230, 26);
            this.txt.TabIndex = 0;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(230, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 32);
            this.btnNext.TabIndex = 0;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsInner,
            this.toolStripSeparator2,
            this.tsClear});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(215, 80);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // tsInner
            // 
            this.tsInner.Name = "tsInner";
            this.tsInner.Size = new System.Drawing.Size(214, 32);
            this.tsInner.Text = "Search inner text";
            this.tsInner.ToolTipText = "If checked, the entire text is searched, otherwise only values starting with the " +
    "searchvalues are searched";
            this.tsInner.Click += new System.EventHandler(this.tsInner_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // tsClear
            // 
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(214, 32);
            this.tsClear.Text = "Clear";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // SearchBoxBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnNext);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchBoxBase";
            this.Size = new System.Drawing.Size(260, 32);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnNext;
        protected System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsClear;
        private System.Windows.Forms.ToolStripMenuItem tsInner;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
