using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Example01
{
    public class GameSaveManager
    {
        private List<GameMemento> _saves = new List<GameMemento>();
        public void SaveGame(Game game)
        {
            _saves.Add(game.SaveGame());
        }

        public void LoadGame(Game game, int saveSlot)
        {
            game.LoadGame(_saves[saveSlot]);
        }
    }
}
