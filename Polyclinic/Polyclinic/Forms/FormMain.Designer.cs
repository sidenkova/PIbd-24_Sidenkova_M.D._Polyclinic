namespace Polyclinic.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem пациентыToolStripMenuItem;
        private ToolStripMenuItem врачиToolStripMenuItem;
        private ToolStripMenuItem болезниToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem посещенияToolStripMenuItem;
        private ToolStripMenuItem больничныеToolStripMenuItem;
        private ToolStripMenuItem связкаПациентВрачToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.справочникиToolStripMenuItem = new ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new ToolStripMenuItem();
            this.врачиToolStripMenuItem = new ToolStripMenuItem();
            this.болезниToolStripMenuItem = new ToolStripMenuItem();
            this.операцииToolStripMenuItem = new ToolStripMenuItem();
            this.посещенияToolStripMenuItem = new ToolStripMenuItem();
            this.больничныеToolStripMenuItem = new ToolStripMenuItem();
            this.связкаПациентВрачToolStripMenuItem = new ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new ToolStripMenuItem();

            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.справочникиToolStripMenuItem,
                this.операцииToolStripMenuItem,
                this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.пациентыToolStripMenuItem,
                this.врачиToolStripMenuItem,
                this.болезниToolStripMenuItem});
            this.справочникиToolStripMenuItem.Text = "Справочники";

            this.пациентыToolStripMenuItem.Text = "Пациенты";
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);

            this.врачиToolStripMenuItem.Text = "Врачи";
            this.врачиToolStripMenuItem.Click += new System.EventHandler(this.врачиToolStripMenuItem_Click);

            this.болезниToolStripMenuItem.Text = "Болезни";
            this.болезниToolStripMenuItem.Click += new System.EventHandler(this.болезниToolStripMenuItem_Click);

            this.операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.посещенияToolStripMenuItem,
                this.больничныеToolStripMenuItem,
                this.связкаПациентВрачToolStripMenuItem});
            this.операцииToolStripMenuItem.Text = "Операции";

            this.посещенияToolStripMenuItem.Text = "Посещения";
            this.посещенияToolStripMenuItem.Click += new System.EventHandler(this.посещенияToolStripMenuItem_Click);

            this.больничныеToolStripMenuItem.Text = "Больничные";
            this.больничныеToolStripMenuItem.Click += new System.EventHandler(this.больничныеToolStripMenuItem_Click);

            this.связкаПациентВрачToolStripMenuItem.Text = "Закрепление (Пациент-Врач)";
            this.связкаПациентВрачToolStripMenuItem.Click += new System.EventHandler(this.связкаПациентВрачToolStripMenuItem_Click);

            this.отчетыToolStripMenuItem.Text = "Отчеты";

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Поликлиника - Главная";
        }
    }
}