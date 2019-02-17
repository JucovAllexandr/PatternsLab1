namespace Lab1
{
    public class UbuntuBuilder: OSBuilder
    {
        
        public UbuntuBuilder():base()
        {
            
        }
        public override void BuildKernel()
        {
            _os.Kernel = "4.15.0-45-generic";
        }

        public override void BuildDesktopEnvironment()
        {
            _os.DesktopEnvironment = "unity";
        }

        public override void BuildPackageManager()
        {
            _os.PackageManager = "apt";
        }

        public override void BuildName()
        {
            _os.Name = "Ubuntu";
        }

    }
}