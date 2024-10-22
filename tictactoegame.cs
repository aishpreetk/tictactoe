namespace tictactoe
{
    public partial class Form1 : Form
    {
        int nr = 0; // Keeps track of turns (number of moves)

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            nr++; // Increment move count
            Button b = (Button)sender;

            // Set larger font size for the button text
            b.Font = new Font(b.Font.FontFamily, 24);

            // Alternate between "O" and "X"
            if (nr % 2 != 0)
            {
                b.Text = "O";
            }
            else
            {
                b.Text = "X";
            }

            b.Enabled = false; // Disable button after click

            // Check for a win
            if ((b1.Text == b2.Text && b2.Text == b3.Text && b1.Enabled == false) ||
                (b4.Text == b5.Text && b5.Text == b6.Text && b4.Enabled == false) ||
                (b7.Text == b8.Text && b8.Text == b9.Text && b7.Enabled == false) ||
                (b1.Text == b4.Text && b4.Text == b7.Text && b1.Enabled == false) ||
                (b2.Text == b5.Text && b5.Text == b8.Text && b2.Enabled == false) ||
                (b3.Text == b6.Text && b6.Text == b9.Text && b3.Enabled == false) ||
                (b1.Text == b5.Text && b5.Text == b9.Text && b1.Enabled == false) ||
                (b3.Text == b5.Text && b5.Text == b7.Text && b3.Enabled == false))
            {
                string winner = (nr % 2 != 0) ? "O" : "X"; // Determine winner

                // Beautify the winner message with emojis and new lines
                MessageBox.Show($"{winner} Wins! ??\n\nCongratulations! ??", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Close the game after win
            }
            else if (CheckForDraw()) // Check for a draw if no one wins
            {
                // Display draw message with emoji
                MessageBox.Show("It's a Draw! ??", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the game after draw
            }
        }

        // Method to check for a draw
        private bool CheckForDraw()
        {
            // If all buttons are disabled (i.e., have been clicked), it's a draw
            return !b1.Enabled && !b2.Enabled && !b3.Enabled &&
                   !b4.Enabled && !b5.Enabled && !b6.Enabled &&
                   !b7.Enabled && !b8.Enabled && !b9.Enabled;
        }
    }
}
