using System.Data;
using System.Windows.Forms;

namespace Aircraft
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdmPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeletButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.number_of_seats = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdmPanel
            // 
            this.AdmPanel.AutoSize = true;
            this.AdmPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AdmPanel.Controls.Add(this.groupBox2);
            this.AdmPanel.Controls.Add(this.groupBox1);
            this.AdmPanel.Controls.Add(this.GridView);
            this.AdmPanel.Controls.Add(this.menuStrip1);
            this.AdmPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdmPanel.Location = new System.Drawing.Point(0, 0);
            this.AdmPanel.Name = "AdmPanel";
            this.AdmPanel.Size = new System.Drawing.Size(800, 529);
            this.AdmPanel.TabIndex = 0;
            this.AdmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdmPanel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeletButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 90);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // DeletButton
            // 
            this.DeletButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletButton.Location = new System.Drawing.Point(578, 19);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(151, 47);
            this.DeletButton.TabIndex = 4;
            this.DeletButton.Text = "Видалити";
            this.DeletButton.UseVisualStyleBackColor = true;
            this.DeletButton.Click += new System.EventHandler(this.DeletButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(297, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(171, 47);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Оновити";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(40, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(166, 47);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_text);
            this.groupBox1.Controls.Add(this.number_of_seats);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(618, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Місця";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Імя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // id_text
            // 
            this.id_text.AccessibleName = "";
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_text.Location = new System.Drawing.Point(29, 50);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(201, 31);
            this.id_text.TabIndex = 5;
            this.id_text.Tag = "";
            // 
            // number_of_seats
            // 
            this.number_of_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_seats.Location = new System.Drawing.Point(554, 50);
            this.number_of_seats.Name = "number_of_seats";
            this.number_of_seats.Size = new System.Drawing.Size(204, 31);
            this.number_of_seats.TabIndex = 6;
            this.number_of_seats.TextChanged += new System.EventHandler(this.number_of_seats_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(277, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 31);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.Location = new System.Drawing.Point(0, 24);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 321);
            this.GridView.TabIndex = 3;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aircraftToolStripMenuItem,
            this.flightsToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.ticketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aircraftToolStripMenuItem
            // 
            this.aircraftToolStripMenuItem.Name = "aircraftToolStripMenuItem";
            this.aircraftToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aircraftToolStripMenuItem.Text = "Aircraft";
            this.aircraftToolStripMenuItem.Click += new System.EventHandler(this.aircraftToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            this.flightsToolStripMenuItem.Click += new System.EventHandler(this.flightsToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.routesToolStripMenuItem.Text = "Routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ticketsToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.AdmPanel);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.AdmPanel.ResumeLayout(false);
            this.AdmPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AdmPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView GridView;
        private Button DeletButton;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox id_text;
        private TextBox number_of_seats;
        private TextBox name;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aircraftToolStripMenuItem;
        private ToolStripMenuItem flightsToolStripMenuItem;
        private ToolStripMenuItem routesToolStripMenuItem;
        private ToolStripMenuItem ticketsToolStripMenuItem;
    }
}