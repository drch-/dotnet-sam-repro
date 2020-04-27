using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.LambdaJsonSerializer))]

namespace func
{
    public class Function
    {
        public string UpperHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }

        public string LowerHandler(string input, ILambdaContext context)
        {
            return input?.ToLower();
        }
    }
}
