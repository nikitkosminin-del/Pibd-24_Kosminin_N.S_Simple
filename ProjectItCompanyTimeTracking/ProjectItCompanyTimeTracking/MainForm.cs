using System;
using System.Windows.Forms;
using Autofac;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;
using ProjectItCompanyTimeTracking.Services;

namespace ProjectItCompanyTimeTracking
{
	/// <summary>
	/// Главная форма приложения с меню навигации.
	/// </summary>
	public partial class MainForm : Form
	{
		private readonly IContainer _container;

		public MainForm()
		{
			InitializeComponent();
			_container = ContainerConfig.Build();
		}

		private void menuPositions_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Форма справочника «Должности» будет добавлена на следующем шаге.",
				"В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuSpecialists_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Форма справочника «Специалисты» будет добавлена на следующем шаге.",
				"В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuProjects_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Форма справочника «Проекты» будет добавлена на следующем шаге.",
				"В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuAssignments_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Форма «Назначения на проекты» будет добавлена на следующем шаге.",
				"В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuTimeRecords_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Форма «Учет времени» будет добавлена на следующем шаге.",
				"В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuReports_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Раздел отчетов находится в разработке.", "Отчеты",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
