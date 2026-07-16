class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public  int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int ActualMins) => ExpectedMinutesInOven() - ActualMins;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int Layers) => Layers*2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minsInOven) => PreparationTimeInMinutes(layers) + minsInOven;
}