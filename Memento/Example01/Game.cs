namespace Memento.Example01
{
    public class Game
    {
        public GameState CurrentState { get; set; }
        public GameMemento SaveGame()
        {
            return new GameMemento(CurrentState);
        }

        public void LoadGame(GameMemento memento)
        {
            CurrentState = memento.State;
        }
    }
}
