namespace WannaFly
{
    partial class frmCodeView
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
            this.btnCloseCodeView = new System.Windows.Forms.Button();
            this.btnSaveCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTBxCodeView = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseCodeView
            // 
            this.btnCloseCodeView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloseCodeView.Location = new System.Drawing.Point(514, 497);
            this.btnCloseCodeView.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseCodeView.Name = "btnCloseCodeView";
            this.btnCloseCodeView.Size = new System.Drawing.Size(100, 29);
            this.btnCloseCodeView.TabIndex = 5;
            this.btnCloseCodeView.Text = "关闭";
            this.btnCloseCodeView.UseVisualStyleBackColor = true;
            this.btnCloseCodeView.Click += new System.EventHandler(this.btnCloseCodeView_Click);
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveCode.Location = new System.Drawing.Point(308, 497);
            this.btnSaveCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(117, 29);
            this.btnSaveCode.TabIndex = 3;
            this.btnSaveCode.Text = "保存(&S)...";
            this.btnSaveCode.UseVisualStyleBackColor = true;
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rTBxCodeView);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(941, 476);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前Web页的html码";
            // 
            // rTBxCodeView
            // 
            this.rTBxCodeView.BackColor = System.Drawing.SystemColors.Window;
            this.rTBxCodeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBxCodeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBxCodeView.Location = new System.Drawing.Point(4, 22);
            this.rTBxCodeView.Margin = new System.Windows.Forms.Padding(4);
            this.rTBxCodeView.Name = "rTBxCodeView";
            this.rTBxCodeView.ReadOnly = true;
            this.rTBxCodeView.Size = new System.Drawing.Size(933, 450);
            this.rTBxCodeView.TabIndex = 1;
            this.rTBxCodeView.Text = "";
            // 
            // frmCodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.btnCloseCodeView);
            this.Controls.Add(this.btnSaveCode);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCodeView";
            this.Text = "frmCodeView";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCodeView;
        private System.Windows.Forms.Button btnSaveCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rTBxCodeView;
    }
}