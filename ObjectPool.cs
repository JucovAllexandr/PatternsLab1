using System.Collections.Generic;

namespace Lab1
{
    public static class ObjectPool<T> where T : new()
    {
        private static int maxSize = 15;
        private static Queue<T> pool = new Queue<T>();

        public static void init()
        {
            for (int i = 0; i < maxSize; ++i)
            {
                pool.Enqueue(new T());
            }
        }

        public static T GetInstance()
        {
            if (pool.Count > 0)
            {
                return pool.Dequeue();
            }

            return default(T);
        }

        public static void ReleaseInstance(T obj)
        {
            if(pool.Count < 15)
                pool.Enqueue(obj);
        }
        
    }
}