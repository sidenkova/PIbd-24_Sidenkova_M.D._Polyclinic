using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Polyclinic.Repositories;

namespace Polyclinic.Forms
{
    public partial class FormPatientDoctors : Form
    {
        private readonly IUnityContainer _container;
        private readonly IPatientDoctorRepository _repository;

        public FormPatientDoctors(IUnityContainer container, IPatientDoctorRepository repository) { InitializeComponent(); _container = container; _repository = repository; LoadList(); }
        private void LoadList() => dataGridViewData.DataSource = _repository.ReadPatientDoctors();
        private void buttonAdd_Click(object sender, EventArgs e) { _container.Resolve<FormPatientDoctor>().ShowDialog(); LoadList(); }
    }
}