// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsHttpV2CheckTestHeaderArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("value")]
        public string? Value { get; set; }

        public SyntheticsHttpV2CheckTestHeaderArgs()
        {
        }
        public static new SyntheticsHttpV2CheckTestHeaderArgs Empty => new SyntheticsHttpV2CheckTestHeaderArgs();
    }
}
