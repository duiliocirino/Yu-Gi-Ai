namespace ConsoleApplication1.Actions
{
    public class DoNothing: Action
    {
        public override string GetName()
        {
            return ("No Action Performed \n");
        }

        public override void PerformAction()
        {
            
        }
    }
}