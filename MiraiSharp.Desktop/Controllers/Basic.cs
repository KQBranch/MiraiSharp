using System;

namespace MiraiSharp.Desktop.Controllers
{
    class Basic
    {
        public static Exception Try(Action a)
        {
            try
            {
                a.Invoke();
            }
            catch (Exception e)
            {
                return e;
            }
            return null;
        }
    }
}
