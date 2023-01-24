namespace ConsoleApplication1.Actions
{
    public class Battle: Action
    {
        private Card _attacker;
        private Card _attacked;

        public Battle(Card attacker, Card attacked)
        {
            _spellSpeed = 0;
            _attacked = attacked;
            _attacker = attacker;
        }
        
        public override string GetName()
        {
            return " declared an attack";
        }

        public override void PerformAction()
        {
            Match.StartBattle(this);
        }
    }
}