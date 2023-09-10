using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace card_ident
{
    public partial class Form1 : Form
    {
        private const string CardNameLabelText = "My name is...";

        public Form1()
        {
            InitializeComponent();

            lblCardName.Text = CardNameLabelText;

            LoadCards();
            SetControlsSize();
        }

        private void LoadCards()
        {
            var cm = new CardManager(Resource1.ResourceManager);
            var cards = cm.GetCardCollection();

            // Set cards' images.

            var x = 0;

            foreach (var control in flpFiveCards.Controls.OfType<Control>())
            {
                var cardBox = (PictureBox)control;
                cardBox.Image = cards.ElementAt(x).image;
                cardBox.Size = cardBox.Image.Size;
                cardBox.Tag = cards.ElementAt(x).name;
                cardBox.Click += card_Click;
                x++;
            }
        }

        private void SetControlsSize()
        {
            Width = (pbOne.Width + pbOne.Margin.Left + pbOne.Margin.Right) * 5 +
                    pbOne.Margin.Left + pbOne.Margin.Right;

            Height = GetWindowTitleHeight() + lblTaskMessage.Height +
                     +pbOne.Height + pbOne.Margin.Top + pbOne.Margin.Bottom +
                     lblCardName.Height + btnExit.Height +
                     (btnExit.Margin.Top + btnExit.Margin.Bottom) * 2;
        }

        private int GetWindowTitleHeight()
        {
            var screenRectangle = RectangleToScreen(ClientRectangle);
            return Height - screenRectangle.Height;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            LoadCards();
            lblCardName.Text = CardNameLabelText;
        }

        private void card_Click(object sender, EventArgs e)
        {
            var tag = ((PictureBox)sender).Tag.ToString();
            lblCardName.Text = CardNameLabelText.Replace("...", " " + tag);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblTaskMessage.Width = Width;
            lblCardName.Width = Width;
            pnlButtons.Width = Width;

            var x = (Width - btnShuffle.Width) / 2 - btnShuffle.Width / 2 -
                    btnShuffle.Margin.Right;
            btnShuffle.Location = new Point(x, btnShuffle.Location.Y);
            x = (Width - btnExit.Width) / 2 + btnExit.Width / 2 +
                btnExit.Margin.Left;
            btnExit.Location = new Point(x, btnExit.Location.Y);
        }
    }
}