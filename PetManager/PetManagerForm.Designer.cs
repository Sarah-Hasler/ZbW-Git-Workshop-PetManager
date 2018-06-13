namespace PetManager {
    partial class PetManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnRemovePet = new System.Windows.Forms.Button();
            this.btnShowStatistic = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AutoGenerateColumns = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn});
            this.dgvPerson.DataSource = this.personBindingSource;
            this.dgvPerson.Location = new System.Drawing.Point(12, 46);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(667, 150);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.SelectionChanged += new System.EventHandler(this.dgvPerson_SelectionChanged);
            // 
            // dgvPet
            // 
            this.dgvPet.AllowUserToAddRows = false;
            this.dgvPet.AllowUserToDeleteRows = false;
            this.dgvPet.AutoGenerateColumns = false;
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn});
            this.dgvPet.DataSource = this.petBindingSource;
            this.dgvPet.Location = new System.Drawing.Point(12, 256);
            this.dgvPet.MultiSelect = false;
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPet.Size = new System.Drawing.Size(667, 150);
            this.dgvPet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pet";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(445, 203);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(114, 23);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(565, 203);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(114, 23);
            this.btnRemovePerson.TabIndex = 3;
            this.btnRemovePerson.Text = "Remove Person";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(445, 412);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(114, 23);
            this.btnAddPet.TabIndex = 3;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnRemovePet
            // 
            this.btnRemovePet.Location = new System.Drawing.Point(565, 412);
            this.btnRemovePet.Name = "btnRemovePet";
            this.btnRemovePet.Size = new System.Drawing.Size(114, 23);
            this.btnRemovePet.TabIndex = 3;
            this.btnRemovePet.Text = "Remove Pet";
            this.btnRemovePet.UseVisualStyleBackColor = true;
            this.btnRemovePet.Click += new System.EventHandler(this.btnRemovePet_Click);
            // 
            // btnShowStatistic
            // 
            this.btnShowStatistic.Location = new System.Drawing.Point(325, 203);
            this.btnShowStatistic.Name = "btnShowStatistic";
            this.btnShowStatistic.Size = new System.Drawing.Size(114, 23);
            this.btnShowStatistic.TabIndex = 3;
            this.btnShowStatistic.Text = "ShowStatistic";
            this.btnShowStatistic.UseVisualStyleBackColor = true;
            this.btnShowStatistic.Click += new System.EventHandler(this.btnShowStatistic_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.Width = 200;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(PetManager.Pet);
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 300;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 300;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(PetManager.Person);
            // 
            // PetManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 451);
            this.Controls.Add(this.btnRemovePet);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.btnShowStatistic);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.dgvPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PetManagerForm";
            this.Text = "PetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnRemovePet;
        private System.Windows.Forms.Button btnShowStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
    }
}

