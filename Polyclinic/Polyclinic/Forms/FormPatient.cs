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
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text)) return;
            var patient = Patient.CreateEntity(_patientId ?? 0, textBoxFullName.Text, dateTimePickerBirth.Value, textBoxPhone.Text, textBoxAddress.Text);
            if (_patientId.HasValue) _repository.UpdatePatient(patient);
            else _repository.CreatePatient(patient);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}