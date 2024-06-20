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
    public sealed class SyntheticsCreatePortCheckV2Test
    {
        public readonly bool Active;
        public readonly int Frequency;
        public readonly string Host;
        public readonly ImmutableArray<string> LocationIds;
        public readonly string Name;
        public readonly int Port;
        public readonly string Protocol;
        public readonly string? SchedulingStrategy;
        public readonly string? Type;
        public readonly string? Url;

        [OutputConstructor]
        private SyntheticsCreatePortCheckV2Test(
            bool active,

            int frequency,

            string host,

            ImmutableArray<string> locationIds,

            string name,

            int port,

            string protocol,

            string? schedulingStrategy,

            string? type,

            string? url)
        {
            Active = active;
            Frequency = frequency;
            Host = host;
            LocationIds = locationIds;
            Name = name;
            Port = port;
            Protocol = protocol;
            SchedulingStrategy = schedulingStrategy;
            Type = type;
            Url = url;
        }
    }
}