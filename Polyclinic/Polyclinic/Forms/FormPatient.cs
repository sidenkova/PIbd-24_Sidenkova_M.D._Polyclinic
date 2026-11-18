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
    public partial class FormPatient : Form
    {
        private readonly IPatientRepository _repository;
        private int? _patientId;

        public FormPatient(IPatientRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        public void SetPatientId(int value)
        {
            var patient = _repository.ReadPatientById(value);
            if (patient == null) return;
            textBoxFullName.Text = patient.FullName;
            dateTimePickerBirth.Value = patient.BirthDate;
            textBoxPhone.Text = patient.Phone;
            textBoxAddress.Text = patient.Address;
            _patientId = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните ФИО и Телефон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = Patient.CreateEntity(
                _patientId ?? 0,
                textBoxFullName.Text,
                dateTimePickerBirth.Value,
                textBoxPhone.Text,
                textBoxAddress.Text
            );

            try
            {
                if (_patientId.HasValue)
                    _repository.UpdatePatient(patient);
                else
                    _repository.CreatePatient(patient);

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