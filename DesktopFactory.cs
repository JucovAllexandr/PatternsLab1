namespace Lab1
{
    public class DesktopFactory:OSFactoryBuilder
    {
        public DesktopFactory(OSBuilder builder) : base(builder)
        {
        }

        public override OS Construct()
        {
            osBuilder.BuildName();
            osBuilder.BuildKernel();
            osBuilder.BuildPackageManager();
            osBuilder.BuildDesktopEnvironment();
            return osBuilder.GetOS();
        }
    }
}