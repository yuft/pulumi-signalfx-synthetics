// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Outputs
{

    [OutputType]
    public sealed class SyntheticsCreateHttpCheckV2Test
    {
        public readonly bool Active;
        public readonly string? Body;
        public readonly int Frequency;
        public readonly ImmutableArray<Outputs.SyntheticsCreateHttpCheckV2TestHeader> Headers;
        public readonly ImmutableArray<string> LocationIds;
        public readonly string Name;
        public readonly string RequestMethod;
        public readonly string? SchedulingStrategy;
        public readonly string? Type;
        public readonly string Url;

        [OutputConstructor]
        private SyntheticsCreateHttpCheckV2Test(
            bool active,

            string? body,

            int frequency,

            ImmutableArray<Outputs.SyntheticsCreateHttpCheckV2TestHeader> headers,

            ImmutableArray<string> locationIds,

            string name,

            string requestMethod,

            string? schedulingStrategy,

            string? type,

            string url)
        {
            Active = active;
            Body = body;
            Frequency = frequency;
            Headers = headers;
            LocationIds = locationIds;
            Name = name;
            RequestMethod = requestMethod;
            SchedulingStrategy = schedulingStrategy;
            Type = type;
            Url = url;
        }
    }
}
