using Joaoaalves.DDD.Rules;

namespace Joaoaalves.DDD.Tests.Fakes
{
    public class FakeBusinessRules : IBusinessRule
    {
        public bool IsBroken() => false;
        public string Message => "Should not be thrown";
    }

    public class FakeBrokenRule : IBusinessRule
    {
        public bool IsBroken() => true;
        public string Message => "Rule was broken";
    }
}