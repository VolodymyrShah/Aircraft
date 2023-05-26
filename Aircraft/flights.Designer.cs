namespace Aircraft
{
    partial class flights
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flight_num = new System.Windows.Forms.TextBox();
            this.departure_time = new System.Windows.Forms.TextBox();
            this.departure_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.routes_id = new System.Windows.Forms.TextBox();
            this.aircraft_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeletButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aircraftToolStripMenuItem
            // 
            this.aircraftToolStripMenuItem.Name = "aircraftToolStripMenuItem";
            this.aircraftToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aircraftToolStripMenuItem.Text = "aircraft";
            this.aircraftToolStripMenuItem.Click += new System.EventHandler(this.aircraftToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.flightsToolStripMenuItem.Text = "flights";
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.routesToolStripMenuItem.Text = "routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ticketsToolStripMenuItem.Text = "tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ticketsToolStripMenuItem_Click);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.Location = new System.Drawing.Point(0, 24);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(964, 264);
            this.GridView.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.flight_num);
            this.groupBox1.Controls.Add(this.departure_time);
            this.groupBox1.Controls.Add(this.departure_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.routes_id);
            this.groupBox1.Controls.Add(this.aircraft_id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 177);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(551, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Час відправлення";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(181, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата відправлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(767, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Номер рейсу";
            // 
            // flight_num
            // 
            this.flight_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flight_num.Location = new System.Drawing.Point(737, 48);
            this.flight_num.Name = "flight_num";
            this.flight_num.Size = new System.Drawing.Size(204, 31);
            this.flight_num.TabIndex = 13;
            // 
            // departure_time
            // 
            this.departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departure_time.Location = new System.Drawing.Point(546, 125);
            this.departure_time.Name = "departure_time";
            this.departure_time.Size = new System.Drawing.Size(204, 31);
            this.departure_time.TabIndex = 12;
            // 
            // departure_date
            // 
            this.departure_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departure_date.Location = new System.Drawing.Point(174, 125);
            this.departure_date.Name = "departure_date";
            this.departure_date.Size = new System.Drawing.Size(204, 31);
            this.departure_date.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(507, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Маршрути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(242, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Літак ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.AccessibleName = "";
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(32, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(92, 31);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.Tag = "";
            // 
            // routes_id
            // 
            this.routes_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routes_id.Location = new System.Drawing.Point(457, 48);
            this.routes_id.Name = "routes_id";
            this.routes_id.Size = new System.Drawing.Size(204, 31);
            this.routes_id.TabIndex = 6;
            // 
            // aircraft_id
            // 
            this.aircraft_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aircraft_id.Location = new System.Drawing.Point(174, 48);
            this.aircraft_id.Name = "aircraft_id";
            this.aircraft_id.Size = new System.Drawing.Size(204, 31);
            this.aircraft_id.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.DeletButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // DeletButton
            // 
            this.DeletButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletButton.Location = new System.Drawing.Point(772, 34);
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
            this.updateButton.Location = new System.Drawing.Point(408, 34);
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
            this.addButton.Location = new System.Drawing.Point(52, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(166, 47);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "flights";
            this.Text = "flights";
            this.Load += new System.EventHandler(this.flights_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox routes_id;
        private System.Windows.Forms.TextBox aircraft_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flight_num;
        private System.Windows.Forms.TextBox departure_time;
        private System.Windows.Forms.TextBox departure_date;
    }
}