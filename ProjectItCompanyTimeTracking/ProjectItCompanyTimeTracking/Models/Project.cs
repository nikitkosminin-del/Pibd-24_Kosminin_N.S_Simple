using System;
using ProjectItCompanyTimeTracking.Enums;

namespace ProjectItCompanyTimeTracking.Models
{
	/// <summary>
	/// Проект компании.
	/// </summary>
	public class Project
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public ProjectType Type { get; private set; }

		private Project()
		{
		}

		/// <summary>
		/// Статический метод создания проекта с проверкой входных данных.
		/// </summary>
		public static Project Create(int id, string name, ProjectType type)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Идентификатор проекта должен быть положительным.", nameof(id));
			}

			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Название проекта не может быть пустым.", nameof(name));
			}

			return new Project
			{
				Id = id,
				Name = name.Trim(),
				Type = type
			};
		}

		public override string ToString()
		{
			return $"{Name} ({Type})";
		}
	}
}
