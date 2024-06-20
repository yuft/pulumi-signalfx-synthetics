// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateHttpCheckNotificationNotifyWhoGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("call")]
        public Input<bool>? Call { get; set; }

        [Input("customUserEmail")]
        public Input<string>? CustomUserEmail { get; set; }

        [Input("email")]
        public Input<bool>? Email { get; set; }

        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id")]
        public Input<int>? Id { get; set; }

        [Input("links")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoLinkGetArgs>? _links;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoLinkGetArgs> Links
        {
            get => _links ?? (_links = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoLinkGetArgs>());
            set => _links = value;
        }

        [Input("sms")]
        public Input<bool>? Sms { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public SyntheticsCreateHttpCheckNotificationNotifyWhoGetArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckNotificationNotifyWhoGetArgs Empty => new SyntheticsCreateHttpCheckNotificationNotifyWhoGetArgs();
    }
}