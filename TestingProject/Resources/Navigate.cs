using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Navigate : BaseComponent
    {
        public void Nav(string url) //I guess I ~could~ put this in BaseComponent, but considering this is not as frequently used by different classes, it doesn't make sense to put there.
        {
            _driver.CurrentDriver().Navigate().GoToUrl(url);
        }
    }
}
