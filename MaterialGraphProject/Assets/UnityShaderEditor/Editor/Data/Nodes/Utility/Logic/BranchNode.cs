using System.Reflection;
using UnityEngine;
using UnityEditor.Graphing;
using UnityEditor.ShaderGraph.Drawing.Controls;

namespace UnityEditor.ShaderGraph
{
    [Title("Utility", "Logic", "Branch")]
    public class BranchNode : CodeFunctionNode
    {
        public BranchNode()
        {
            name = "Branch";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_Branch", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_Branch(
            [Slot(0, Binding.None)] Boolean Predicate,
            [Slot(1, Binding.None)] DynamicDimensionVector True,
            [Slot(2, Binding.None)] DynamicDimensionVector False,
            [Slot(3, Binding.None)] out DynamicDimensionVector Out)
        {
            return
                @"
{
    Out = Predicate == 1 ? True : False;
}
";
        }
    }
}