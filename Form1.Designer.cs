namespace SGBDlab1
{
    partial class Form1 
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
            this.dataGridViewDepartamente = new System.Windows.Forms.DataGridView();
            this.dataGridViewVoluntarii = new System.Windows.Forms.DataGridView();
            this.vezi_departamente = new System.Windows.Forms.Button();
            this.Departamente = new System.Windows.Forms.Label();
            this.Voluntarii = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.id_departament = new System.Windows.Forms.Label();
            this.adauga = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoluntarii)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartamente
            // 
            this.dataGridViewDepartamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamente.Location = new System.Drawing.Point(12, 347);
            this.dataGridViewDepartamente.Name = "dataGridViewDepartamente";
            this.dataGridViewDepartamente.RowHeadersWidth = 51;
            this.dataGridViewDepartamente.RowTemplate.Height = 24;
            this.dataGridViewDepartamente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartamente.Size = new System.Drawing.Size(304, 176);
            this.dataGridViewDepartamente.TabIndex = 0;
            this.dataGridViewDepartamente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dataGridViewVoluntarii
            // 
            this.dataGridViewVoluntarii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoluntarii.Location = new System.Drawing.Point(399, 347);
            this.dataGridViewVoluntarii.Name = "dataGridViewVoluntarii";
            this.dataGridViewVoluntarii.RowHeadersWidth = 51;
            this.dataGridViewVoluntarii.RowTemplate.Height = 24;
            this.dataGridViewVoluntarii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVoluntarii.Size = new System.Drawing.Size(304, 181);
            this.dataGridViewVoluntarii.TabIndex = 1;
            this.dataGridViewVoluntarii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // vezi_departamente
            // 
            this.vezi_departamente.Location = new System.Drawing.Point(125, 260);
            this.vezi_departamente.Name = "vezi_departamente";
            this.vezi_departamente.Size = new System.Drawing.Size(103, 65);
            this.vezi_departamente.TabIndex = 2;
            this.vezi_departamente.Text = "vezi departamente";
            this.vezi_departamente.UseVisualStyleBackColor = true;
            this.vezi_departamente.Click += new System.EventHandler(this.button5_Click);
            // 
            // Departamente
            // 
            this.Departamente.AutoSize = true;
            this.Departamente.Location = new System.Drawing.Point(12, 303);
            this.Departamente.Name = "Departamente";
            this.Departamente.Size = new System.Drawing.Size(93, 16);
            this.Departamente.TabIndex = 3;
            this.Departamente.Text = "Departamente";
            // 
            // Voluntarii
            // 
            this.Voluntarii.AutoSize = true;
            this.Voluntarii.Location = new System.Drawing.Point(399, 302);
            this.Voluntarii.Name = "Voluntarii";
            this.Voluntarii.Size = new System.Drawing.Size(62, 16);
            this.Voluntarii.TabIndex = 4;
            this.Voluntarii.Text = "Voluntarii";
            this.Voluntarii.Click += new System.EventHandler(this.label2_Click);
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(15, 48);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(40, 16);
            this.nume.TabIndex = 5;
            this.nume.Text = "nume";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(16, 141);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 16);
            this.email.TabIndex = 6;
            this.email.Text = "email\r\n";
            // 
            // id_departament
            // 
            this.id_departament.AutoSize = true;
            this.id_departament.Location = new System.Drawing.Point(179, 48);
            this.id_departament.Name = "id_departament";
            this.id_departament.Size = new System.Drawing.Size(101, 16);
            this.id_departament.TabIndex = 7;
            this.id_departament.Text = "id_departament";
            // 
            // adauga
            // 
            this.adauga.Location = new System.Drawing.Point(399, 60);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(78, 50);
            this.adauga.TabIndex = 8;
            this.adauga.Text = "adauga\r\n";
            this.adauga.UseVisualStyleBackColor = true;
            // 
            // sterge
            // 
            this.sterge.Location = new System.Drawing.Point(399, 141);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(78, 45);
            this.sterge.TabIndex = 9;
            this.sterge.Text = "sterge";
            this.sterge.UseVisualStyleBackColor = true;
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(402, 220);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(75, 58);
            this.modifica.TabIndex = 10;
            this.modifica.Text = "modifica";
            this.modifica.UseVisualStyleBackColor = true;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(12, 88);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(140, 22);
            this.textBoxNume.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(15, 179);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(258, 22);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(182, 88);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(737, 561);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.id_departament);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.Voluntarii);
            this.Controls.Add(this.Departamente);
            this.Controls.Add(this.vezi_departamente);
            this.Controls.Add(this.dataGridViewVoluntarii);
            this.Controls.Add(this.dataGridViewDepartamente);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoluntarii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Button vezi_departamente;
        private System.Windows.Forms.DataGridView dataGridViewDepartamente;
        private System.Windows.Forms.DataGridView dataGridViewVoluntarii;
        private System.Windows.Forms.Label Departamente;
        private System.Windows.Forms.Label Voluntarii;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label id_departament;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.Button sterge;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxId;
    }
}

