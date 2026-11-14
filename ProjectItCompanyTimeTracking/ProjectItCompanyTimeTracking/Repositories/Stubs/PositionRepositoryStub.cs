using System.Collections.Generic;
using System.Linq;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Repositories.Stubs
{
	/// <summary>
	/// Заглушка репозитория должностей (хранение в памяти).
	/// </summary>
	public class PositionRepositoryStub : IPositionRepository
	{
		private readonly List<Position> _positions = new List<Position>();

		public IReadOnlyList<Position> GetAll()
		{
			return _positions.ToList();
		}

		public Position GetById(int id)
		{
			return _positions.FirstOrDefault(position => position.Id == id);
		}

		public void Add(Position position)
		{
			_positions.Add(position);
		}

		public void Update(Position position)
		{
			int index = _positions.FindIndex(existing => existing.Id == position.Id);
			if (index >= 0)
			{
				_positions[index] = position;
			}
		}

		public void Delete(int id)
		{
			_positions.RemoveAll(position => position.Id == id);
		}
	}
}