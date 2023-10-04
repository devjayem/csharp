class Lasagna
{
    private int _expectedMinutesInOven = 40;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => _expectedMinutesInOven;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int min) => ExpectedMinutesInOven() - min;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer) => layer * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int _minutesInOven) => PreparationTimeInMinutes(layer) + _minutesInOven;
}
