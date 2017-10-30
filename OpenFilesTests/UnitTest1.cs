using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace OpenFilesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanRead()
        {
            // Arrange

            string firstInput = "12.50\n17.50";
            string secondInput = "2\n10";
            StringReader firstStrReader = new StringReader(firstInput);

            string amountLine, qtyLine, output = "";
            decimal product = 0M;

            // Act
            while (true)
            {
                amountLine = firstStrReader.ReadLine();
                if (amountLine == null)
                    break;
                StringReader secondStrReader = new StringReader(secondInput);
                while (true)
                {

                    qtyLine = secondStrReader.ReadLine();
                    if (qtyLine == null)
                        break;
                    var amount = decimal.Parse(amountLine, CultureInfo.InvariantCulture);
                    var amountString = amount.ToString(CultureInfo.InvariantCulture);
                    
                    product = amount * decimal.Parse(qtyLine);
                    var productString = product.ToString(CultureInfo.InvariantCulture);
                    output += $"{amountString}x{decimal.Parse(qtyLine)}={productString}\n";
                }
            }

            
            // Assert
            Assert.AreEqual("12.50x2=25.00\n12.50x10=125.00\n17.50x2=35.00\n17.50x10=175.00\n", output);
        }
    }
}
