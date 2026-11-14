using System.Collections.Generic;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Repositories.Interfaces
{
	/// <summary>
	/// Репозиторий специалистов (справочник, полный CRUD).
	/// </summary>
	public interface ISpecialistRepository
	{
		IReadOnlyList<Specialist> GetAll();
		Specialist GetById(int id);
		void Add(Specialist specialist);
		void Update(Specialist specialist);
		void Delete(int id);
	}
}
