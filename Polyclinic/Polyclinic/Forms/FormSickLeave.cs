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
    public partial class FormSickLeave : Form
    {
        private readonly ISickLeaveRepository _sickLeaveRepo;
        private readonly IPatientRepository _patientRepo;
        private readonly IDoctorRepository _doctorRepo;

        public FormSickLeave(ISickLeaveRepository sickLeaveRepo, IPatientRepository patientRepo, IDoctorRepository doctorRepo)
        {
            InitializeComponent(); _sickLeaveRepo = sickLeaveRepo; _patientRepo = patientRepo; _doctorRepo = doctorRepo;
            comboBoxPatient.DataSource = _patientRepo.ReadPatients(); comboBoxPatient.DisplayMember = "FullName"; comboBoxPatient.ValueMember = "Id";
            comboBoxDoctor.DataSource = _doctorRepo.ReadDoctors(); comboBoxDoctor.DisplayMember = "FullName"; comboBoxDoctor.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex < 0 || comboBoxDoctor.SelectedIndex < 0) return;
            _sickLeaveRepo.CreateSickLeave(SickLeave.CreateOperation(0, (int)comboBoxPatient.SelectedValue, (int)comboBoxDoctor.SelectedValue, dateTimePickerStart.Value, dateTimePickerEnd.Value));
            Close();
        }
    }
}