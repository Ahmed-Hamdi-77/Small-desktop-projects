namespace PizzaProj
{
    partial class SubForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm));
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.btnThin = new System.Windows.Forms.RadioButton();
            this.btnThick = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblSummarySize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSummaryWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSummaryCrust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbWheretoEat = new System.Windows.Forms.GroupBox();
            this.btnEatIn = new System.Windows.Forms.RadioButton();
            this.btnTakeOut = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.btnSmall = new System.Windows.Forms.RadioButton();
            this.btnLarg = new System.Windows.Forms.RadioButton();
            this.btnMedium = new System.Windows.Forms.RadioButton();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumOfPizzas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbWheretoEat.SuspendLayout();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            resources.ApplyResources(this.gbToppings, "gbToppings");
            this.gbToppings.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.TabStop = false;
            // 
            // chkOnion
            // 
            resources.ApplyResources(this.chkOnion, "chkOnion");
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Tag = "5";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            resources.ApplyResources(this.chkMushrooms, "chkMushrooms");
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            resources.ApplyResources(this.chkTomatoes, "chkTomatoes");
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            resources.ApplyResources(this.chkOlives, "chkOlives");
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Tag = "5";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPepper
            // 
            resources.ApplyResources(this.chkGreenPepper, "chkGreenPepper");
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            resources.ApplyResources(this.chkExtraCheese, "chkExtraCheese");
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.btnThin);
            this.gbCrustType.Controls.Add(this.btnThick);
            resources.ApplyResources(this.gbCrustType, "gbCrustType");
            this.gbCrustType.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.TabStop = false;
            // 
            // btnThin
            // 
            resources.ApplyResources(this.btnThin, "btnThin");
            this.btnThin.Checked = true;
            this.btnThin.Name = "btnThin";
            this.btnThin.TabStop = true;
            this.btnThin.Tag = "0";
            this.btnThin.UseVisualStyleBackColor = true;
            this.btnThin.CheckedChanged += new System.EventHandler(this.btnThin_CheckedChanged);
            // 
            // btnThick
            // 
            resources.ApplyResources(this.btnThick, "btnThick");
            this.btnThick.Name = "btnThick";
            this.btnThick.Tag = "10";
            this.btnThick.UseVisualStyleBackColor = true;
            this.btnThick.CheckedChanged += new System.EventHandler(this.btnThick_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Sienna;
            this.btnOrderPizza.ForeColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnOrderPizza, "btnOrderPizza");
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // gbSummary
            // 
            resources.ApplyResources(this.gbSummary, "gbSummary");
            this.gbSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbSummary.Controls.Add(this.lblNumOfPizzas);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.lblSummarySize);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.labelToppings);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.Controls.Add(this.lblSummaryWhereToEat);
            this.gbSummary.Controls.Add(this.lblTotalPrice);
            this.gbSummary.Controls.Add(this.lblSummaryCrust);
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.TabStop = false;
            // 
            // lblSummarySize
            // 
            resources.ApplyResources(this.lblSummarySize, "lblSummarySize");
            this.lblSummarySize.Name = "lblSummarySize";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // labelToppings
            // 
            resources.ApplyResources(this.labelToppings, "labelToppings");
            this.labelToppings.Name = "labelToppings";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblSummaryWhereToEat
            // 
            resources.ApplyResources(this.lblSummaryWhereToEat, "lblSummaryWhereToEat");
            this.lblSummaryWhereToEat.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSummaryWhereToEat.Name = "lblSummaryWhereToEat";
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Tag = "30";
            // 
            // lblSummaryCrust
            // 
            resources.ApplyResources(this.lblSummaryCrust, "lblSummaryCrust");
            this.lblSummaryCrust.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSummaryCrust.Name = "lblSummaryCrust";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // gbWheretoEat
            // 
            this.gbWheretoEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWheretoEat.Controls.Add(this.btnEatIn);
            this.gbWheretoEat.Controls.Add(this.btnTakeOut);
            resources.ApplyResources(this.gbWheretoEat, "gbWheretoEat");
            this.gbWheretoEat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbWheretoEat.Name = "gbWheretoEat";
            this.gbWheretoEat.TabStop = false;
            // 
            // btnEatIn
            // 
            resources.ApplyResources(this.btnEatIn, "btnEatIn");
            this.btnEatIn.Checked = true;
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.TabStop = true;
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.CheckedChanged += new System.EventHandler(this.btnEatIn_CheckedChanged);
            // 
            // btnTakeOut
            // 
            resources.ApplyResources(this.btnTakeOut, "btnTakeOut");
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.CheckedChanged += new System.EventHandler(this.btnTakeOut_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.btnSmall);
            this.gbSize.Controls.Add(this.btnLarg);
            this.gbSize.Controls.Add(this.btnMedium);
            resources.ApplyResources(this.gbSize, "gbSize");
            this.gbSize.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbSize.Name = "gbSize";
            this.gbSize.TabStop = false;
            // 
            // btnSmall
            // 
            resources.ApplyResources(this.btnSmall, "btnSmall");
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.TabStop = true;
            this.btnSmall.Tag = "20";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.CheckedChanged += new System.EventHandler(this.btnSmall_CheckedChanged);
            // 
            // btnLarg
            // 
            resources.ApplyResources(this.btnLarg, "btnLarg");
            this.btnLarg.Name = "btnLarg";
            this.btnLarg.TabStop = true;
            this.btnLarg.Tag = "40";
            this.btnLarg.UseVisualStyleBackColor = true;
            this.btnLarg.CheckedChanged += new System.EventHandler(this.btnLarg_CheckedChanged);
            // 
            // btnMedium
            // 
            resources.ApplyResources(this.btnMedium, "btnMedium");
            this.btnMedium.Checked = true;
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.TabStop = true;
            this.btnMedium.Tag = "30";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.CheckedChanged += new System.EventHandler(this.btnMedium_CheckedChanged);
            // 
            // btnResetForm
            // 
            resources.ApplyResources(this.btnResetForm, "btnResetForm");
            this.btnResetForm.BackColor = System.Drawing.Color.Sienna;
            this.btnResetForm.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // lblNumOfPizzas
            // 
            resources.ApplyResources(this.lblNumOfPizzas, "lblNumOfPizzas");
            this.lblNumOfPizzas.Name = "lblNumOfPizzas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SubForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::PizzaProj.Properties.Resources.delicious_pizza_studio;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbWheretoEat);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btnResetForm);
            this.Name = "SubForm";
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbWheretoEat.ResumeLayout(false);
            this.gbWheretoEat.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton btnThin;
        private System.Windows.Forms.RadioButton btnThick;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblSummarySize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSummaryWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSummaryCrust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbWheretoEat;
        private System.Windows.Forms.RadioButton btnEatIn;
        private System.Windows.Forms.RadioButton btnTakeOut;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton btnSmall;
        private System.Windows.Forms.RadioButton btnLarg;
        private System.Windows.Forms.RadioButton btnMedium;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumOfPizzas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}