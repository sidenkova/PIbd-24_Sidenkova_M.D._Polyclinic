namespace Polyclinic.Forms
{
    partial class FormSickLeaves
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData; private Button buttonAdd;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dataGridViewData = new DataGridView(); this.buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit(); this.SuspendLayout();
            this.dataGridViewData.Dock = DockStyle.Left; this.dataGridViewData.Size = new System.Drawing.Size(600, 450); this.dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect; this.dataGridViewData.ReadOnly = true; this.dataGridViewData.AllowUserToAddRows = false;
            this.buttonAdd.Location = new System.Drawing.Point(620, 20); this.buttonAdd.Size = new System.Drawing.Size(150, 40); this.buttonAdd.Text = "Добавить"; this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd); this.Controls.Add(this.dataGridViewData);
            this.Text = "Список больничных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit(); this.ResumeLayout(false);
        }
    }
}