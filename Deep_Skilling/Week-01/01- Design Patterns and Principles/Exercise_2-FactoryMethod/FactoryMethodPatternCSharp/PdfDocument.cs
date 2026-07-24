// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: FactoryMethodPatternCSharp

namespace FactoryMethodPatternCSharp
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            System.Console.WriteLine("Opening PDF Document");
        }
    }
}
