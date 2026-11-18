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
using Polyclinic.Entities.Enums;
using Polyclinic.Repositories;

namespace Polyclinic.Forms
{
    public partial class FormDoctor : Form
    {
        private readonly IDoctorRepository _repository;
        private int? _doctorId;

        public FormDoctor(IDoctorRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            comboBoxSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
        }

        public void SetDoctorId(int value)
        {
            var doctor = _repository.ReadDoctorById(value);
            if (doctor == null) return;
            textBoxFullName.Text = doctor.FullName;
            comboBoxSpecialization.SelectedItem = doctor.Specialization;
            textBoxPhone.Text = doctor.Phone;
            _doctorId = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text)) return;
            var doctor = Doctor.CreateEntity(_doctorId ?? 0, textBoxFullName.Text, (Specialization)comboBoxSpecialization.SelectedItem, textBoxPhone.Text);
            if (_doctorId.HasValue) _repository.UpdateDoctor(doctor); else _repository.CreateDoctor(doctor);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}