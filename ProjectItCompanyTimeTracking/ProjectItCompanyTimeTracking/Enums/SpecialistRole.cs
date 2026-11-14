using System;

namespace ProjectItCompanyTimeTracking.Enums
{
	/// <summary>
	/// Роль специалиста на проекте. Флаговое перечисление — специалист может совмещать роли.
	/// </summary>
	[Flags]
	public enum SpecialistRole
	{
		None = 0,
		Manager = 1,
		Developer = 2,
		Tester = 4
	}
}