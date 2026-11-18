using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polyclinic.Entities;
using Polyclinic.Repositories;

namespace Polyclinic.Forms
{
    public partial class FormDisease : Form
    {
        private readonly IDiseaseRepository _repository;
        private int? _diseaseId;

        public FormDisease(IDiseaseRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        public void SetDiseaseId(int value)
        {
            var disease = _repository.ReadDiseaseById(value);
            if (disease == null) return;
            textBoxName.Text = disease.Name;
            textBoxCode.Text = disease.Code;
            _diseaseId = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxCode.Text))
            {
                MessageBox.Show("Заполните название и код!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var disease = Disease.CreateEntity(_diseaseId ?? 0, textBoxName.Text, textBoxCode.Text);

            try
            {
                if (_diseaseId.HasValue)
                    _repository.UpdateDisease(disease);
                else
                    _repository.CreateDisease(disease);

                Close();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Ошибка при сохранении: " + errorMsg, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}