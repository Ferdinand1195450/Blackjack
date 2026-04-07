namespace Blackjack
{
    public partial class Form1 : Form
    {
        private List<string> deck = new List<string>();
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            MaakDeck();
        }

        private void MaakDeck()
        {
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

            deck.Clear();

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add($"{rank}_of_{suit}.png");
                }
            }
        }

        private void Shuffle()
        {
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Shuffle();
            textBox1.Text = "Deck geschud";
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (deck.Count == 0)
            {
                textBox1.Text = "Geen kaarten meer";
                return;
            }

            string card = deck[0];
            deck.RemoveAt(0);

            textBox1.Text = card;

            // als je picturebox gebruikt:
            string path = System.IO.Path.Combine(Application.StartupPath, "Cards", card);

            if (System.IO.File.Exists(path))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(path);
            }
        }
    }
}
