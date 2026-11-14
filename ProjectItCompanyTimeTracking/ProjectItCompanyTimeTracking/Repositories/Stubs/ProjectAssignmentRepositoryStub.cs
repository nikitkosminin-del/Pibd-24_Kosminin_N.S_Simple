using System.Collections.Generic;
using System.Linq;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Repositories.Stubs
{
	/// <summary>
	/// Заглушка репозитория назначений на проекты (хранение в памяти).
	/// </summary>
	public class ProjectAssignmentRepositoryStub : IProjectAssignmentRepository
	{
		private readonly List<ProjectAssignment> _assignments = new List<ProjectAssignment>();

		public IReadOnlyList<ProjectAssignment> GetAll()
		{
			return _assignments.ToList();
		}

		public void Add(ProjectAssignment assignment)
		{
			_assignments.Add(assignment);
		}

		public void Delete(int id)
		{
			_assignments.RemoveAll(assignment => assignment.Id == id);
		}
	}
}