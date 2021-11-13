
namespace Fall2020_CSC403_Project
{
    partial class FrmCutscene
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
            this.pictureBoxCutscene = new System.Windows.Forms.PictureBox();
            this.buttonProgressCutscene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCutscene)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCutscene
            // 
            this.pictureBoxCutscene.Image = global::Fall2020_CSC403_Project.Properties.Resources.cutscene1;
            this.pictureBoxCutscene.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCutscene.Name = "pictureBoxCutscene";
            this.pictureBoxCutscene.Size = new System.Drawing.Size(1045, 716);
            this.pictureBoxCutscene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCutscene.TabIndex = 0;
            this.pictureBoxCutscene.TabStop = false;
            // 
            // buttonProgressCutscene
            // 
            this.buttonProgressCutscene.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgressCutscene.Location = new System.Drawing.Point(737, 757);
            this.buttonProgressCutscene.Name = "buttonProgressCutscene";
            this.buttonProgressCutscene.Size = new System.Drawing.Size(320, 58);
            this.buttonProgressCutscene.TabIndex = 1;
            this.buttonProgressCutscene.Text = "Click to continue...";
            this.buttonProgressCutscene.UseVisualStyleBackColor = true;
            this.buttonProgressCutscene.Click += new System.EventHandler(this.buttonProgressCutscene_Click);
            // 
            // FrmCutscene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1073, 837);
            this.Controls.Add(this.buttonProgressCutscene);
            this.Controls.Add(this.pictureBoxCutscene);
            this.Name = "FrmCutscene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCutscene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCutscene;
        private System.Windows.Forms.Button buttonProgressCutscene;
    }
}