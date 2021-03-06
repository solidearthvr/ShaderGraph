using System.Reflection;

namespace UnityEditor.ShaderGraph
{
    [Title("Math", "Basic", "Multiply")]
    public class MultiplyNode : CodeFunctionNode
    {
        public MultiplyNode()
        {
            name = "Multiply";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_Multiply", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_Multiply(
            [Slot(0, Binding.None)] DynamicDimensionVector A,
            [Slot(1, Binding.None)] DynamicDimensionVector B,
            [Slot(2, Binding.None)] out DynamicDimensionVector Out)
        {
            return
                @"
{
    Out = A * B;
}
";
        }
    }
}
