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
    public sealed class SyntheticsCreateApiCheckV2TestRequestConfiguration
    {
        public readonly string? Body;
        public readonly ImmutableDictionary<string, string>? Headers;
        public readonly string? Name;
        public readonly string? RequestMethod;
        public readonly string? Url;

        [OutputConstructor]
        private SyntheticsCreateApiCheckV2TestRequestConfiguration(
            string? body,

            ImmutableDictionary<string, string>? headers,

            string? name,

            string? requestMethod,

            string? url)
        {
            Body = body;
            Headers = headers;
            Name = name;
            RequestMethod = requestMethod;
            Url = url;
        }
    }
}
