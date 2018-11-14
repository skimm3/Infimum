using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infimum.Model
{
    class Card
    {
       public Player Owner;
       public string Description;

       public Action OnPlay;

    }
}
