namespace AdvertisingAgency
{
    partial class WriteScriptsForm
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
            this.tbWriteScripts = new System.Windows.Forms.TextBox();
            this.rbRun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tbWriteScripts
            // 
            this.tbWriteScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWriteScripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWriteScripts.Location = new System.Drawing.Point(0, 64);
            this.tbWriteScripts.Multiline = true;
            this.tbWriteScripts.Name = "tbWriteScripts";
            this.tbWriteScripts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWriteScripts.Size = new System.Drawing.Size(784, 486);
            this.tbWriteScripts.TabIndex = 1;
            this.tbWriteScripts.WordWrap = false;
            // 
            // rbRun
            // 
            this.rbRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRun.AutoSize = true;
            this.rbRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbRun.Depth = 0;
            this.rbRun.Icon = global::AdvertisingAgency.Properties.Resources.wr;
            this.rbRun.Location = new System.Drawing.Point(646, 26);
            this.rbRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRun.Name = "rbRun";
            this.rbRun.Primary = true;
            this.rbRun.Size = new System.Drawing.Size(135, 36);
            this.rbRun.TabIndex = 2;
            this.rbRun.Text = "Выполнить";
            this.rbRun.UseVisualStyleBackColor = true;
            this.rbRun.Click += new System.EventHandler(this.rbRun_Click);
            // 
            // WriteScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.rbRun);
            this.Controls.Add(this.tbWriteScripts);
            this.Name = "WriteScriptsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно скриптов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbWriteScripts;
        private MaterialSkin.Controls.MaterialRaisedButton rbRun;
    }
}