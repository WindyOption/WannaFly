namespace WannaFly
{
    partial class historyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historyForm));
            this.historyDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // historyDisplay
            // 
            this.historyDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyDisplay.FormattingEnabled = true;
            this.historyDisplay.ItemHeight = 15;
            this.historyDisplay.Location = new System.Drawing.Point(12, 12);
            this.historyDisplay.Name = "historyDisplay";
            this.historyDisplay.Size = new System.Drawing.Size(786, 454);
            this.historyDisplay.TabIndex = 1;
            this.historyDisplay.SelectedIndexChanged += new System.EventHandler(this.historyDisplay_SelectedIndexChanged);
            // 
            // historyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 483);
            this.Controls.Add(this.historyDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "historyForm";
            this.Text = "地址栏记录";
            this.Load += new System.EventHandler(this.historyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historyDisplay;
    }
}