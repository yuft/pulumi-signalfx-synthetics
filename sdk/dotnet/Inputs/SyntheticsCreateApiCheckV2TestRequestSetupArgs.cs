// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateApiCheckV2TestRequestSetupArgs : global::Pulumi.ResourceArgs
    {
        [Input("extractor")]
        public Input<string>? Extractor { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("source")]
        public Input<string>? Source { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("variable")]
        public Input<string>? Variable { get; set; }

        public SyntheticsCreateApiCheckV2TestRequestSetupArgs()
        {
        }
        public static new SyntheticsCreateApiCheckV2TestRequestSetupArgs Empty => new SyntheticsCreateApiCheckV2TestRequestSetupArgs();
    }
}
