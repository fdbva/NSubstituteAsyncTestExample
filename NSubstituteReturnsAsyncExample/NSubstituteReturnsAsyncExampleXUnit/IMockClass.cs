using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSubstituteReturnsAsyncExampleXUnit
{
    public interface IMockClass
    {
        Task<IEnumerable<int>> MockMethodAsync();
    }
}