// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckBrowserArgs : global::Pulumi.ResourceArgs
    {
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SyntheticsCreateBrowserCheckBrowserArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckBrowserArgs Empty => new SyntheticsCreateBrowserCheckBrowserArgs();
    }
}
