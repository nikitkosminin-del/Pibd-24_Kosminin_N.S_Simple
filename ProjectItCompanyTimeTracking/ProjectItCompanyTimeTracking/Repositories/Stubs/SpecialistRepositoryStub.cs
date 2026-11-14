using System.Collections.Generic;
using System.Linq;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Repositories.Stubs
{
	/// <summary>
	/// Заглушка репозитория специалистов (хранение в памяти).
	/// </summary>
	public class SpecialistRepositoryStub : ISpecialistRepository
	{
		private readonly List<Specialist> _specialists = new List<Specialist>();

		public IReadOnlyList<Specialist> GetAll()
		{
			return _specialists.ToList();
		}

		public Specialist GetById(int id)
		{
			return _specialists.FirstOrDefault(specialist => specialist.Id == id);
		}

		public void Add(Specialist specialist)
		{
			_specialists.Add(specialist);
		}

		public void Update(Specialist specialist)
		{
			int index = _specialists.FindIndex(existing => existing.Id == specialist.Id);
			if (index >= 0)
			{
				_specialists[index] = specialist;
			}
		}

		public void Delete(int id)
		{
			_specialists.RemoveAll(specialist => specialist.Id == id);
		}
	}
}
