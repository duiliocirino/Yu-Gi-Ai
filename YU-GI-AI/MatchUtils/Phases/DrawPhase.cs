using System.Collections.Generic;
using System.Linq;
using ConsoleApplication1.Actions;

namespace ConsoleApplication1.MatchUtils.Phases
{
    public class DrawPhase: IPhase
    {
        public DrawPhase()
        {
            Match.TurnPlayer.DrawCard();

            Action turnPlayerAction;
            List<Action> actions = Match.TurnPlayer.GetActions();
            if (actions.Count != 1){ turnPlayerAction = Match.TurnPlayer.ChooseAction();}

        }
    }
}