using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Service_Exercise2_052;
using System.Net;

namespace Exercise2_20180140052_Bramantyo_Adi_Yoga
{
    public partial class Form1 : Form
    {
        string baseUrl = 'http://localhost:1907/Mahasiswa';
        void BuatMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nama = textBox1.Text;
            mhs.nim = textBox2.Text;
            mhs.prodi = textBox3.Text;
            mhs.angkatan = textBox4.Text;
            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseUrl + "Mahasiswa", data);
            Console.WriteLine(response);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuatMahasiswa();
        }
    }
}
