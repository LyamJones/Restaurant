using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Mens
    {
        bool isManager;

        public Mens ()
        {
           
        }

        public bool GetIsManager()
        {
            return this.isManager;
        }

        public void SetIsManager(bool isManager)
        {
            this.isManager = isManager;
        }
    }
}
