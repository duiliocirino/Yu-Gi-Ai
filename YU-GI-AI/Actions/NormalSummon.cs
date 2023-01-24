namespace ConsoleApplication1.Actions
{
    public class NormalSummon: Action
    {
        internal readonly Player Player;
        internal readonly Card Monster;
        internal readonly int Position;

        public NormalSummon(Player player, Card monster, int position)
        {
            _spellSpeed = 0;
            Player = player;
            Monster = monster;
            Position = position;
        }
        
        public override string GetName()
        {
            return Monster.Name + " was normal summoned";
        }

        public override void PerformAction()
        {
            Match.NormalSummon(this);
        }
    }
}