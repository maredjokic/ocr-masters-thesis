using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CryptographyAndImageProcessing
{
        public class StringLikeNumberComperer : IComparer<string>
        {
            public int Compare(string x, string y)
            {

                x= Regex.Match(x, @"\d+").Value;
                y=Regex.Match(y, @"\d+").Value;

                return int.Parse(x).CompareTo(int.Parse(y));
            }
        }
    
}
