
namespace Zoid.Arcadia.Desktop
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PibScores = new System.Windows.Forms.PictureBox();
            this.PibArcadia = new System.Windows.Forms.PictureBox();
            this.grbPlayers = new System.Windows.Forms.GroupBox();
            this.LsbPlayers = new System.Windows.Forms.ListBox();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PibScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibArcadia)).BeginInit();
            this.grbPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PibScores
            // 
            this.PibScores.Image = ((System.Drawing.Image)(resources.GetObject("PibScores.Image")));
            this.PibScores.Location = new System.Drawing.Point(736, 12);
            this.PibScores.Name = "PibScores";
            this.PibScores.Size = new System.Drawing.Size(680, 580);
            this.PibScores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PibScores.TabIndex = 0;
            this.PibScores.TabStop = false;
            // 
            // PibArcadia
            // 
            this.PibArcadia.Image = ((System.Drawing.Image)(resources.GetObject("PibArcadia.Image")));
            this.PibArcadia.Location = new System.Drawing.Point(223, 12);
            this.PibArcadia.Name = "PibArcadia";
            this.PibArcadia.Size = new System.Drawing.Size(501, 580);
            this.PibArcadia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PibArcadia.TabIndex = 1;
            this.PibArcadia.TabStop = false;
            // 
            // grbPlayers
            // 
            this.grbPlayers.Controls.Add(this.BtnAddPlayer);
            this.grbPlayers.Controls.Add(this.LsbPlayers);
            this.grbPlayers.Location = new System.Drawing.Point(12, 12);
            this.grbPlayers.Name = "grbPlayers";
            this.grbPlayers.Size = new System.Drawing.Size(200, 220);
            this.grbPlayers.TabIndex = 2;
            this.grbPlayers.TabStop = false;
            this.grbPlayers.Text = "Jogadores";
            // 
            // LsbPlayers
            // 
            this.LsbPlayers.FormattingEnabled = true;
            this.LsbPlayers.ItemHeight = 16;
            this.LsbPlayers.Location = new System.Drawing.Point(6, 83);
            this.LsbPlayers.Name = "LsbPlayers";
            this.LsbPlayers.Size = new System.Drawing.Size(188, 116);
            this.LsbPlayers.TabIndex = 0;
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Location = new System.Drawing.Point(6, 25);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(188, 28);
            this.BtnAddPlayer.TabIndex = 1;
            this.BtnAddPlayer.Text = "Adicionar Jogador";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 604);
            this.Controls.Add(this.grbPlayers);
            this.Controls.Add(this.PibArcadia);
            this.Controls.Add(this.PibScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcadia Scores";
            ((System.ComponentModel.ISupportInitialize)(this.PibScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibArcadia)).EndInit();
            this.grbPlayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PibScores;
        private System.Windows.Forms.PictureBox PibArcadia;
        private System.Windows.Forms.GroupBox grbPlayers;
        private System.Windows.Forms.Button BtnAddPlayer;
        private System.Windows.Forms.ListBox LsbPlayers;
    }
}

