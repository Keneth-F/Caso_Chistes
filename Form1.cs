using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_Chistes
{
    public partial class Form1 : Form
    {
        private string joke = "¿Por qué los programadores siempre confían en los valores por defecto?\nPorque son los únicos que nunca los decepcionan.";
        private int currentIndex = 0;
        private Random random = new Random();
        private Color color;
        public Form1()
        {
            InitializeComponent();
            color = GenerateRandomColor();
            typingTimer.Tick += (object sender, EventArgs e) =>
                {
                    LblJoke.ForeColor = color;
                    if (currentIndex < joke.Length)
                    {
                        LblJoke.Text += joke[currentIndex];
                        currentIndex++;
                    }
                    else
                    {
                        typingTimer.Stop();
                    }
                };
        }

        private async void BtnTellJoke_Click(object sender, EventArgs e)
        {
            joke = await GenerateJoke();
            color = GenerateRandomColor();
            LblJoke.Text = "";
            currentIndex = 0;
            typingTimer.Start();
        }

        private async Task<string> GenerateJoke()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var res = await httpClient.GetAsync("https://v2.jokeapi.dev/joke/Any?lang=es&type=single");
                    res.EnsureSuccessStatusCode();
                    var data = await res.Content.ReadAsStringAsync();
                    var json = JsonConvert.DeserializeObject<dynamic>(data);
                    return json["joke"];
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            return "¿Por qué los programadores prefieren el infierno al manejo de excepciones?\nPorque en el infierno al menos saben que hay un error, ¡pero en el manejo de excepciones pueden pasar horas atrapando nada!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typingTimer.Start();
        }
        private Color GenerateRandomColor()
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }
    }
}
