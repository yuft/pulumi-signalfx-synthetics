// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCheckCookieInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public SyntheticsCheckCookieInputArgs()
        {
        }
        public static new SyntheticsCheckCookieInputArgs Empty => new SyntheticsCheckCookieInputArgs();
    }
}
