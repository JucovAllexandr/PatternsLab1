namespace Lab1
{
    public class ServerFactory:OSFactoryBuilder
    {
        
        public ServerFactory(OSBuilder builder) : base(builder)
        {
            
        }

        public override OS Construct()
        {
            osBuilder.BuildName();
            osBuilder.BuildKernel();
            osBuilder.BuildPackageManager();
            return osBuilder.GetOS();
        }
    }
}