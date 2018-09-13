using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSubstituteReturnsAsyncExample
{
    public partial class NSubstituteAsyncTests
    {
        public class MockClass
        {
            public virtual async Task<IEnumerable<int>> MockMethodAsync()
            {
                await Task.Delay(1);
                return new List<int> { 0 };
            }
        }
    }
}