namespace Aircraft
{
    partial class routes
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
            this.label4 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.place_of_destination = new System.Windows.Forms.TextBox();
            this.place_of_departure = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.flightsToolStripMenuItem.Click += new System.EventHandler(this.flightsToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.routesToolStripMenuItem.Text = "routes";
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
            this.GridView.Size = new System.Drawing.Size(1027, 321);
            this.GridView.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.place_of_destination);
            this.groupBox1.Controls.Add(this.place_of_departure);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(859, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Відстань";
            // 
            // distance
            // 
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance.Location = new System.Drawing.Point(805, 50);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(204, 31);
            this.distance.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(554, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Місце призначення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(288, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Місце відправлення";
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
            // id
            // 
            this.id.AccessibleName = "";
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(29, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 31);
            this.id.TabIndex = 5;
            this.id.Tag = "";
            // 
            // place_of_destination
            // 
            this.place_of_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_of_destination.Location = new System.Drawing.Point(554, 50);
            this.place_of_destination.Name = "place_of_destination";
            this.place_of_destination.Size = new System.Drawing.Size(204, 31);
            this.place_of_destination.TabIndex = 6;
            // 
            // place_of_departure
            // 
            this.place_of_departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_of_departure.Location = new System.Drawing.Point(277, 50);
            this.place_of_departure.Name = "place_of_departure";
            this.place_of_departure.Size = new System.Drawing.Size(227, 31);
            this.place_of_departure.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.DeletButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // DeletButton
            // 
            this.DeletButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletButton.Location = new System.Drawing.Point(794, 33);
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
            this.updateButton.Location = new System.Drawing.Point(421, 33);
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
            this.addButton.Location = new System.Drawing.Point(64, 33);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(166, 47);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "routes";
            this.Text = "routes";
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
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox place_of_destination;
        private System.Windows.Forms.TextBox place_of_departure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
    }
}