using System;

namespace ProjectItCompanyTimeTracking.Models
{
	/// <summary>
	/// Специалист IT-компании.
	/// </summary>
	public class Specialist
	{
		public int Id { get; private set; }
		public string FullName { get; private set; }
		public int PositionId { get; private set; }
		public decimal BonusPercent { get; private set; }

		private Specialist()
		{
		}

		/// <summary>
		/// Статический метод создания специалиста с проверкой входных данных.
		/// </summary>
		public static Specialist Create(int id, string fullName, int positionId, decimal bonusPercent)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Идентификатор специалиста должен быть положительным.", nameof(id));
			}

			if (string.IsNullOrWhiteSpace(fullName))
			{
				throw new ArgumentException("ФИО не может быть пустым.", nameof(fullName));
			}

			if (positionId <= 0)
			{
				throw new ArgumentException("Идентификатор должности должен быть положительным.", nameof(positionId));
			}

			if (bonusPercent < 0 || bonusPercent > 100)
			{
				throw new ArgumentException("Процент надбавки должен быть в диапазоне 0..100.", nameof(bonusPercent));
			}

			return new Specialist
			{
				Id = id,
				FullName = fullName.Trim(),
				PositionId = positionId,
				BonusPercent = bonusPercent
			};
		}

		public override string ToString()
		{
			return $"{FullName} (надбавка {BonusPercent}%)";
		}
	}
}
