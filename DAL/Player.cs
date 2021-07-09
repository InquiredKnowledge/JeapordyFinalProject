using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyFinal
{
    /// <summary>
    /// Player class
    /// </summary>
    [Serializable]
    public class Player
    {
        // Properties
        public string PlayerName { get; set; }
        public int Score { get; set; }

        // Constructors
        public Player(string name)
        {
            PlayerName = name;
            Score = 0;
        }

        public Player()
        {
            PlayerName = "Null";
            Score = 0;
        }
    }
}
