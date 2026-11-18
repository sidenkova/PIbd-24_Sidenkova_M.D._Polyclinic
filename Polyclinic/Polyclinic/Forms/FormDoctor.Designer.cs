namespace Polyclinic.Forms
{
    partial class FormDoctor
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelFullName; private TextBox textBoxFullName;
        private Label labelSpec; private ComboBox comboBoxSpecialization;
        private Label labelPhone; private TextBox textBoxPhone;
        private Button buttonSave; private Button buttonCancel;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelFullName = new Label(); this.textBoxFullName = new TextBox();
            this.labelSpec = new Label(); this.comboBoxSpecialization = new ComboBox();
            this.labelPhone = new Label(); this.textBoxPhone = new TextBox();
            this.buttonSave = new Button(); this.buttonCancel = new Button();
            this.SuspendLayout();

            this.labelFullName.Location = new System.Drawing.Point(20, 20); this.labelFullName.Text = "ФИО:"; this.labelFullName.AutoSize = true;
            this.textBoxFullName.Location = new System.Drawing.Point(120, 20); this.textBoxFullName.Size = new System.Drawing.Size(250, 23);

            this.labelSpec.Location = new System.Drawing.Point(20, 60); this.labelSpec.Text = "Специализация:"; this.labelSpec.AutoSize = true;
            this.comboBoxSpecialization.Location = new System.Drawing.Point(120, 60); this.comboBoxSpecialization.Size = new System.Drawing.Size(250, 23); this.comboBoxSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;

            this.labelPhone.Location = new System.Drawing.Point(20, 100); this.labelPhone.Text = "Телефон:"; this.labelPhone.AutoSize = true;
            this.textBoxPhone.Location = new System.Drawing.Point(120, 100); this.textBoxPhone.Size = new System.Drawing.Size(250, 23);

            this.buttonSave.Location = new System.Drawing.Point(120, 150); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(240, 150); this.buttonCancel.Size = new System.Drawing.Size(100, 30); this.buttonCancel.Text = "Отмена"; this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Controls.Add(this.labelFullName); this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelSpec); this.Controls.Add(this.comboBoxSpecialization);
            this.Controls.Add(this.labelPhone); this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonSave); this.Controls.Add(this.buttonCancel);
            this.Text = "Врач";
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}