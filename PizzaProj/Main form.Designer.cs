namespace PizzaProj
{
    partial class Pizzafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzafrm));
            this.btnMkurPizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMkurPizza
            // 
            this.btnMkurPizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMkurPizza.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMkurPizza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMkurPizza.Location = new System.Drawing.Point(997, 502);
            this.btnMkurPizza.Name = "btnMkurPizza";
            this.btnMkurPizza.Size = new System.Drawing.Size(435, 145);
            this.btnMkurPizza.TabIndex = 0;
            this.btnMkurPizza.Text = "Make your pizza!";
            this.btnMkurPizza.UseVisualStyleBackColor = false;
            this.btnMkurPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(884, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 169);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Dot";
            // 
            // Pizzafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProj.Properties.Resources.Main_screen_pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1532, 1013);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMkurPizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pizzafrm";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMkurPizza;
        private System.Windows.Forms.Label label1;
    }
}

