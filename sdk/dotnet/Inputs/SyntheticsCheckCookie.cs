// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCheckCookieArgs : global::Pulumi.InvokeArgs
    {
        [Input("domain")]
        public string? Domain { get; set; }

        [Input("key")]
        public string? Key { get; set; }

        [Input("path")]
        public string? Path { get; set; }

        [Input("value")]
        public string? Value { get; set; }

        public SyntheticsCheckCookieArgs()
        {
        }
        public static new SyntheticsCheckCookieArgs Empty => new SyntheticsCheckCookieArgs();
    }
}
