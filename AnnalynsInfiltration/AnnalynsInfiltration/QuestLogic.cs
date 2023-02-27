    static class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == false)
            {
                return true;
            }
            return false;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
            {
                return true;
            }
            return false;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            return false;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent == true)
            {
                if (archerIsAwake == false && knightIsAwake == true && prisonerIsAwake == true)
                {
                    return true;
                }

                if (archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == true)
                {
                    return true;
                }

                if (archerIsAwake == false && knightIsAwake == true && prisonerIsAwake == false)
                {
                    return true;
                }

                if (archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == false)
                {
                    return true;
                }
            }

            if (petDogIsPresent == false)
            {
                if (archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
