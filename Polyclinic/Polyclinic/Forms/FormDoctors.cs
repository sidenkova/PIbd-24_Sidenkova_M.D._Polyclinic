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
    public partial class FormDoctors : Form
    {
        private readonly IUnityContainer _container;
        private readonly IDoctorRepository _repository;

        public FormDoctors(IUnityContainer container, IDoctorRepository repository)
        {
            InitializeComponent();
            _container = container;
            _repository = repository;
            LoadList();
        }

        private void LoadList() => dataGridViewData.DataSource = _repository.ReadDoctors();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormDoctor>().ShowDialog();
            LoadList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count == 0) return;

            var form = _container.Resolve<FormDoctor>();
            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            form.SetDoctorId(id);
            form.ShowDialog();

            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
                _repository.DeleteDoctor(id);
                LoadList();
            }
        }
    }
}