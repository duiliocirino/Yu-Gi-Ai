using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Actions
{
    public abstract class Action
    {
        protected int _spellSpeed;
        private Player _player;

        protected Action(Player player)
        {
            _player = player;
        }

        public Player Player => _player;

        public abstract string GetName();
        public abstract void PerformAction();

        public static List<Action> GetActivateActionsFromList(List<Action> actions)
        {
             return actions.Where(x => x.GetType() == typeof(ActivateEffect)).ToList();
        }
    }
}