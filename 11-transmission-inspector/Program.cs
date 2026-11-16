string transmission1 = "AB#CD##EF";
string transmission2 = "CLEAR";
string transmission3 = "###";

Console.WriteLine($"Transmission: {transmission1} | Interference markers: {foreachComparer(transmission1)}");
Console.WriteLine($"Transmission: {transmission2} | Interference markers: {foreachComparer(transmission2)}");
Console.WriteLine($"Transmission: {transmission3} | Interference markers: {foreachComparer(transmission3)}");

int foreachComparer(string input)
{
    int interferenceCount = 0;

    foreach (char tegn in input)
    {
        if (tegn == '#')
        {
            interferenceCount ++;
        }
    }
    return interferenceCount;
}