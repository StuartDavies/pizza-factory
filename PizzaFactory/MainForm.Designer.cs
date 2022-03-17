namespace PizzaFactory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PizzaCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.StartCookingButton = new System.Windows.Forms.Button();
            this.OvenCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CookedPizzasListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvenCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Count:";
            // 
            // PizzaCountNumeric
            // 
            this.PizzaCountNumeric.Location = new System.Drawing.Point(103, 23);
            this.PizzaCountNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PizzaCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PizzaCountNumeric.Name = "PizzaCountNumeric";
            this.PizzaCountNumeric.Size = new System.Drawing.Size(52, 23);
            this.PizzaCountNumeric.TabIndex = 2;
            this.PizzaCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartCookingButton
            // 
            this.StartCookingButton.Location = new System.Drawing.Point(161, 23);
            this.StartCookingButton.Name = "StartCookingButton";
            this.StartCookingButton.Size = new System.Drawing.Size(130, 23);
            this.StartCookingButton.TabIndex = 3;
            this.StartCookingButton.Text = "Start Cooking";
            this.StartCookingButton.UseVisualStyleBackColor = true;
            this.StartCookingButton.Click += new System.EventHandler(this.StartCookingButton_Click);
            // 
            // OvenCountNumeric
            // 
            this.OvenCountNumeric.Enabled = false;
            this.OvenCountNumeric.Location = new System.Drawing.Point(103, 57);
            this.OvenCountNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.OvenCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OvenCountNumeric.Name = "OvenCountNumeric";
            this.OvenCountNumeric.Size = new System.Drawing.Size(52, 23);
            this.OvenCountNumeric.TabIndex = 5;
            this.OvenCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oven Count:";
            // 
            // CookedPizzasListView
            // 
            this.CookedPizzasListView.AutoArrange = false;
            this.CookedPizzasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.CookedPizzasListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CookedPizzasListView.Location = new System.Drawing.Point(25, 109);
            this.CookedPizzasListView.Name = "CookedPizzasListView";
            this.CookedPizzasListView.Size = new System.Drawing.Size(487, 255);
            this.CookedPizzasListView.TabIndex = 6;
            this.CookedPizzasListView.UseCompatibleStateImageBehavior = false;
            this.CookedPizzasListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oven Number";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Crust";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toppings";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cooking Time (ms)";
            this.columnHeader4.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 523);
            this.Controls.Add(this.CookedPizzasListView);
            this.Controls.Add(this.OvenCountNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartCookingButton);
            this.Controls.Add(this.PizzaCountNumeric);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Pizza Factory";
            ((System.ComponentModel.ISupportInitialize)(this.PizzaCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvenCountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown PizzaCountNumeric;
        private Button StartCookingButton;
        private NumericUpDown OvenCountNumeric;
        private Label label2;
        private ListView CookedPizzasListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}