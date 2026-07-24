// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: FactoryMethodPatternCSharp

namespace FactoryMethodPatternCSharp
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            System.Console.WriteLine("Opening Excel Document");
        }
    }
}
