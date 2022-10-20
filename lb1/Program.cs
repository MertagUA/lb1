namespace lb1
{
public class Program
    {
        public static void Main(string[] args)
        {
            GameAccount userAccount = new GameAccount("Slava", 500);
            GameAccount opponentAccount = new GameAccount("Tomas", 500);

            userAccount.WinGame(opponentAccount, 90);
            userAccount.LoseGame(opponentAccount, 50);
            userAccount.WinGame(opponentAccount, 40);
            userAccount.LoseGame(opponentAccount, 20);
            userAccount.WinGame(opponentAccount, 70);

            userAccount.GetStats();
        }
    }
}