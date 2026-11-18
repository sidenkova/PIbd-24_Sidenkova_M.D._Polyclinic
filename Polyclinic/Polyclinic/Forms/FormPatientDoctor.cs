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
    public partial class FormPatientDoctor : Form
    {
        private readonly IPatientDoctorRepository _linkRepo;
        private readonly IPatientRepository _patientRepo;
        private readonly IDoctorRepository _doctorRepo;

        public FormPatientDoctor(IPatientDoctorRepository linkRepo, IPatientRepository patientRepo, IDoctorRepository doctorRepo)
        {
            InitializeComponent();
            _linkRepo = linkRepo;
            _patientRepo = patientRepo;
            _doctorRepo = doctorRepo;

            comboBoxPatient.DataSource = _patientRepo.ReadPatients().ToList();
            comboBoxPatient.DisplayMember = "FullName";
            comboBoxPatient.ValueMember = "Id";

            comboBoxDoctor.DataSource = _doctorRepo.ReadDoctors().ToList();
            comboBoxDoctor.DisplayMember = "FullName";
            comboBoxDoctor.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex < 0 || comboBoxDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите пациента и врача!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var link = PatientDoctor.CreateLink(
                0,
                (int)comboBoxPatient.SelectedValue!,
                (int)comboBoxDoctor.SelectedValue!
            );

            try
            {
                _linkRepo.CreatePatientDoctor(link);
                Close();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Ошибка при сохранении: " + errorMsg, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}