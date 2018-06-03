namespace WannaFly
{
    partial class favoritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favoritesForm));
            this.favorDisPlay = new System.Windows.Forms.ListBox();
            this.delFavor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favorDisPlay
            // 
            this.favorDisPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favorDisPlay.FormattingEnabled = true;
            this.favorDisPlay.ItemHeight = 15;
            this.favorDisPlay.Location = new System.Drawing.Point(13, 13);
            this.favorDisPlay.Name = "favorDisPlay";
            this.favorDisPlay.Size = new System.Drawing.Size(828, 454);
            this.favorDisPlay.TabIndex = 0;
            this.favorDisPlay.SelectedIndexChanged += new System.EventHandler(this.favorDisPlay_SelectedIndexChanged);
            // 
            // delFavor
            // 
            this.delFavor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delFavor.AutoSize = true;
            this.delFavor.Location = new System.Drawing.Point(775, 506);
            this.delFavor.Name = "delFavor";
            this.delFavor.Size = new System.Drawing.Size(66, 25);
            this.delFavor.TabIndex = 3;
            this.delFavor.Text = "删除";
            this.delFavor.UseVisualStyleBackColor = true;
            this.delFavor.Click += new System.EventHandler(this.delFavor_Click);
            // 
            // favoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 553);
            this.Controls.Add(this.delFavor);
            this.Controls.Add(this.favorDisPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "favoritesForm";
            this.Text = "收藏夹";
            this.Load += new System.EventHandler(this.favoritesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox favorDisPlay;
        private System.Windows.Forms.Button delFavor;
    }
}