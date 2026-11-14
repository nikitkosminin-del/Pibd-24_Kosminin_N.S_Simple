using System.Collections.Generic;
using System.Linq;
using ProjectItCompanyTimeTracking.Models;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;

namespace ProjectItCompanyTimeTracking.Repositories.Stubs
{
	/// <summary>
	/// Заглушка репозитория записей учета времени (хранение в памяти).
	/// </summary>
	public class TimeRecordRepositoryStub : ITimeRecordRepository
	{
		private readonly List<TimeRecord> _records = new List<TimeRecord>();

		public IReadOnlyList<TimeRecord> GetAll()
		{
			return _records.ToList();
		}

		public void Add(TimeRecord record)
		{
			_records.Add(record);
		}
	}
}
