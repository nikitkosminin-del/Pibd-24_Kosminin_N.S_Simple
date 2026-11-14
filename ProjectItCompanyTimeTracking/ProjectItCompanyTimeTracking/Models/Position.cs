using System;

namespace ProjectItCompanyTimeTracking.Models
{
	/// <summary>
	/// Должность специалиста с базовой почасовой ставкой.
	/// </summary>
	public class Position
	{
		public int Id { get; private set; }
		public string Title { get; private set; }
		public decimal BaseHourlyRate { get; private set; }

		private Position()
		{
		}

		/// <summary>
		/// Статический метод создания должности с проверкой входных данных.
		/// </summary>
		public static Position Create(int id, string title, decimal baseHourlyRate)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Идентификатор должности должен быть положительным.", nameof(id));
			}

			if (string.IsNullOrWhiteSpace(title))
			{
				throw new ArgumentException("Название должности не может быть пустым.", nameof(title));
			}

			if (baseHourlyRate < 0)
			{
				throw new ArgumentException("Базовая ставка не может быть отрицательной.", nameof(baseHourlyRate));
			}

			return new Position
			{
				Id = id,
				Title = title.Trim(),
				BaseHourlyRate = baseHourlyRate
			};
		}

		public override string ToString()
		{
			return $"{Title} ({BaseHourlyRate} руб/ч)";
		}
	}
}