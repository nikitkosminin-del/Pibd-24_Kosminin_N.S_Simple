using System.Collections.Generic;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Repositories.Interfaces
{
	/// <summary>
	/// Репозиторий проектов (справочник, полный CRUD).
	/// </summary>
	public interface IProjectRepository
	{
		IReadOnlyList<Project> GetAll();
		Project GetById(int id);
		void Add(Project project);
		void Update(Project project);
		void Delete(int id);
	}
}
