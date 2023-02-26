namespace LuciansLusciousLasagna
{
    class Lasagna
    {
        // TODO: define the 'ExpectedMinutesInOven()' method
        public int ExpectedMinutesInOven()
        {
            return 40;
        }
        // TODO: define the 'RemainingMinutesInOven()' method
        public int RemainingMinutesInOven(int MinutesBeenInOven)
        {
            return (40 - MinutesBeenInOven);
        }

        // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes(int NumberOfLayers)
        {
            return (NumberOfLayers * 2);
        }

        // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes(int NumberOfLayers, int MinutesBeenInOven)
        {
            int TimeTakenToPrepareLayers = NumberOfLayers * 2;
            return (TimeTakenToPrepareLayers + MinutesBeenInOven);
        }
    }
}
