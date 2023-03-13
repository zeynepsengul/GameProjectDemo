using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
