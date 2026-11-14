namespace ProjectItCompanyTimeTracking.Forms
{
	partial class PositionEditForm
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
			lblId = new Label();
			txtId = new TextBox();
			lblTitle = new Label();
			txtTitle = new TextBox();
			lblRate = new Label();
			numBaseHourlyRate = new NumericUpDown();
			btnSave = new Button();
			btnCancel = new Button();
			((System.ComponentModel.ISupportInitialize)numBaseHourlyRate).BeginInit();
			SuspendLayout();
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new Point(20, 8);
			lblId.Name = "lblId";
			lblId.Size = new Size(34, 25);
			lblId.TabIndex = 0;
			lblId.Text = "ID:";
			// 
			// txtId
			// 
			txtId.Location = new Point(60, 8);
			txtId.Name = "txtId";
			txtId.Size = new Size(150, 31);
			txtId.TabIndex = 1;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Location = new Point(16, 63);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(94, 25);
			lblTitle.TabIndex = 2;
			lblTitle.Text = "Название:";
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(116, 63);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(150, 31);
			txtTitle.TabIndex = 3;
			// 
			// lblRate
			// 
			lblRate.AutoSize = true;
			lblRate.Location = new Point(16, 127);
			lblRate.Name = "lblRate";
			lblRate.Size = new Size(133, 25);
			lblRate.TabIndex = 4;
			lblRate.Text = "Ставка (руб/ч):";
			// 
			// numBaseHourlyRate
			// 
			numBaseHourlyRate.DecimalPlaces = 2;
			numBaseHourlyRate.Location = new Point(20, 164);
			numBaseHourlyRate.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numBaseHourlyRate.Name = "numBaseHourlyRate";
			numBaseHourlyRate.Size = new Size(180, 31);
			numBaseHourlyRate.TabIndex = 5;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(16, 404);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(112, 34);
			btnSave.TabIndex = 6;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(676, 404);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(112, 34);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Отмена";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// PositionEditForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(numBaseHourlyRate);
			Controls.Add(lblRate);
			Controls.Add(txtTitle);
			Controls.Add(lblTitle);
			Controls.Add(txtId);
			Controls.Add(lblId);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "PositionEditForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Должность";
			((System.ComponentModel.ISupportInitialize)numBaseHourlyRate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblId;
		private TextBox txtId;
		private Label lblTitle;
		private TextBox txtTitle;
		private Label lblRate;
		private NumericUpDown numBaseHourlyRate;
		private Button btnSave;
		private Button btnCancel;
	}
}