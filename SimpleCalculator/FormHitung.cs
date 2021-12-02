using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FormHitung : Form
    {
        public delegate int CreateEventHandler(int NilaiA, int NilaiB);
        public event CreateEventHandler OnButtonClick;
        public bool isNewData = true;

        private ClassHitung hitung;
        public int Penjumlahan(int NilaiA, int NilaiB)
        {
            return NilaiA + NilaiB;
        }
        public int Pengurangan(int NilaiA, int NilaiB)
        {
            return NilaiA - NilaiB;
        }
        public int Perkalian(int NilaiA, int NilaiB)
        {
            return NilaiA * NilaiB;
        }
        public int Pembagian(int NilaiA, int NilaiB)
        {
            return NilaiA / NilaiB;
        }

        public FormHitung()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (isNewData) hitung = new ClassHitung();
            var a = int.Parse(textBoxNilaiA.Text);
            var b = Convert.ToInt32(textBoxNilaiB.Text);

            if (isNewData)
            {
                textBoxNilaiA.Clear();
                textBoxNilaiB.Clear();
                textBoxNilaiA.Focus();
            }

        }
        private void formHitung_OnButtonClick(ClassHitung hitung)
        {
            // tampilkan data mhs yg baru ke list
            ListView listBoxHasil = new ListView();
            var a = int.Parse(textBoxNilaiA.Text);
            var b = Convert.ToInt32(textBoxNilaiB.Text);

            listBoxHasil.Items.Add(string.Format("Hasil Penjumlahan: {0} + {1} = {2}", a, b, Penjumlahan(a, b)));
            listBoxHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            listBoxHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b)));
            listBoxHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));

        }
    }
}
