// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckHttpRequestHeaderArgs : global::Pulumi.ResourceArgs
    {
        [Input("userAgent")]
        public Input<string>? UserAgent { get; set; }

        public SyntheticsCreateBrowserCheckHttpRequestHeaderArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckHttpRequestHeaderArgs Empty => new SyntheticsCreateBrowserCheckHttpRequestHeaderArgs();
    }
}