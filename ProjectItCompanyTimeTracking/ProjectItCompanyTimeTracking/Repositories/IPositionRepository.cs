using System.Collections.Generic;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Repositories.Interfaces
{
	/// <summary>
	/// Репозиторий должностей (справочник, полный CRUD).
	/// </summary>
	public interface IPositionRepository
	{
		IReadOnlyList<Position> GetAll();
		Position GetById(int id);
		void Add(Position position);
		void Update(Position position);
		void Delete(int id);
	}
}
