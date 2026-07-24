// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: FactoryMethodPatternCSharp

namespace FactoryMethodPatternCSharp
{
    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
