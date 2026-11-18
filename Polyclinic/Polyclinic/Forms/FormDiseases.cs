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
    public partial class FormDiseases : Form
    {
        private readonly IUnityContainer _container;
        private readonly IDiseaseRepository _repository;

        public FormDiseases(IUnityContainer container, IDiseaseRepository repository)
        {
            InitializeComponent();
            _container = container;
            _repository = repository;
            LoadList();
        }

        private void LoadList() => dataGridViewData.DataSource = _repository.ReadDiseases();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormDisease>().ShowDialog();
            LoadList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count == 0) return;
            var form = _container.Resolve<FormDisease>();
            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            form.SetDiseaseId(id);
            form.ShowDialog();
            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.DeleteDisease(Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value));
                LoadList();
            }
        }
    }
}