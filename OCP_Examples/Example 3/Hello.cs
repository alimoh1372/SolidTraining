using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
   public class Hello
    {
        IHello _hello;
        public Hello(IHello hello)
        {
            _hello = hello;
        }

        public virtual string Say()
        {
           return _hello.Say();
        }

        //class Hello
        //{
        //    public say(lang)
        //    {
        //        if (lang == 'pr')
        //        {
        //            return 'درود';
        //        }
        //        else if (lang == 'en')
        //        {
        //            return 'Hi';
        //        }
        //        else if (lang == 'fr')
        //        {
        //            return 'Bonjour';
        //        }
        //        else if (lang == 'de')
        //        {
        //            return 'Hallo';
        //        }
        //    }
        //}

        //let obj = new Hello;
        //console.log(obj.say('de'));
    }
}
