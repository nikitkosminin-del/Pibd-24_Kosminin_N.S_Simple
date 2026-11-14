using System;
using System.Windows.Forms;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Forms
{
	/// <summary>
	/// Форма создания и редактирования должности.
	/// </summary>
	public partial class PositionEditForm : Form
	{
		public Position Position { get; private set; }

		public PositionEditForm(Position position)
		{
			InitializeComponent();
			Position = position;

			if (position != null)
			{
				txtId.Text = position.Id.ToString();
				txtId.ReadOnly = true;
				txtTitle.Text = position.Title;
				numBaseHourlyRate.Value = position.BaseHourlyRate;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Position != null
					? Position.Id
					: new Random().Next(1, int.MaxValue);

				var created = Position.Create(id, txtTitle.Text, numBaseHourlyRate.Value);
				Position = created;
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, "Ошибка проверки данных",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
