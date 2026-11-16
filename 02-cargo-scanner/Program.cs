int cargoWeight = 800;
int maxWeight = 800;
int containerCount = 4;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = cargoWeight > maxWeight;
bool isExactlyAtLimit = cargoWeight == maxWeight;
bool hasContainers = containerCount > 0;
bool countDiffersFromExpected = containerCount != expectedContainers;

Console.WriteLine("--- SCENARIO 1 ---");
Console.WriteLine($"Cargo weight: {cargoWeight}");
Console.WriteLine($"Max weight: {maxWeight}");
Console.WriteLine($"Container count: {containerCount}");
Console.WriteLine($"Expected containers: {expectedContainers}");
Console.WriteLine();
Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");

cargoWeight = 801;
containerCount = 0;

isOverweight = cargoWeight > maxWeight;
isExactlyAtLimit = cargoWeight == maxWeight;
hasContainers = containerCount > 0;
countDiffersFromExpected = containerCount != expectedContainers;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--- SCENARIO 2 ---");
Console.WriteLine($"Cargo weight: {cargoWeight}");
Console.WriteLine($"Max weight: {maxWeight}");
Console.WriteLine($"Container count: {containerCount}");
Console.WriteLine($"Expected containers: {expectedContainers}");
Console.WriteLine();
Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
