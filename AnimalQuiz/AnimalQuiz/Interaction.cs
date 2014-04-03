using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalQuiz
{
    public interface Interaction
    {
        int Number { get; set; }
        string Message { get; set; }
        Interaction Yes { get; set; }
        Interaction No { get; set;}
        Interaction ProcessResponse(bool repsonse);

    }
}
