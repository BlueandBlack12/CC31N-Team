using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModel
{
    public class GameProgress
    {
        Player CurrentPlayer { get; set; }

        public GameProgress ()
        {
            CurrentPlayer = new Player ();
            CurrentPlayer.Name = "Luffy";
            CurrentPlayer.Class = "Rubberman";
            CurrentPlayer.HP = 100;
            CurrentPlayer.EXP = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Money = 10;
        }
    }
}
