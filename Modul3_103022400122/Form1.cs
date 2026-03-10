using System.Runtime.Intrinsics.X86;

namespace Modul3_103022400122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Suhu = { "Celcius", "Farenheit", "Kelvin", "Reamur" };
            comboBox1.Items.AddRange(Suhu);
            comboBox2.Items.AddRange(Suhu);
            textBox2.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih Satuan terlebih dahulu!");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double nilaiSuhuAwal = 0;
            double nilaiSuhuAkhir = 0;

            try
            {
                nilaiSuhuAwal = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string suhuAwal = comboBox1.ToString();
            string suhuAkhir = comboBox2.ToString();
            //float nilaiSuhuAkhir = 0;
            if(suhuAwal == "Celcius")
            {
                if(suhuAkhir == "Farenheit") { nilaiSuhuAkhir = (nilaiSuhuAwal * 9 / 5) + 32; }
                else if(suhuAkhir == "Kelvin") { nilaiSuhuAkhir = nilaiSuhuAwal + 273; }
                else if(suhuAkhir == "Reamur") { nilaiSuhuAkhir = nilaiSuhuAwal * 4 / 5; }
                else if(suhuAkhir == "Celcius") { nilaiSuhuAkhir = nilaiSuhuAwal; }
            }
            else if(suhuAwal == "Farenheit")
            {
                if(suhuAkhir == "Celcius") { nilaiSuhuAkhir = (nilaiSuhuAwal - 32) * 5 / 9; }
                else if(suhuAkhir == "Kelvin") { nilaiSuhuAkhir = (nilaiSuhuAwal - 32) * 5 / 9 + 273; }
                else if(suhuAkhir == "Reamur") { nilaiSuhuAkhir = (nilaiSuhuAwal - 32) * 4 / 9; }
                else if(suhuAkhir == "Farenheit") { nilaiSuhuAkhir = nilaiSuhuAwal; }
            }
            else if(suhuAwal == "Kelvin")
            {
                if (suhuAkhir == "Celcius") { nilaiSuhuAkhir = nilaiSuhuAwal - 273; }
                else if(suhuAkhir == "Farenheit") { nilaiSuhuAwal = (nilaiSuhuAwal - 273) * 9 / 5 + 32; }
                else if(suhuAkhir == "Reamur") { nilaiSuhuAkhir = (nilaiSuhuAwal - 273) * 4 / 5; }
                else if(suhuAkhir == "Kelvin") { nilaiSuhuAkhir = nilaiSuhuAwal; }
            }
            else if(suhuAwal == "Reamur")
            {
                if(suhuAkhir == "Celcius") { nilaiSuhuAkhir = nilaiSuhuAwal * 5 / 4; }
                else if(suhuAkhir == "Farenheit") { nilaiSuhuAkhir = (nilaiSuhuAwal * 9 / 4) + 32; }
                else if(suhuAkhir == "Kelvin") { nilaiSuhuAkhir = (nilaiSuhuAwal * 5 / 4) + 273; }
                else if(suhuAkhir == "Reamur") { nilaiSuhuAkhir = nilaiSuhuAwal; }
            }
            textBox2.Text = "test";
        }
    }
}
