using System.Collections.Generic;
using ProjectItCompanyTimeTracking.Models;

namespace ProjectItCompanyTimeTracking.Repositories.Interfaces
{
	/// <summary>
	/// Репозиторий записей учета времени (операция, ограниченный набор).
	/// </summary>
	public interface ITimeRecordRepository
	{
		IReadOnlyList<TimeRecord> GetAll();
		void Add(TimeRecord record);
	}
}
