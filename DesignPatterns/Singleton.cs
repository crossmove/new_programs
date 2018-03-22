using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton instance { get; set; }

        public static Singleton Instance
        {
            get
            {
                if(instance ==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

    }
}
