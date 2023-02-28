using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    internal class MoodNotFoundException:Exception
    {
        public MoodNotFoundException():base() {

        }
        public override string Message
        {
            get { return "Mood Not Found in Input String"; }
        }
    }
}
