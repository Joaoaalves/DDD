using Joaoaalves.DDD.Common;

namespace Joaoaalves.DDD.Tests.Fakes
{
    public class FakeTypedId(Guid value) : TypedIdValueBase(value)
    {
    }
}