using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Foo
    {
        private Foo()
        {
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static async Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return await result.InitAsync();
        }   
    }
}
