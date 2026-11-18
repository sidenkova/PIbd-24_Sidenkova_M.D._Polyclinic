namespace Polyclinic.Forms
{
    partial class FormPatient
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirth;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelFullName = new Label();
            this.textBoxFullName = new TextBox();
            this.labelBirthDate = new Label();
            this.dateTimePickerBirth = new DateTimePicker();
            this.labelPhone = new Label();
            this.textBoxPhone = new TextBox();
            this.labelAddress = new Label();
            this.textBoxAddress = new TextBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.SuspendLayout();

            this.labelFullName.Location = new System.Drawing.Point(20, 20);
            this.labelFullName.Text = "ФИО:";
            this.labelFullName.AutoSize = true;

            this.textBoxFullName.Location = new System.Drawing.Point(120, 20);
            this.textBoxFullName.Size = new System.Drawing.Size(250, 23);

            this.labelBirthDate.Location = new System.Drawing.Point(20, 60);
            this.labelBirthDate.Text = "Дата рождения:";
            this.labelBirthDate.AutoSize = true;

            this.dateTimePickerBirth.Location = new System.Drawing.Point(120, 60);
            this.dateTimePickerBirth.Size = new System.Drawing.Size(250, 23);
            this.dateTimePickerBirth.Format = DateTimePickerFormat.Short;

            this.labelPhone.Location = new System.Drawing.Point(20, 100);
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.AutoSize = true;

            this.textBoxPhone.Location = new System.Drawing.Point(120, 100);
            this.textBoxPhone.Size = new System.Drawing.Size(250, 23);

            this.labelAddress.Location = new System.Drawing.Point(20, 140);
            this.labelAddress.Text = "Адрес:";
            this.labelAddress.AutoSize = true;

            this.textBoxAddress.Location = new System.Drawing.Point(120, 140);
            this.textBoxAddress.Size = new System.Drawing.Size(250, 23);

            this.buttonSave.Location = new System.Drawing.Point(120, 190);
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            this.buttonCancel.Location = new System.Drawing.Point(240, 190);
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Text = "Пациент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}