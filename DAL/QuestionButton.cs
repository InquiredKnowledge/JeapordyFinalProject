using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JeopardyFinal.DAL;

namespace JeopardyFinal.DAL
{
    /// <summary>
    /// Quest button class
    /// </summary>
    class QuestionButton : Button
    {
        // Properties
        public bool Clicked { get; set; }
        public QuestionInfo questionInfo { get; set; }

        // Constructor
        public QuestionButton()
        {
            Clicked = false;
        }
    }
}
