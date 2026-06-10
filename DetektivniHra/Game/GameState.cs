using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetektivniHra.Game
{
    public class GameState
    {
        public bool HasKey { get; set; } = false;
        public bool HasNote { get; set; } = false;
        public bool HasMap { get; set; } = false;
    }
}
