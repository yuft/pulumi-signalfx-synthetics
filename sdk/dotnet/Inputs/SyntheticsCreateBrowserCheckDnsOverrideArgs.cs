// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckDnsOverrideArgs : global::Pulumi.ResourceArgs
    {
        [Input("originalDomain")]
        public Input<string>? OriginalDomain { get; set; }

        [Input("originalHost")]
        public Input<string>? OriginalHost { get; set; }

        public SyntheticsCreateBrowserCheckDnsOverrideArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckDnsOverrideArgs Empty => new SyntheticsCreateBrowserCheckDnsOverrideArgs();
    }
}