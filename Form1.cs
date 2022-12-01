using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {

        classTicTacToe obj = new classTicTacToe();
        bool player = false; // false = 0, true = X
        public TicTacToe()
        {
            InitializeComponent();
        }
 
        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }
        //
        private void buttonCheck(Object sender, EventArgs e) {
            Button btn = (Button)sender;
            if (player)
            {
                btn.Text = "O";
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }
            else
            {
                btn.Text = "X";
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            //
            player = !player;
            //
            btn.Enabled = false;
            //btn.Click -= new EventHandler(buttonCheck);
            checkForWinner();
        }
        //
        /* if (obj.getToogleValue())
            {
                this.btnOne.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else 
            {
                this.btnOne.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }
            this.btnOne.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        */
        //
        private void btnOne_Click(object sender, EventArgs e) { }
        private void btnTwo_Click(object sender, EventArgs e) { }
        private void btnThree_Click(object sender, EventArgs e) { }
        private void btnFour_Click(object sender, EventArgs e) { }
        private void btnFive_Click(object sender, EventArgs e) { }
        private void btnSix_Click(object sender, EventArgs e) { }
        private void btnSeven_Click(object sender, EventArgs e) {}
        private void btnEight_Click(object sender, EventArgs e) { }
        private void btnNine_Click(object sender, EventArgs e) { }
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.btnOne.Text = null;
            this.btnTwo.Text = null;
            this.btnThree.Text = null;
            this.btnFour.Text = null;
            this.btnFive.Text = null;
            this.btnSix.Text = null;
            this.btnSeven.Text = null;
            this.btnEight.Text = null;
            this.btnNine.Text = null;
            //
            this.btnOne.Enabled = true;
            this.btnTwo.Enabled = true;
            this.btnThree.Enabled = true;
            this.btnFour.Enabled = true;
            this.btnFive.Enabled = true;
            this.btnSix.Enabled = true;
            this.btnSeven.Enabled = true;
            this.btnEight.Enabled = true;
            this.btnNine.Enabled = true;
            //
            this.lblPlaterStatus.Text = "Playing: Player 1";
        }
        private void checkForWinner()
        {
            if (this.btnOne.Text == "O" && this.btnTwo.Text == "O" && this.btnThree.Text == "O") //1
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                
                checkWinning();
            }
            if (this.btnOne.Text == "O" && this.btnFive.Text == "O" && this.btnNine.Text == "O") //2
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnOne.Text == "O" && this.btnFour.Text == "O" && this.btnSeven.Text == "O") //3
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnTwo.Text == "O" && this.btnFive.Text == "O" && this.btnEight.Text == "O") //4
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnThree.Text == "O" && this.btnSix.Text == "O" && this.btnNine.Text == "O") //5
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnThree.Text == "O" && this.btnFive.Text == "O" && this.btnSeven.Text == "O") //6
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnFour.Text == "O" && this.btnFive.Text == "O" && this.btnSix.Text == "O") //7
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            if (this.btnSeven.Text == "O" && this.btnEight.Text == "O" && this.btnNine.Text == "O") //8
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                lblPlaterStatus.ForeColor = System.Drawing.Color.Green;
                checkWinning();
            }
            //
            if (this.btnOne.Text == "X" && this.btnTwo.Text == "X" && this.btnThree.Text == "X") //9
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnOne.Text == "X" && this.btnFive.Text == "X" && this.btnNine.Text == "X") //10
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnOne.Text == "X" && this.btnFour.Text == "X" && this.btnSeven.Text == "X") //11
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnTwo.Text == "X" && this.btnFive.Text == "X" && this.btnEight.Text == "X") //12
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnThree.Text == "X" && this.btnSix.Text == "X" && this.btnNine.Text == "X") //13
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnThree.Text == "X" && this.btnFive.Text == "X" && this.btnSeven.Text == "X") //14
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnFour.Text == "X" && this.btnFive.Text == "X" && this.btnSix.Text == "x") //15
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
            if (this.btnSeven.Text == "X" && this.btnEight.Text == "X" && this.btnNine.Text == "X") //16
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                lblPlaterStatus.ForeColor = System.Drawing.Color.DarkBlue;
                checkWinning();
            }
        }
        private void checkWinning() {
            this.btnOne.Enabled = false;
            this.btnTwo.Enabled = false;
            this.btnThree.Enabled = false;
            this.btnFour.Enabled = false;
            this.btnFive.Enabled = false;
            this.btnSix.Enabled = false;
            this.btnSeven.Enabled = false;
            this.btnEight.Enabled = false;
            this.btnNine.Enabled = false;
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
    class classTicTacToe {
        bool toogleValue = true;
        String userOne = "O";
        String userTwo = "X";
        public void setToogleValue(bool toogleValue)
        {
            this.toogleValue = toogleValue;
        }
        public bool getToogleValue()
        {
            return this.toogleValue;
        }
        public void setUserOne(String userOne)
        {
            this.userOne = userOne;
        }
        public String getUserOne()
        {
            return userOne;
        }
        public void setUserTwo(String userTwo)
        {
            this.userTwo = userTwo;
        }
        public String getUserTwo()
        {
            return userTwo;
        }        
    }
}