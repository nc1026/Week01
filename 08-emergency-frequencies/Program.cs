string crimsonSignal = "CRIMSON";
string redSignal = "RED";
string scarletSignal = "SCARLET";
string amberSignal = "AMBER";
string yellowSignal = "YELLOW";
string greenSignal = "GREEN";
string otherSignal = "OTHER";


Console.WriteLine($"Signal: {crimsonSignal} | Instruction: {switchComparer(crimsonSignal)}");
Console.WriteLine($"Signal: {redSignal} | Instruction: {switchComparer(redSignal)}");
Console.WriteLine($"Signal: {scarletSignal} | Instruction: {switchComparer(scarletSignal)}");
Console.WriteLine($"Signal: {amberSignal} | Instruction: {switchComparer(amberSignal)}");
Console.WriteLine($"Signal: {yellowSignal} | Instruction: {switchComparer(yellowSignal)}");
Console.WriteLine($"Signal: {greenSignal} | Instruction: {switchComparer(greenSignal)}");
Console.WriteLine($"Signal: {otherSignal} | Instruction: {switchComparer(otherSignal)}");


string switchComparer(string input)
{
    string instruction = "";

    switch (input)
    {
        case "CRIMSON":
        case "RED":
        case "SCARLET":
            instruction = "Evacuate deck";
            break;
        
        case "AMBER":
        case "YELLOW":
            instruction = "Prepare crew";
            break;

        case "GREEN":
            instruction = "No emergency";
            break;

        default:
            instruction = "Unknown signal";
            break;
    }

    return instruction;
}

