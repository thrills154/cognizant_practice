// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: FactoryMethodPatternCSharp

namespace FactoryMethodPatternCSharp
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            System.Console.WriteLine("Opening Word Document");
        }
    }
}
