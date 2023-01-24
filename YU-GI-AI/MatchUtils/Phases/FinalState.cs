using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication1.MatchUtils.Phases
{
    public class FinalState: IPhase
    {
        public FinalState(Player player, string reason, bool draw)
        {
            Console.WriteLine(reason);
        }
    }
}