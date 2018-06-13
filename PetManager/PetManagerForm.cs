using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManager {
    public partial class PetManagerForm : Form {
        public PetManagerForm() {
            InitializeComponent();

            this.dgvPerson.DataSource = Person.GetDemoData();
            this.dgvPerson.Rows[0].Selected = true;
        }

        private void dgvPerson_SelectionChanged(object sender, EventArgs e) {
            var dgv = (DataGridView) sender;
            if (dgv.SelectedRows.Count > 0) {
                var person = (Person)dgv.SelectedRows[0].DataBoundItem;
                this.dgvPet.DataSource = person.Pets;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e) {
            var personList = (BindingList<Person>) this.dgvPerson.DataSource;
            personList.Add(new Person());
            this.dgvPerson.Refresh();
        }

        private void btnRemovePerson_Click(object sender, EventArgs e) {
            if (this.dgvPerson.SelectedRows.Count > 0) {
                var person = (Person)this.dgvPerson.SelectedRows[0].DataBoundItem;
                var personList = (BindingList<Person>)this.dgvPerson.DataSource;
                personList.Remove(person);
            } else {
                MessageBox.Show("You have to select a person first.", "Remove person", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddPet_Click(object sender, EventArgs e) {
            if (this.dgvPerson.SelectedRows.Count > 0) {
                var person = (Person)this.dgvPerson.SelectedRows[0].DataBoundItem;
                person.Pets.Add(new Pet());
            } else {
                MessageBox.Show("You have to select a person first.", "Add pet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemovePet_Click(object sender, EventArgs e) {
            if (this.dgvPet.SelectedRows.Count > 0) {
                var person = (Person)this.dgvPerson.SelectedRows[0].DataBoundItem;
                var pet = (Pet)this.dgvPet.SelectedRows[0].DataBoundItem;
                person.Pets.Remove(pet);
            } else {
                MessageBox.Show("You have to select a pet first.", "Remove pet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowStatistic_Click(object sender, EventArgs e) {
            var personList = (BindingList<Person>)this.dgvPerson.DataSource;
            new StatisticForm(personList).ShowDialog(this);
        }
    }
}
