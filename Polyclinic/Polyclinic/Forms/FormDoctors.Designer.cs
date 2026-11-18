namespace Polyclinic.Forms
{
    partial class FormDoctors
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dataGridViewData = new DataGridView();
            this.buttonAdd = new Button();
            this.buttonEdit = new Button();
            this.buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewData.Dock = DockStyle.Left; this.dataGridViewData.Size = new System.Drawing.Size(600, 450);
            this.dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.ReadOnly = true; this.dataGridViewData.AllowUserToAddRows = false;

            this.buttonAdd.Location = new System.Drawing.Point(620, 20); this.buttonAdd.Size = new System.Drawing.Size(150, 40); this.buttonAdd.Text = "Добавить"; this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonEdit.Location = new System.Drawing.Point(620, 80); this.buttonEdit.Size = new System.Drawing.Size(150, 40); this.buttonEdit.Text = "Редактировать"; this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            this.buttonDelete.Location = new System.Drawing.Point(620, 140); this.buttonDelete.Size = new System.Drawing.Size(150, 40); this.buttonDelete.Text = "Удалить"; this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete); this.Controls.Add(this.buttonEdit); this.Controls.Add(this.buttonAdd); this.Controls.Add(this.dataGridViewData);
            this.Text = "Список врачей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
        }
    }
}