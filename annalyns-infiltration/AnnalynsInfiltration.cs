using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {        
       return knightIsAwake != true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true ? true : false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake ? true : false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return !knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent || !knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent || !knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent || knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent || knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent ? true : false;
    }
}
