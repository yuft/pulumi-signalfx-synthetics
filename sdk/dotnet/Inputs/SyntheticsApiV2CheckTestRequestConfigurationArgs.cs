// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsApiV2CheckTestRequestConfigurationInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("body")]
        public Input<string>? Body { get; set; }

        [Input("headers")]
        private InputMap<string>? _headers;
        public InputMap<string> Headers
        {
            get => _headers ?? (_headers = new InputMap<string>());
            set => _headers = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requestMethod")]
        public Input<string>? RequestMethod { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public SyntheticsApiV2CheckTestRequestConfigurationInputArgs()
        {
        }
        public static new SyntheticsApiV2CheckTestRequestConfigurationInputArgs Empty => new SyntheticsApiV2CheckTestRequestConfigurationInputArgs();
    }
}