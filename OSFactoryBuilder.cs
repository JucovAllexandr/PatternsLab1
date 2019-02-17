using System.Collections.Immutable;

namespace Lab1
{
    public abstract class OSFactoryBuilder
    {
        protected readonly OSBuilder osBuilder;

        public OSFactoryBuilder(OSBuilder builder)
        {
            osBuilder = builder;
        }
        public abstract OS Construct();
    }
}