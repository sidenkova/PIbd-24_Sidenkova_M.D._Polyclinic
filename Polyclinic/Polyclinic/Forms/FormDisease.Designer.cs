namespace Polyclinic.Forms
{
    partial class FormDisease
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName; private TextBox textBoxName; private Label labelCode; private TextBox textBoxCode; private Button buttonSave; private Button buttonCancel;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.labelName = new Label(); this.textBoxName = new TextBox(); this.labelCode = new Label(); this.textBoxCode = new TextBox(); this.buttonSave = new Button(); this.buttonCancel = new Button();
            this.SuspendLayout();
            this.labelName.Location = new System.Drawing.Point(20, 20); this.labelName.Text = "Название:"; this.labelName.AutoSize = true;
            this.textBoxName.Location = new System.Drawing.Point(120, 20); this.textBoxName.Size = new System.Drawing.Size(250, 23);
            this.labelCode.Location = new System.Drawing.Point(20, 60); this.labelCode.Text = "Код МКБ:"; this.labelCode.AutoSize = true;
            this.textBoxCode.Location = new System.Drawing.Point(120, 60); this.textBoxCode.Size = new System.Drawing.Size(250, 23);
            this.buttonSave.Location = new System.Drawing.Point(120, 110); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить"; this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonCancel.Location = new System.Drawing.Point(240, 110); this.buttonCancel.Size = new System.Drawing.Size(100, 30); this.buttonCancel.Text = "Отмена"; this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.labelName); this.Controls.Add(this.textBoxName); this.Controls.Add(this.labelCode); this.Controls.Add(this.textBoxCode); this.Controls.Add(this.buttonSave); this.Controls.Add(this.buttonCancel);
            this.Text = "Болезнь";
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}