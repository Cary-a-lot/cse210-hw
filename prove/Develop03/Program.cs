using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Mosiah", 4, 9);
        Scripture scripture = new Scripture(reference,
            "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.");
    }
}