using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuchensExamine
{
    public class StudentsGradeData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int TotalScore { get; set; }
        public int Average { get; set; }
        public string MaxStr { get; set; }
        public string MinStr { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

    }
}
