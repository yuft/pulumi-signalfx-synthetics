// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("keepHostHeader")]
        public Input<bool>? KeepHostHeader { get; set; }

        [Input("source")]
        public Input<string>? Source { get; set; }

        [Input("target")]
        public Input<string>? Target { get; set; }

        public SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs Empty => new SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs();
    }
}
