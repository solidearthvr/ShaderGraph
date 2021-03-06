using System.Reflection;

namespace UnityEditor.ShaderGraph
{
    [Title("Math", "Trigonometry", "Arccosine")]
    public class ArccosineNode : CodeFunctionNode
    {
        public ArccosineNode()
        {
            name = "Arccosine";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_Arccosine", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_Arccosine(
            [Slot(0, Binding.None)] DynamicDimensionVector In,
            [Slot(1, Binding.None)] out DynamicDimensionVector Out)
        {
            return
                @"
{
    Out = acos(In);
}
";
        }
    }
}
