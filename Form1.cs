using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Transactions;

namespace HalloweenHangman
{
    public partial class Form1 : Form
    {
        #region Variables
        List<string> halloween = new List<string>
        {
            "halloween",
            "trick or treat",
            "spooky",
            "witches",
            "ghoul",
            "ghost",
            "pumpkin",
            "trick",
            "goblin",
            "bat",
            "eyeball",
            "jack o lantern",
            "skull",
            "mask",
            "costume",
            "phantom",
            "october",
            "treats",
            "cauldron",
            "candy corn",
            "werewolf",
            "spider web",
            "sinister",
            "tombstone",
            "scarecrow",
            "vampire",
            "graveyard",
            "monsters",
            "skeleton",
            "haunted"
        };
        int wrongGuess;
        Random random;
        string mysteryWord;
        char[] showWord;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wrongGuess = 0;
            random = new Random();
            mysteryWord = halloween[random.Next(halloween.Count)];
            showWord = new string('_', mysteryWord.Length).ToCharArray();
            string hangmanShowWord = string.Join(" ", showWord);
            lblHangmanWord.Text = hangmanShowWord;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            char submit = txtLetter.Text.ToLower()[0];
            bool correctLetter = false;
            for (int i = 0; i < mysteryWord.Length; i++)
            {
                if (mysteryWord[i]==submit)
                {
                    showWord[i] = submit;
                    correctLetter = true;
                }
            }

            lblHangmanWord.Text = string.Join(" ", showWord);
            if (!correctLetter)
            {
                ChangeHangmanPicture();
            }
            if (!lblHangmanWord.Text.Contains('_'))
            {
                MessageBox.Show("Excellent work! You WIN!");
                Application.Restart();
            }
        }

        private void ChangeHangmanPicture()
        {
            wrongGuess++;
            switch (wrongGuess)
            {
                case 1:
                    pbHangman.Image = Properties.Resources.Hangman1;
                    break;
                case 2:
                    pbHangman.Image = Properties.Resources.Hangman2;
                    break;
                case 3:
                    pbHangman.Image = Properties.Resources.Hangman3;
                    break;
                case 4:
                    pbHangman.Image = Properties.Resources.Hangman4;
                    break;
                case 5:
                    pbHangman.Image = Properties.Resources.Hangman5;
                    break;
                case 6:
                    pbHangman.Image = Properties.Resources.Hangman6;
                    MessageBox.Show("Sorry, you LOSE! The correct word was " + mysteryWord);
                    Application.Restart();
                    break;                  
            }
        }
    }
}
