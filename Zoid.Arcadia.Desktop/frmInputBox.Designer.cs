
namespace Zoid.Arcadia.Desktop
{
    partial class FrmInputBox
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
            this.TxtPlayer = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPlayer
            // 
            this.TxtPlayer.Location = new System.Drawing.Point(12, 12);
            this.TxtPlayer.Name = "TxtPlayer";
            this.TxtPlayer.Size = new System.Drawing.Size(188, 22);
            this.TxtPlayer.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(206, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(99, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // FrmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 46);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmInputBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInputBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPlayer;
        private System.Windows.Forms.Button BtnAdd;
    }
}