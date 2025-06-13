using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Doviz_Click(object sender, EventArgs e)
        {
            D�vizKuru d�vizKuru = new D�vizKuru();
            await d�vizKuru.GetExchangeRates(LiraMetin, DolarMetin, EuroMetin, PoundMetin, YenMetin);
        }

       
            private async void Cevir_Click(object sender, EventArgs e)
            {
                D�vizKuru d�vizKuru = new D�vizKuru();

                // D�viz kur de�erlerini textbox'lara �ek
                await d�vizKuru.GetExchangeRates(LiraMetin, DolarMetin, EuroMetin, PoundMetin, YenMetin);

                // Kullan�c�n�n se�ti�i kurlar
                string secilenKur1 = comboBox1.SelectedItem.ToString();
                string secilenKur2 = comboBox2.SelectedItem.ToString();

                // D�viz kodlar�n� belirleme
                Dictionary<string, TextBox> kurTextBoxlari = new Dictionary<string, TextBox>
    {
        { "T�rk Liras�", LiraMetin },
        { "Amerikan Dolar�", DolarMetin },
        { "Avrupa Eurosu", EuroMetin },
        { "�ngiliz Poundu", PoundMetin },
        { "Japon Yeni", YenMetin }
    };

                if (!kurTextBoxlari.ContainsKey(secilenKur1) || !kurTextBoxlari.ContainsKey(secilenKur2))
                {
                    MessageBox.Show("L�tfen ge�erli bir para birimi se�in.");
                    return;
                }

                
                if (!decimal.TryParse(maskedTextBox1.Text, out decimal miktar))
                {
                    MessageBox.Show("L�tfen ge�erli bir miktar girin.");
                    return;
                }

               
                decimal kur1 = Convert.ToDecimal(kurTextBoxlari[secilenKur1].Text.Replace('.', ','));
                decimal kur2 = Convert.ToDecimal(kurTextBoxlari[secilenKur2].Text.Replace('.', ','));

                
                decimal sonuc = (miktar / kur1) * kur2;
                textBox1.Text = sonuc.ToString("N2");
            }

        }
    }
    public class D�vizKuru
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task GetExchangeRates(TextBox liraMetin, TextBox dolarMetin, TextBox euroMetin, TextBox poundMetin, TextBox yenMetin)
        {
            try
            {
                string apiLink = "https://api.exchangerate-api.com/v4/latest/TRY"; 
                HttpResponseMessage cevap = await client.GetAsync(apiLink);
                cevap.EnsureSuccessStatusCode();
                string jsonCevap = await cevap.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(jsonCevap);

                liraMetin.Text = "1"; 
                dolarMetin.Text = json["rates"]["USD"].ToString();
                euroMetin.Text = json["rates"]["EUR"].ToString();
                poundMetin.Text = json["rates"]["GBP"].ToString();
                yenMetin.Text = json["rates"]["JPY"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }

  
