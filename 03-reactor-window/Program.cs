int lowerLimit = 40;
int upperLimit = 70;
int energy1 = 39;
int energy2 = 40;
int energy3 = 55;
int energy4 = 70;
int energy5 = 71;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable1 = energy1 >= lowerLimit && energy1 <= upperLimit;
bool isStable2 = energy2 >= lowerLimit && energy2 <= upperLimit;
bool isStable3 = energy3 >= lowerLimit && energy3 <= upperLimit;
bool isStable4 = energy4 >= lowerLimit && energy4 <= upperLimit;
bool isStable5 = energy5 >= lowerLimit && energy5 <= upperLimit;

Console.WriteLine($"Energy = {energy1}: Reactor stable: {isStable1}");
Console.WriteLine($"Energy = {energy2}: Reactor stable: {isStable2}");
Console.WriteLine($"Energy = {energy3}: Reactor stable: {isStable3}");
Console.WriteLine($"Energy = {energy4}: Reactor stable: {isStable4}");
Console.WriteLine($"Energy = {energy5}: Reactor stable: {isStable5}");
