// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckNotificationNotifyWhoLinkArgs : global::Pulumi.ResourceArgs
    {
        [Input("selfHtml")]
        public Input<string>? SelfHtml { get; set; }

        public SyntheticsCreateBrowserCheckNotificationNotifyWhoLinkArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckNotificationNotifyWhoLinkArgs Empty => new SyntheticsCreateBrowserCheckNotificationNotifyWhoLinkArgs();
    }
}