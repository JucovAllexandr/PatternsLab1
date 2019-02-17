using System;

namespace Lab1
{
    public class OS: IClonable
    {
        public string Kernel { get; set; }
        public string DesktopEnvironment { get; set; }
        public string PackageManager { get; set; }
        public string Name { get; set; }
        
        public void Print()
        {
            if(Name.Length>0)
            Console.WriteLine("OS name: {0}",Name);
            if(Kernel.Length>0)
            Console.WriteLine("\tKernel: {0}",Kernel);
            if(DesktopEnvironment.Length>0)
            Console.WriteLine("\tDesktop environment: {0}",DesktopEnvironment);
            if(PackageManager.Length>0)
            Console.WriteLine("\tPackage manager: {0}",PackageManager);
            
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}