using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
namespace integral
{
    public class String_to_function
    {
        public delegate double Del(double x);
        private static string begin = @"using System;
namespace MyNamespace
{
    public delegate double Del(double x);
    public static class LambdaCreator 
    {
        public static Del Create()
        {
            return (x)=>";
        private static string end = @";
        }
    }
}";

        public static Func<double, double> Matfun(string s)
        {

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            parameters.ReferencedAssemblies.Add("System.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, begin + s + end);
            var cls = results.CompiledAssembly.GetType("MyNamespace.LambdaCreator");
            var method = cls.GetMethod("Create", BindingFlags.Static | BindingFlags.Public);
            var del = (method.Invoke(null, null) as Delegate);
            return x => double.Parse(del.DynamicInvoke(x).ToString());
            
        }
    }
}
