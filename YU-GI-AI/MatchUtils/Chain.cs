using System.Collections;
using ConsoleApplication1.Effects;

namespace ConsoleApplication1.MatchUtils
{
    public class Chain
    {
        private Stack _stackedEffects;

        public Chain(IEffect firstEffect)
        {
            _stackedEffects = new Stack();
            _stackedEffects.Push(firstEffect);
        }


        public void BuildChain(canr){
    
        }
    }
}