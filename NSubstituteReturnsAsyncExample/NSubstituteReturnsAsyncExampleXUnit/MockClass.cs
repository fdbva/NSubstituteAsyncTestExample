using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSubstituteReturnsAsyncExampleXUnit
{
    public class MockClass : IMockClass
    {
        public async Task<IEnumerable<int>> MockMethodAsync()
        {
            await Task.Delay(1);
            return new List<int> { 0 };
        }
    }
}