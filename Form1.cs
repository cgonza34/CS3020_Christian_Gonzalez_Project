namespace Christian_Gonzalez_Project
{
    public partial class Form1 : Form
    {
        // your runtime property assignments go here
        List<int> diceInformation;
        string fileDestination;
        IRollableTokenManager tokenManager;

        public Form1()
        {
            InitializeComponent();

            diceInformation = new List<int>() { (int)nudNumDice.Value, (int)nudNumSides.Value };
            fileDestination = AppDomain.CurrentDomain.BaseDirectory;
            tokenManager = new DiceManager();
        }

        private void nudNumDice_ValueChanged(object sender, EventArgs e)
        {
            diceInformation[0] = (int)nudNumDice.Value;
        }

        private void nudNumSides_ValueChanged(object sender, EventArgs e)
        {
            diceInformation[1] = (int)nudNumSides.Value;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            rtbHistory.AppendText(tokenManager.RollTokens(diceInformation));
            rtbStatistics.Clear();
            rtbStatistics.AppendText(tokenManager.GetStatistics());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbHistory.AppendText(tokenManager.SaveHistory(fileDestination));
        }
    }
}
