using System;

namespace ProjectItCompanyTimeTracking.Models
{
	/// <summary>
	/// Запись учета рабочего времени специалиста на проекте.
	/// </summary>
	public class TimeRecord
	{
		public int Id { get; private set; }
		public int SpecialistId { get; private set; }
		public int ProjectId { get; private set; }
		public DateTime WorkDate { get; private set; }
		public decimal Hours { get; private set; }

		private TimeRecord()
		{
		}

		/// <summary>
		/// Статический метод создания записи учета времени с проверкой входных данных.
		/// </summary>
		public static TimeRecord Create(int id, int specialistId, int projectId, DateTime workDate, decimal hours)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Идентификатор записи должен быть положительным.", nameof(id));
			}

			if (specialistId <= 0)
			{
				throw new ArgumentException("Идентификатор специалиста должен быть положительным.", nameof(specialistId));
			}

			if (projectId <= 0)
			{
				throw new ArgumentException("Идентификатор проекта должен быть положительным.", nameof(projectId));
			}

			if (hours <= 0 || hours > 24)
			{
				throw new ArgumentException("Количество часов должно быть в диапазоне (0; 24].", nameof(hours));
			}

			return new TimeRecord
			{
				Id = id,
				SpecialistId = specialistId,
				ProjectId = projectId,
				WorkDate = workDate.Date,
				Hours = hours
			};
		}

		public override string ToString()
		{
			return $"{WorkDate:dd.MM.yyyy} — {Hours} ч (спец. {SpecialistId}, проект {ProjectId})";
		}
	}
}
