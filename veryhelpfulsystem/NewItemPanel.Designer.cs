
namespace veryhelpfulsystem
{
    partial class NewItemPanel
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
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(1203, 29);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(51, 20);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "label1";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(379, 58);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(51, 20);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "label2";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(417, 165);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(1037, 182);
            this.tbContent.TabIndex = 3;
            this.tbContent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(39, 116);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(362, 279);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // NewItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbTime);
            this.Name = "NewItemPanel";
            this.Size = new System.Drawing.Size(1678, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbContent;
    }
}