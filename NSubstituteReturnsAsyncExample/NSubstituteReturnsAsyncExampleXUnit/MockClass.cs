using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstituteReturnsAsyncExampleXUnit
{
    public class MockClass
    {
        public async Task<IEnumerable<int>> MockMethodAsync()
        {
            await Task.Delay(1);
            return new List<int> { 0 };
        }
    }
}
