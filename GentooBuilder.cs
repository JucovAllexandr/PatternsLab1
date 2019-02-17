namespace Lab1
{
    public class GentooBuilder:OSBuilder
    {
        public GentooBuilder():base()
        {
        }

        public override void BuildKernel()
        {
            _os.Kernel = "4.15.0-45-generic";
        }

        public override void BuildDesktopEnvironment()
        {
            _os.DesktopEnvironment = "KDE";
        }

        public override void BuildPackageManager()
        {
            _os.PackageManager = "packman";
        }

        public override void BuildName()
        {
            _os.Name = "Gentoo";
        }
    }
}