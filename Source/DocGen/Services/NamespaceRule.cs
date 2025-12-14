using System.Reflection;

namespace DocGen.Services
{
    internal class NamespaceRule : WhitelistRule
    {
        public NamespaceRule(string namespaceName, Assembly assembly) : base(assembly)
        {
            NamespaceName = namespaceName;
        }

        public string NamespaceName { get; }

        public override bool IsMatch(MemberInfo memberInfo)
        {
            return memberInfo.GetAssembly() == Assembly && memberInfo.GetNamespace() == NamespaceName;
        }
    }
}