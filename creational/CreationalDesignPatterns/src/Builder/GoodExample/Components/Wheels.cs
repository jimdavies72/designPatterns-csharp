namespace CreationalDesignPatterns.src.Builder.GoodExample.Components
{
    public class Wheels
    {
        private float _diameterInInches;

        public Wheels(float diameterInInches)
        {
            _diameterInInches = diameterInInches;
        }

        public float GetDiameterInInches()
        {
            return _diameterInInches;
        }
    }
}