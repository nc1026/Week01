string serviceDockingCode = "SERVICE";
string northDockingCode = "NORTH";
string eastDockingCode = "EAST";
string closedDockingCode = "CLOSED";
string unknownDockingCode = "UNKNOWN";


Console.WriteLine($"Dockingcode: {serviceDockingCode} | Instruction: {switchComparer(serviceDockingCode)}");
Console.WriteLine($"Dockingcode: {northDockingCode} | Instruction: {switchComparer(northDockingCode)}");
Console.WriteLine($"Dockingcode: {eastDockingCode} | Instruction: {switchComparer(eastDockingCode)}");
Console.WriteLine($"Dockingcode: {closedDockingCode} | Instruction: {switchComparer(closedDockingCode)}");
Console.WriteLine($"Dockingcode: {unknownDockingCode} | Instruction: {switchComparer(unknownDockingCode)}");


string switchComparer(string input)
{
    string instruction = "";
    switch(input)
    {
        case "NORTH":
            instruction = "Dock at gate 1";
            break;
        
        case "EAST":
            instruction = "Dock at gate 2";
            break;

        case "SERVICE":
            instruction = "Dock at maintenance bay";
            break;
        
        case "CLOSED":
            instruction = "Hold position";
            break;

        default:
            instruction = "Unknown docking code";
            break;
    }
    return instruction;
}