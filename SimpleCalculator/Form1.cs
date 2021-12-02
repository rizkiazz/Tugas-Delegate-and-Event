using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmHasilHitung : Form
    {
        private List<ClassHitung> listhasil = new List<ClassHitung>();
        public FrmHasilHitung()
        {
            InitializeComponent();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
           

            FormHitung formHitung = new FormHitung();
            formHitung.ShowDialog();
        }

        private void formHitung_OnButtonClick(ClassHitung hitung)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listhasil.Add(hitung);
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem();
            listBoxHasil.Items.Add(item);
        }

    }
}
