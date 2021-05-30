using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy(); 
    }
}
