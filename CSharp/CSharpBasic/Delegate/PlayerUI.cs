using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class PlayerUI
    {
        public string HpText;

        public PlayerUI(Player player)
        {
            player.OnHpChagned += Refresh;
            Refresh(player.Hp);
        }

        public void Draw()
        {
            Console.WriteLine(HpText);
        }

        public void Refresh(int hp)
        {
            HpText =hp.ToString();
        }
    }
}
