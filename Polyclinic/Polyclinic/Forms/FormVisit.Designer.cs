namespace Polyclinic.Forms
{
    partial class FormVisit
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxPatient; private ComboBox comboBoxDoctor; private ComboBox comboBoxDisease;
        private CheckedListBox checkedListBoxSymptoms; private Button buttonSave;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.comboBoxPatient = new ComboBox(); this.comboBoxDoctor = new ComboBox(); this.comboBoxDisease = new ComboBox(); this.checkedListBoxSymptoms = new CheckedListBox(); this.buttonSave = new Button();
            this.SuspendLayout();

            this.comboBoxPatient.Location = new System.Drawing.Point(20, 20); this.comboBoxPatient.Size = new System.Drawing.Size(250, 23); this.comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Location = new System.Drawing.Point(20, 60); this.comboBoxDoctor.Size = new System.Drawing.Size(250, 23); this.comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDisease.Location = new System.Drawing.Point(20, 100); this.comboBoxDisease.Size = new System.Drawing.Size(250, 23); this.comboBoxDisease.DropDownStyle = ComboBoxStyle.DropDownList;

            this.checkedListBoxSymptoms.Location = new System.Drawing.Point(300, 20); this.checkedListBoxSymptoms.Size = new System.Drawing.Size(200, 150); this.checkedListBoxSymptoms.CheckOnClick = true;

            this.buttonSave.Location = new System.Drawing.Point(20, 180); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            this.ClientSize = new System.Drawing.Size(530, 230);
            this.Controls.Add(this.comboBoxPatient); this.Controls.Add(this.comboBoxDoctor); this.Controls.Add(this.comboBoxDisease); this.Controls.Add(this.checkedListBoxSymptoms); this.Controls.Add(this.buttonSave);
            this.Text = "Добавление посещения";
            this.ResumeLayout(false);
        }
    }
}