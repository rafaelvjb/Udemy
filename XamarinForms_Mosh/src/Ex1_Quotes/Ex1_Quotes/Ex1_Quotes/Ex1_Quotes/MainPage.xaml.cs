using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ex1_Quotes
{
    public partial class MainPage : ContentPage
    {
        private readonly List<string> _frases = new List<string>();
        private int _indexFrase = 0;

        public MainPage()
        {
            InitializeComponent();

            for (var i = 0; i < 5; i++)
            {
                _frases.Add($"Frase escrita concatenada: {i}");
            }

            Frases.Text = _frases.ElementAt(0);
        }

        private void ProximaFrase_OnClicked(object sender, EventArgs e)
        {
            _indexFrase = _indexFrase == _frases.Count - 1 ? 0 : _indexFrase + 1;
            
            Frases.Text = _frases.ElementAt(_indexFrase);
        }
    }
}
