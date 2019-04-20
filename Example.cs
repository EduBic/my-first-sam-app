using System.Runtime.InteropServices;

using TrimChillersModel.MachineComponents;
using TrimChillersModel.MachineSimulation.MachineComponentsSimulators;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace MyFirstSamApp
{
    public class Example
    {
        public string Handler(string input, ILambdaContext context)
        {
            return input.ToUpper();
        }
    }
}