namespace Simulated_annealing
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.iterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.endTempNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.initialTempNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTempNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialTempNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(662, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count of the points:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(668, 25);
            this.numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 3;
            this.numericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(668, 51);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(120, 23);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Draw points";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(668, 80);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Enabled = false;
            this.RunButton.Location = new System.Drawing.Point(668, 109);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(120, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // iterationNumericUpDown
            // 
            this.iterationNumericUpDown.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterationNumericUpDown.Location = new System.Drawing.Point(668, 418);
            this.iterationNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.iterationNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterationNumericUpDown.Name = "iterationNumericUpDown";
            this.iterationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.iterationNumericUpDown.TabIndex = 7;
            this.iterationNumericUpDown.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Count of iterations:";
            // 
            // endTempNumeric
            // 
            this.endTempNumeric.DecimalPlaces = 5;
            this.endTempNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.endTempNumeric.Location = new System.Drawing.Point(668, 379);
            this.endTempNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endTempNumeric.Name = "endTempNumeric";
            this.endTempNumeric.Size = new System.Drawing.Size(120, 20);
            this.endTempNumeric.TabIndex = 9;
            this.endTempNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Final temperature";
            // 
            // initialTempNumeric
            // 
            this.initialTempNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.initialTempNumeric.Location = new System.Drawing.Point(668, 340);
            this.initialTempNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.initialTempNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.initialTempNumeric.Name = "initialTempNumeric";
            this.initialTempNumeric.Size = new System.Drawing.Size(120, 20);
            this.initialTempNumeric.TabIndex = 11;
            this.initialTempNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Initial temperature";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialTempNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTempNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iterationNumericUpDown);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Simulated Annealing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTempNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialTempNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Button SetButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.NumericUpDown iterationNumericUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown endTempNumeric;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown initialTempNumeric;
		private System.Windows.Forms.Label label4;
	}
}

