using System.Collections.Generic;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Repositories.Interfaces
{
	/// <summary>
	/// Репозиторий назначений на проекты (связь многие-ко-многим, ограниченный набор).
	/// </summary>
	public interface IProjectAssignmentRepository
	{
		IReadOnlyList<ProjectAssignment> GetAll();
		void Add(ProjectAssignment assignment);
		void Delete(int id);
	}
}
