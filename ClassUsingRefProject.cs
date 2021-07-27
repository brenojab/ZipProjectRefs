using ProjUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjRef
{
    public class ClassUsingRefProject
    {

        public void DoSomethingWithRefProject()
        {
            ZipUtils.DoSomethingAsGzip();

            //ZipUtils.DoSomethingAsZip();
        }
    }
}