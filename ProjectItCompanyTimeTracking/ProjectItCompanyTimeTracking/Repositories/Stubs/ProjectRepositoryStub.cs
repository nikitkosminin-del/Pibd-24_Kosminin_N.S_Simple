using System.Collections.Generic;
using System.Linq;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Repositories.Stubs
{
	/// <summary>
	/// Заглушка репозитория проектов (хранение в памяти).
	/// </summary>
	public class ProjectRepositoryStub : IProjectRepository
	{
		private readonly List<Project> _projects = new List<Project>();

		public IReadOnlyList<Project> GetAll()
		{
			return _projects.ToList();
		}

		public Project GetById(int id)
		{
			return _projects.FirstOrDefault(project => project.Id == id);
		}

		public void Add(Project project)
		{
			_projects.Add(project);
		}

		public void Update(Project project)
		{
			int index = _projects.FindIndex(existing => existing.Id == project.Id);
			if (index >= 0)
			{
				_projects[index] = project;
			}
		}

		public void Delete(int id)
		{
			_projects.RemoveAll(project => project.Id == id);
		}
	}
}