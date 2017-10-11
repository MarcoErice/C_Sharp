using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using AccountLib;

namespace SIEImportTests
{
    [TestClass]
    public class SIEImportTester
    {
        [TestMethod]
        public void CanRead()
        {
            var accounts = new Dictionary<string, decimal>();
            var streamReader = File.OpenText(@"bokforing.txt");
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                string pattern = @"#TRANS (\d{4}) {} (-?\d*.\d*)";
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var accountId = match.Groups[1].Value;
                    var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                    if (accounts.ContainsKey(accountId))
                    {
                        accounts[accountId] += amount;
                    }
                    else
                        accounts[accountId] = amount;
                }

            }
            foreach (var entry in accounts.OrderBy(e => e.Key))
            {
                Debug.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");
            }
            Debug.WriteLine(accounts.Sum(entry => entry.Value));
        }

        [TestMethod]
        public void TwoPhases()
        {
            var accounts = new Dictionary<string, decimal>();
            var streamReader = File.OpenText(@"bokforing.txt");
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                string pattern = @"#TRANS (\d{4}) {} (-?\d*.\d*)";
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var accountId = match.Groups[1].Value;
                    var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                    if (accounts.ContainsKey(accountId))
                    {
                        accounts[accountId] += amount;
                    }
                    else
                        accounts[accountId] = amount;
                }

            }
            foreach (var entry in accounts.OrderBy(e => e.Key))
            {
                Debug.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");
            }
            Debug.WriteLine(accounts.Sum(entry => entry.Value));
        }
        [TestMethod]
        public void RegexMatchCounter()
        {
            var content = File.ReadAllText(@"bokforing.txt");
            string pattern = @"#VER";
            var sut = new RegexMatchCounter();
            var lineCount = sut.CountMatchingLines(content, pattern);
            Assert.AreEqual(66, lineCount);
        }
    }
}
