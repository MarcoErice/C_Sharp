using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opens2FilesLib
{
    public class TwoFilesProduct
    {
       public string Product(string amountFile, string qtyFile)
        {
            StringReader firstStrReader = new StringReader(amountFile);
            string amountLine, qtyLine, output = "";
            decimal product = 0M;

            while (true)
            {
                amountLine = firstStrReader.ReadLine();
                if (amountLine == null)
                    break;
                StringReader secondStrReader = new StringReader(qtyFile);
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

            return output;
        }
    }
}
