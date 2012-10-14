using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BayesianProbabiltyDetector
{
    public class BInterface
    {
        private SpamFilter _filter;

        public double TestFile(string file)
        {
            if (_filter == null)
            {
                loadInitialSetting();
            }

            string body = new StreamReader(file).ReadToEnd();

            double resultVal = _filter.Test(body);
            return resultVal;
        }

        public double TestString(string textBody)
        {
            if (_filter == null)
            {
                loadInitialSetting();
            }

            double resDouble = _filter.Test(textBody);
            return resDouble;
        }

        private void loadInitialSetting()
        {
            Corpus bad = new Corpus();
            Corpus good = new Corpus();
            bad.LoadFromFile("../../../Input_Data/Not_Watch.txt");
            good.LoadFromFile("../../../Input_Data/Watch.txt");

            _filter = new SpamFilter();
            _filter.Load(good, bad);
        }
    }
}
