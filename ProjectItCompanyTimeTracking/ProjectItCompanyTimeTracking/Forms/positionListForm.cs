using System;
using System.Windows.Forms;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Forms
{
	/// <summary>
	/// Форма списка должностей с возможностью добавления, редактирования и удаления.
	/// </summary>
	public partial class PositionListForm : Form
	{
		private readonly IPositionRepository _positionRepository;

		public PositionListForm(IPositionRepository positionRepository)
		{
			InitializeComponent();
			_positionRepository = positionRepository;
			LoadPositions();
		}

		private void LoadPositions()
		{
			dgvPositions.DataSource = null;
			dgvPositions.DataSource = _positionRepository.GetAll();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var form = new PositionEditForm(null))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					_positionRepository.Add(form.Position);
					LoadPositions();
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvPositions.CurrentRow == null)
			{
				MessageBox.Show("Выберите должность для редактирования.", "Предупреждение",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var selected = (Position)dgvPositions.CurrentRow.DataBoundItem;
			using (var form = new PositionEditForm(selected))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					_positionRepository.Update(form.Position);
					LoadPositions();
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvPositions.CurrentRow == null)
			{
				MessageBox.Show("Выберите должность для удаления.", "Предупреждение",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var selected = (Position)dgvPositions.CurrentRow.DataBoundItem;
			var result = MessageBox.Show($"Удалить должность «{selected.Title}»?", "Подтверждение",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				_positionRepository.Delete(selected.Id);
				LoadPositions();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadPositions();
		}
	}
}