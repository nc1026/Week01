int charge = 23;
int drainPerCycle = 5;

while (charge > 0)
{
    Console.WriteLine("Charge = " + charge);
    charge -= drainPerCycle;
}

Console.WriteLine("Power cell offline.");
