// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckStepGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("how")]
        public Input<string>? How { get; set; }

        [Input("itemMethod")]
        public Input<string>? ItemMethod { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("position")]
        public Input<int>? Position { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("variableName")]
        public Input<string>? VariableName { get; set; }

        [Input("what")]
        public Input<string>? What { get; set; }

        public SyntheticsCreateBrowserCheckStepGetArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckStepGetArgs Empty => new SyntheticsCreateBrowserCheckStepGetArgs();
    }
}
