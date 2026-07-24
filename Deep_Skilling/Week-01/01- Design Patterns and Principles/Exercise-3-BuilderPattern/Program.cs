// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: Exercise-3-BuilderPattern

using BuilderPattern;
var highEndBuild = new Computer.Builder()
    .SetCPU("AMD Ryzen 9 7950X")
    .SetRAM("64GB DDR5")
    .SetStorage("2TB NVMe SSD")
    .SetGPU("RTX 4080 Super")
    .SetOS("Windows 11 Pro")
    .Build();
var standardBuild = new Computer.Builder()
    .SetCPU("AMD Ryzen 5 7600")
    .SetRAM("32GB DDR5")
    .SetStorage("1TB NVMe SSD")
    .SetOS("Windows 11 Pro")
    .Build();
Console.WriteLine("Gaming Setup: " + highEndBuild);
Console.WriteLine("Work Station: " + standardBuild);
