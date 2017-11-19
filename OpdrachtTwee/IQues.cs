using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtTwee
{
    interface IQues
    {
        string Quest { get; set; }
        string Answ { get; set; }
        int Difficulty { get; set; }
        string Categ { get; set; }

        void ShowQues();
    }
}
