int energy1 = 0;
int energy2 = 19;
int energy3 = 20;
int energy4 = 49;
int energy5 = 50;
int energy6 = 79;
int energy7 = 80;
int energy8 = 130;
//string classification = "";

// TODO: Sett classification med if / else if / else.
//classification = energyComparer(energy1);

Console.WriteLine($"Energy: {energy1} - Classification: {energyComparer(energy1)}");
Console.WriteLine($"Energy: {energy2} - Classification: {energyComparer(energy2)}");
Console.WriteLine($"Energy: {energy3} - Classification: {energyComparer(energy3)}");
Console.WriteLine($"Energy: {energy4} - Classification: {energyComparer(energy4)}");
Console.WriteLine($"Energy: {energy5} - Classification: {energyComparer(energy5)}");
Console.WriteLine($"Energy: {energy6} - Classification: {energyComparer(energy6)}");
Console.WriteLine($"Energy: {energy7} - Classification: {energyComparer(energy7)}");
Console.WriteLine($"Energy: {energy8} - Classification: {energyComparer(energy8)}");


string energyComparer(int energy)
{
    if (energy < 20)
    {
        return "Dormant";
    }
    else if (energy >= 20 && energy <= 49)
    {
        return "Stable";
    }
    else if (energy >= 50 && energy <= 79)
    {
        return "Unstable";
    }
    else
    {
        return "Critical";
    }
}