using Unity;
using Polyclinic.Forms;
using Polyclinic.Repositories;
using Polyclinic.Repositories.Implementations;

namespace Polyclinic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormMain>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
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