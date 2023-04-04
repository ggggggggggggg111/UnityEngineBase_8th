using Delegate;
using System.Threading.Tasks;

Player player = new Player();
PlayerUI playerUI = new PlayerUI(player);


while (true)
{
    
    playerUI.HpText = player.Hp.ToString();

    Task t1 = new Task(() => playerUI.Draw());
    Task t2 = new Task(() => player.Hp -= 1);

    t1.Start();
    t2.Start();

    playerUI.Draw();
    Thread.Sleep(1000);
}