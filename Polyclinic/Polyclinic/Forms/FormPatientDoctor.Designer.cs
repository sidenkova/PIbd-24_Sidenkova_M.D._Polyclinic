namespace Polyclinic.Forms
{
    partial class FormPatientDoctor
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxPatient; private ComboBox comboBoxDoctor; private Button buttonSave;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.comboBoxPatient = new ComboBox(); this.comboBoxDoctor = new ComboBox(); this.buttonSave = new Button();
            this.SuspendLayout();
            this.comboBoxPatient.Location = new System.Drawing.Point(20, 20); this.comboBoxPatient.Size = new System.Drawing.Size(250, 23); this.comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Location = new System.Drawing.Point(20, 60); this.comboBoxDoctor.Size = new System.Drawing.Size(250, 23); this.comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.buttonSave.Location = new System.Drawing.Point(20, 110); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.comboBoxPatient); this.Controls.Add(this.comboBoxDoctor); this.Controls.Add(this.buttonSave);
            this.Text = "Добавление связки";
            this.ResumeLayout(false);
        }
    }
}