using API;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly CatFactsContext _context = new CatFactsContext();
        private readonly HttpClient _client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void addCatFactBtn_Click(object sender, EventArgs e)
        {
            if (addCatFactInput.Text.Length != 0)
            {
                _context.CatFacts.Add(new CatFact { fact = addCatFactInput.Text, length = addCatFactInput.Text.Length });
                await _context.SaveChangesAsync();
                addCatFactInput.Clear();
                viewBox.Items.Clear();
            }
        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            var allData = new List<CatFact>();
            if (keyWordInput.Text.Length == 0 && maxLenghtInput.Value == 0)
            {
                allData = _context.CatFacts.ToList();
            }
            if (keyWordInput.Text.Length != 0 && maxLenghtInput.Value != 0)
            {
                allData = _context.CatFacts
                    .Where(catFact => catFact.fact.Contains(keyWordInput.Text) && catFact.length < maxLenghtInput.Value)
                    .ToList();
            }
            if (keyWordInput.Text.Length == 0 && maxLenghtInput.Value != 0)
            {
                allData = _context.CatFacts.Where(catFact => catFact.length < maxLenghtInput.Value).ToList();
            }
            if (keyWordInput.Text.Length != 0 && maxLenghtInput.Value == 0)
            {
                allData = _context.CatFacts.Where(catFact => catFact.fact.Contains(keyWordInput.Text)).ToList();
            }

            viewBox.Items.Clear();
            foreach (var data in allData)
            {
                viewBox.Items.Add(data);
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (viewBox.SelectedIndex != -1)
            {
                var selectedObject = (CatFact)viewBox.SelectedItem;
                viewBox.Items.RemoveAt(viewBox.SelectedIndex);
                _context.CatFacts.Remove(selectedObject);
                await _context.SaveChangesAsync();
            }
        }

        private async void getDataFromApiBtn_Click(object sender, EventArgs e)
        {
            string call = "https://catfact.ninja/fact";
            string response = await _client.GetStringAsync(call);
            CatFact catFact = JsonSerializer.Deserialize<CatFact>(response);
            _context.CatFacts.Add(catFact);
            await _context.SaveChangesAsync();
        }

        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            keyWordInput.Text = string.Empty;
            maxLenghtInput.Value = 0;
        }
    }
}