using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyFinal
{
    /// <summary>
    /// QuestionInfo Class
    /// </summary>
    class QuestionInfo
    {
        // Properties
        public string CategoryTitle { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Value { get; set; }

        // Constructor
        public QuestionInfo (string name)
        {
            CategoryTitle = name;
        }
    }
}
