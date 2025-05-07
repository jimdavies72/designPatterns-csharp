namespace CreationalDesignPatterns.src.DesignPatterns.Creational.Builder.BadExample.Components
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