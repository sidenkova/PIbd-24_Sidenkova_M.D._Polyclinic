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
    public partial class FormSickLeaves : Form
    {
        private readonly IUnityContainer _container;
        private readonly ISickLeaveRepository _repository;

        public FormSickLeaves(IUnityContainer container, ISickLeaveRepository repository) { InitializeComponent(); _container = container; _repository = repository; LoadList(); }
        private void LoadList() => dataGridViewData.DataSource = _repository.ReadSickLeaves();
        private void buttonAdd_Click(object sender, EventArgs e) { _container.Resolve<FormSickLeave>().ShowDialog(); LoadList(); }
    }
}