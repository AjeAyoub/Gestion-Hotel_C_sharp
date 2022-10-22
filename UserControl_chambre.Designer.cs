namespace Gestion_Hotel_Submti
{
    partial class UserControl_chambre
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4_reservation = new System.Windows.Forms.ComboBox();
            this.comboBox3_reservation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2_reservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_reservation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker6_reservation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5_reservation = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Purple;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(266, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Type Chambre :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Purple;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(575, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Numéro :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox4_reservation
            // 
            this.comboBox4_reservation.FormattingEnabled = true;
            this.comboBox4_reservation.Location = new System.Drawing.Point(673, 129);
            this.comboBox4_reservation.Name = "comboBox4_reservation";
            this.comboBox4_reservation.Size = new System.Drawing.Size(186, 21);
            this.comboBox4_reservation.TabIndex = 27;
            this.comboBox4_reservation.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3_reservation
            // 
            this.comboBox3_reservation.FormattingEnabled = true;
            this.comboBox3_reservation.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Famille"});
            this.comboBox3_reservation.Location = new System.Drawing.Point(378, 129);
            this.comboBox3_reservation.Name = "comboBox3_reservation";
            this.comboBox3_reservation.Size = new System.Drawing.Size(189, 21);
            this.comboBox3_reservation.TabIndex = 26;
            this.comboBox3_reservation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(575, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "No person :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2_reservation
            // 
            this.textBox2_reservation.Location = new System.Drawing.Point(672, 92);
            this.textBox2_reservation.Name = "textBox2_reservation";
            this.textBox2_reservation.Size = new System.Drawing.Size(187, 20);
            this.textBox2_reservation.TabIndex = 24;
            this.textBox2_reservation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(267, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date Entré :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(575, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Sorté :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(267, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom & Prénom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1_reservation
            // 
            this.textBox1_reservation.Location = new System.Drawing.Point(378, 91);
            this.textBox1_reservation.Name = "textBox1_reservation";
            this.textBox1_reservation.Size = new System.Drawing.Size(187, 20);
            this.textBox1_reservation.TabIndex = 18;
            this.textBox1_reservation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(432, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Résevation Chambre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker6_reservation
            // 
            this.dateTimePicker6_reservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker6_reservation.Location = new System.Drawing.Point(673, 168);
            this.dateTimePicker6_reservation.Name = "dateTimePicker6_reservation";
            this.dateTimePicker6_reservation.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker6_reservation.TabIndex = 31;
            // 
            // dateTimePicker5_reservation
            // 
            this.dateTimePicker5_reservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5_reservation.Location = new System.Drawing.Point(378, 168);
            this.dateTimePicker5_reservation.Name = "dateTimePicker5_reservation";
            this.dateTimePicker5_reservation.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker5_reservation.TabIndex = 30;
            this.dateTimePicker5_reservation.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_reservation,
            this.Column2_reservation,
            this.Column3_reservation,
            this.Column4_reservation,
            this.Column5_reservation,
            this.Column6_reservation});
            this.dataGridView2.Location = new System.Drawing.Point(18, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1086, 311);
            this.dataGridView2.TabIndex = 37;
            // 
            // Column1_reservation
            // 
            this.Column1_reservation.HeaderText = "Nom & Prénom";
            this.Column1_reservation.Name = "Column1_reservation";
            this.Column1_reservation.ReadOnly = true;
            // 
            // Column2_reservation
            // 
            this.Column2_reservation.HeaderText = "Nombre personne";
            this.Column2_reservation.Name = "Column2_reservation";
            this.Column2_reservation.ReadOnly = true;
            // 
            // Column3_reservation
            // 
            this.Column3_reservation.HeaderText = "Type chambre";
            this.Column3_reservation.Name = "Column3_reservation";
            this.Column3_reservation.ReadOnly = true;
            // 
            // Column4_reservation
            // 
            this.Column4_reservation.HeaderText = "Numéro chambre";
            this.Column4_reservation.Name = "Column4_reservation";
            this.Column4_reservation.ReadOnly = true;
            // 
            // Column5_reservation
            // 
            this.Column5_reservation.HeaderText = "Date entré";
            this.Column5_reservation.Name = "Column5_reservation";
            this.Column5_reservation.ReadOnly = true;
            // 
            // Column6_reservation
            // 
            this.Column6_reservation.HeaderText = "Date sorté";
            this.Column6_reservation.Name = "Column6_reservation";
            this.Column6_reservation.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkViolet;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(523, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkViolet;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(659, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 39;
            this.button3.Text = "Effacer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.DarkViolet;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Location = new System.Drawing.Point(384, 211);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(118, 36);
            this.button_save.TabIndex = 38;
            this.button_save.Text = "Ajouter";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // UserControl_chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker6_reservation);
            this.Controls.Add(this.dateTimePicker5_reservation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4_reservation);
            this.Controls.Add(this.comboBox3_reservation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2_reservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_reservation);
            this.Controls.Add(this.label2);
            this.Name = "UserControl_chambre";
            this.Size = new System.Drawing.Size(1136, 627);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4_reservation;
        private System.Windows.Forms.ComboBox comboBox3_reservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2_reservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_reservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker6_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker5_reservation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6_reservation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_save;
    }
}
