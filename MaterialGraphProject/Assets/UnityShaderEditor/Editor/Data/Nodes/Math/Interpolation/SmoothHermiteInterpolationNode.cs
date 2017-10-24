using System.Reflection;

namespace UnityEngine.MaterialGraph
{
    [Title("Math/Interpolation/Smooth Hermite Interpolation")]
    class SmoothHermiteInterpolationNode : CodeFunctionNode
    {
        public SmoothHermiteInterpolationNode()
        {
            name = "Smooth Hermite Interpolation";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_SmoothHermiteInterpolation", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_SmoothHermiteInterpolation(
            [Slot(0, Binding.None)] DynamicDimensionVector A,
            [Slot(1, Binding.None)] DynamicDimensionVector B,
            [Slot(2, Binding.None)] DynamicDimensionVector T,
            [Slot(3, Binding.None)] out DynamicDimensionVector Out)
        {
            return
                @"
{
    Out = smoothstep(A, B, T);
}";
        }
    }
}