namespace Lab1
{
    public abstract class OSBuilder
    {
        protected OS _os;

        protected OSBuilder()
        {
            _os = new OS 
            {
                Name = "", 
                Kernel = "", 
                PackageManager = "", 
                DesktopEnvironment = ""
            };
        }

        public OS GetOS()
        {
            return _os;

        }

        public abstract void BuildKernel();
        public abstract void BuildDesktopEnvironment();
        public abstract void BuildPackageManager();
        public abstract void BuildName();
    }
}