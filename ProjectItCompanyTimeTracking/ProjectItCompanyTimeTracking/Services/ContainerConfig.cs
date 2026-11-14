using Autofac;
using ProjectItCompanyTimeTracking.Repositories.Interfaces;
using ProjectItCompanyTimeTracking.Repositories.Stubs;

namespace ProjectItCompanyTimeTracking.Services
{
	/// <summary>
	/// Конфигурация IoC-контейнера Autofac: регистрация всех зависимостей.
	/// </summary>
	public static class ContainerConfig
	{
		/// <summary>
		/// Создает и настраивает контейнер, возвращает готовый экземпляр.
		/// </summary>
		public static IContainer Build()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<PositionRepositoryStub>().As<IPositionRepository>().SingleInstance();
			builder.RegisterType<SpecialistRepositoryStub>().As<ISpecialistRepository>().SingleInstance();
			builder.RegisterType<ProjectRepositoryStub>().As<IProjectRepository>().SingleInstance();
			builder.RegisterType<ProjectAssignmentRepositoryStub>().As<IProjectAssignmentRepository>().SingleInstance();
			builder.RegisterType<TimeRecordRepositoryStub>().As<ITimeRecordRepository>().SingleInstance();

			return builder.Build();
		}
	}
}
