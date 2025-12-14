using System.Reflection;

namespace DocGen.Services
{
    internal class MemberRule : WhitelistRule
    {
        public MemberRule(MemberInfo memberInfo) : base(memberInfo.GetAssembly())
        {
            MemberInfo = memberInfo;
        }

        public MemberInfo MemberInfo { get; }

        public override bool IsMatch(MemberInfo memberInfo)
        {
            return memberInfo == MemberInfo;
        }
    }
}