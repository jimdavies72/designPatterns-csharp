namespace CreationalDesignPatterns.src.Builder.GoodExample.Components
{
    public class Dashboard
    {
        private bool _hasRevCounter = false;

        public Dashboard(bool hasRevCounter)
        {
            _hasRevCounter = hasRevCounter;
        }
    }
}