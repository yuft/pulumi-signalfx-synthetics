// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsApiV2CheckTestRequestValidationInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("actual")]
        public Input<string>? Actual { get; set; }

        [Input("comparator")]
        public Input<string>? Comparator { get; set; }

        [Input("expected")]
        public Input<string>? Expected { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public SyntheticsApiV2CheckTestRequestValidationInputArgs()
        {
        }
        public static new SyntheticsApiV2CheckTestRequestValidationInputArgs Empty => new SyntheticsApiV2CheckTestRequestValidationInputArgs();
    }
}