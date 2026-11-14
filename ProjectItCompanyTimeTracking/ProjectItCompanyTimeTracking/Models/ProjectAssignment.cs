using System;
using ProjectItCompanyTimeTracking.Enums;

namespace ProjectItCompanyTimeTracking.Models
{
	/// <summary>
	/// Назначение специалиста на проект (связь многие-ко-многим с ролью).
	/// </summary>
	public class ProjectAssignment
	{
		public int Id { get; private set; }
		public int SpecialistId { get; private set; }
		public int ProjectId { get; private set; }
		public SpecialistRole Role { get; private set; }

		private ProjectAssignment()
		{
		}

		/// <summary>
		/// Статический метод создания назначения с проверкой входных данных.
		/// </summary>
		public static ProjectAssignment Create(int id, int specialistId, int projectId, SpecialistRole role)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Идентификатор назначения должен быть положительным.", nameof(id));
			}

			if (specialistId <= 0)
			{
				throw new ArgumentException("Идентификатор специалиста должен быть положительным.", nameof(specialistId));
			}

			if (projectId <= 0)
			{
				throw new ArgumentException("Идентификатор проекта должен быть положительным.", nameof(projectId));
			}

			if (role == SpecialistRole.None)
			{
				throw new ArgumentException("Роль должна быть указана.", nameof(role));
			}

			return new ProjectAssignment
			{
				Id = id,
				SpecialistId = specialistId,
				ProjectId = projectId,
				Role = role
			};
		}

		public override string ToString()
		{
			return $"Специалист {SpecialistId} → проект {ProjectId} ({Role})";
		}
	}
}
