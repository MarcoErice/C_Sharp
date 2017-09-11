using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class FileConverter
    {
        public string Transform(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lastName = tokens[1].ToUpper();
            var years = DateTime.Now.Year - int.Parse(tokens[2]);
            var message = $"{firstName} {lastName} ÄR {years} ÅR GAMMAL.";
            return message;
        }

        public void TransformeFile(string inputName, string outputName)
        {
            //StringWriter sw = new StringWriter();
            //string[] lines = FileConverter.ReadAllLines(inputName);
            //foreach (var line in lines)
            //{
            //    sw.WriteLine(Transform(line));
            //}
            //sw.Close();
            //File.WriteAllText(outputName, sw.toString());

        }
    }
}
