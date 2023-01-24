using ConsoleApplication1.Effects;

namespace ConsoleApplication1.Actions
{
    public class ActivateEffect: Action
    {
        private IEffect _effect;

        public IEffect Effect => _effect;

        //TODO: vedere posizionamento spellSpeed
        public ActivateEffect(IEffect effect, int spellSpeed)
        {
            _effect = effect;
            _spellSpeed = spellSpeed;
        }
        
        public override string GetName()
        {
            return "Activated an effect\n";
        }

        public override void PerformAction()
        {
            _effect.Activate();
            if(Match.CurrentChain == null) Match.StartChain(_effect);
        }
    }
}