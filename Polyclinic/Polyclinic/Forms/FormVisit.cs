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
    public partial class FormVisit : Form
    {
        private readonly IVisitRepository _visitRepo;
        private readonly IPatientRepository _patientRepo;
        private readonly IDoctorRepository _doctorRepo;
        private readonly IDiseaseRepository _diseaseRepo;

        public FormVisit(IVisitRepository visitRepo, IPatientRepository patientRepo, IDoctorRepository doctorRepo, IDiseaseRepository diseaseRepo)
        {
            InitializeComponent();
            _visitRepo = visitRepo; _patientRepo = patientRepo; _doctorRepo = doctorRepo; _diseaseRepo = diseaseRepo;

            comboBoxPatient.DataSource = _patientRepo.ReadPatients(); comboBoxPatient.DisplayMember = "FullName"; comboBoxPatient.ValueMember = "Id";
            comboBoxDoctor.DataSource = _doctorRepo.ReadDoctors(); comboBoxDoctor.DisplayMember = "FullName"; comboBoxDoctor.ValueMember = "Id";
            comboBoxDisease.DataSource = _diseaseRepo.ReadDiseases(); comboBoxDisease.DisplayMember = "Name"; comboBoxDisease.ValueMember = "Id";
            checkedListBoxSymptoms.Items.AddRange(Enum.GetValues(typeof(Symptoms)).Cast<object>().ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex < 0 || comboBoxDoctor.SelectedIndex < 0 || comboBoxDisease.SelectedIndex < 0) return;
            Symptoms symptoms = Symptoms.None;
            foreach (var item in checkedListBoxSymptoms.CheckedItems) symptoms |= (Symptoms)item;
            _visitRepo.CreateVisit(Visit.CreateOperation(0, (int)comboBoxPatient.SelectedValue, (int)comboBoxDoctor.SelectedValue, (int)comboBoxDisease.SelectedValue, symptoms));
            Close();
        }
    }
}