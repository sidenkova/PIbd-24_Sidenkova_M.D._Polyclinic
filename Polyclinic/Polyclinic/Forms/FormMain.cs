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

namespace Polyclinic.Forms
{
    public partial class FormMain : Form
    {
        private readonly IUnityContainer _container;

        public FormMain(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormPatients>().ShowDialog();
        private void врачиToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormDoctors>().ShowDialog();
        private void болезниToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormDiseases>().ShowDialog();
        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormVisits>().ShowDialog();
        private void больничныеToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormSickLeaves>().ShowDialog();
        private void связкаПациентВрачToolStripMenuItem_Click(object sender, EventArgs e) => _container.Resolve<FormPatientDoctors>().ShowDialog();
    }
}