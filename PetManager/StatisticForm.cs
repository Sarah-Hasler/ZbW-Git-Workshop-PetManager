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
    public partial class StatisticForm : Form {
        public StatisticForm(ICollection<Person> persons) {
            InitializeComponent();

            var avg = 0m;
            if (persons.Any()) {
                var petCnt = 0m;
                foreach (var person in persons) {
                    petCnt += person.Pets.Count;
                }

                avg = petCnt / persons.Count;
            }

            this.lblVal.Text = string.Format(this.lblVal.Text, avg.ToString("N2"));
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
