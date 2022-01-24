using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs14_paskaita_Class
{
    internal class ContentChecker
    {
        public List<string> CheckList;

        public ContentChecker(List<string> checkList)
        {
            CheckList = checkList;
        }

        public List<string> ContentCheckerMethod()
        {
            int x = 0;
            var FileWriterService = new FileWriterService();
            FileWriterService.GetAllLines().ToList().ForEach(line => CheckList.Add(line));
            return CheckList;
        }

    }
}
