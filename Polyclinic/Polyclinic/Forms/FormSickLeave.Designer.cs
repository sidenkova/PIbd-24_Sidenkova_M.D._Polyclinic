namespace Polyclinic.Forms
{
    partial class FormSickLeave
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxPatient; private ComboBox comboBoxDoctor; private DateTimePicker dateTimePickerStart; private DateTimePicker dateTimePickerEnd; private Button buttonSave;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.comboBoxPatient = new ComboBox(); this.comboBoxDoctor = new ComboBox(); this.dateTimePickerStart = new DateTimePicker(); this.dateTimePickerEnd = new DateTimePicker(); this.buttonSave = new Button();
            this.SuspendLayout();
            this.comboBoxPatient.Location = new System.Drawing.Point(20, 20); this.comboBoxPatient.Size = new System.Drawing.Size(250, 23); this.comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Location = new System.Drawing.Point(20, 60); this.comboBoxDoctor.Size = new System.Drawing.Size(250, 23); this.comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dateTimePickerStart.Location = new System.Drawing.Point(20, 100); this.dateTimePickerStart.Size = new System.Drawing.Size(250, 23); this.dateTimePickerStart.Format = DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(20, 140); this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 23); this.dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            this.buttonSave.Location = new System.Drawing.Point(20, 190); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.comboBoxPatient); this.Controls.Add(this.comboBoxDoctor); this.Controls.Add(this.dateTimePickerStart); this.Controls.Add(this.dateTimePickerEnd); this.Controls.Add(this.buttonSave);
            this.Text = "Добавление больничного";
            this.ResumeLayout(false);
        }
    }
}