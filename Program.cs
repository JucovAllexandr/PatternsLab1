using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            OSFactoryBuilder serverFactory = new ServerFactory(new GentooBuilder());
            ObjectPool<OS>.init();
            var gentoo = serverFactory.Construct();
            gentoo.Print();
            OS os2 = ObjectPool<OS>.GetInstance();
            os2 =(OS)gentoo.Clone();
            os2.Print();
            DesktopFactory desktopFactory = new DesktopFactory(new GentooBuilder());
            var dgentoo = desktopFactory.Construct();
            dgentoo.Print();
        }
    }
}