namespace ProjectItCompanyTimeTracking.Forms
{
	partial class PositionListForm
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
			dgvPositions = new DataGridView();
			btnAdd = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			btnRefresh = new Button();
			((System.ComponentModel.ISupportInitialize)dgvPositions).BeginInit();
			SuspendLayout();
			// 
			// dgvPositions
			// 
			dgvPositions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPositions.Location = new Point(40, 34);
			dgvPositions.Name = "dgvPositions";
			dgvPositions.RowHeadersWidth = 62;
			dgvPositions.Size = new Size(721, 264);
			dgvPositions.TabIndex = 0;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(12, 404);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(112, 34);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Добавить";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(130, 404);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(150, 34);
			btnEdit.TabIndex = 2;
			btnEdit.Text = "Редактировать";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(410, 404);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(112, 34);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Удалить";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(292, 404);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(112, 34);
			btnRefresh.TabIndex = 4;
			btnRefresh.Text = "Обновить";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// PositionListForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnRefresh);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(dgvPositions);
			Name = "PositionListForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Должности";
			((System.ComponentModel.ISupportInitialize)dgvPositions).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvPositions;
		private Button btnAdd;
		private Button btnEdit;
		private Button btnDelete;
		private Button btnRefresh;
	}
}