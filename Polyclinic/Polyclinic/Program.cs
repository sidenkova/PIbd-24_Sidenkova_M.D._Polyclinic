using Polyclinic.Data;
using Polyclinic.Forms;
using Polyclinic.Repositories;
using Polyclinic.Repositories.Implementations;
using Unity;
using Unity.Lifetime;
using Serilog;
using Serilog.Events;

namespace Polyclinic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day).CreateLogger();
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormMain>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<DataContext>(new TransientLifetimeManager());
            container.RegisterType<IPatientRepository, PatientRepository>();
            container.RegisterType<IDoctorRepository, DoctorRepository>();
            container.RegisterType<IDiseaseRepository, DiseaseRepository>();
            container.RegisterType<IVisitRepository, VisitRepository>();
            container.RegisterType<ISickLeaveRepository, SickLeaveRepository>();
            container.RegisterType<IPatientDoctorRepository, PatientDoctorRepository>();
            return container;
        }
    }
}