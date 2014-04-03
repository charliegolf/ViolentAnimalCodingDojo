using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalQuiz
{
    public class Guess : Interaction
    {
        public int Number { get; set; }
        public string Message { get; set; }
        public Interaction Yes { get; set; }
        public Interaction No { get; set; }

        public Interaction ProcessResponse(bool repsonse)
        {
            // Some Stuff
            return null;
        }
    }
}
