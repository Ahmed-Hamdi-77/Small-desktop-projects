namespace Tic_tac_toe_game_proj
{
    partial class frmChooseSigns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseSigns));
            this.btn_O = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_X = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_O
            // 
            this.btn_O.BackColor = System.Drawing.Color.Indigo;
            this.btn_O.BackgroundImage = global::Tic_tac_toe_game_proj.Properties.Resources.O_Sign;
            this.btn_O.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_O.Location = new System.Drawing.Point(789, 568);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(209, 179);
            this.btn_O.TabIndex = 3;
            this.btn_O.Tag = "O";
            this.btn_O.UseVisualStyleBackColor = false;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 87);
            this.label3.TabIndex = 4;
            this.label3.Text = "OR";
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.Indigo;
            this.btn_X.BackgroundImage = global::Tic_tac_toe_game_proj.Properties.Resources.X_Sign;
            this.btn_X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_X.Location = new System.Drawing.Point(256, 568);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(188, 179);
            this.btn_X.TabIndex = 2;
            this.btn_X.Tag = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tic_tac_toe_game_proj.Properties.Resources.tic_tac_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 244);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 87);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player1, Choose one";
            // 
            // frmChooseSigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1265, 856);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_O);
            this.Controls.Add(this.btn_X);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChooseSigns";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}