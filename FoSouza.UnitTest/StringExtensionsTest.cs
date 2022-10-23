using FoSouza.String.Extensions;

namespace FoSouza.UnitTest
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("0000313213213-3 0000313213213-4 0000313213213-5 0000313213213-2")]
        [InlineData("243243.234234 243243.234234 243243.234234 243243.234234")]
        public void ClearBarcode_ValidInput_ReturnCleanBarcode(string barcode)
        {
            string? cleanBarcode = barcode.ClearBarcode();

            Assert.DoesNotContain(".", cleanBarcode);
            Assert.DoesNotContain("-", cleanBarcode);
            Assert.DoesNotContain(" ", cleanBarcode);
        }
    }
}