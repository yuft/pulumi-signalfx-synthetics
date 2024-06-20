// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckV2TestArgs : global::Pulumi.ResourceArgs
    {
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("advancedSettings")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingArgs>? _advancedSettings;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingArgs> AdvancedSettings
        {
            get => _advancedSettings ?? (_advancedSettings = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingArgs>());
            set => _advancedSettings = value;
        }

        [Input("deviceId")]
        public Input<int>? DeviceId { get; set; }

        [Input("frequency")]
        public Input<int>? Frequency { get; set; }

        [Input("locationIds")]
        private InputList<string>? _locationIds;
        public InputList<string> LocationIds
        {
            get => _locationIds ?? (_locationIds = new InputList<string>());
            set => _locationIds = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("schedulingStrategy")]
        public Input<string>? SchedulingStrategy { get; set; }

        [Input("startUrl", required: true)]
        public Input<string> StartUrl { get; set; } = null!;

        [Input("transactions", required: true)]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionArgs>? _transactions;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionArgs> Transactions
        {
            get => _transactions ?? (_transactions = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionArgs>());
            set => _transactions = value;
        }

        [Input("urlProtocol", required: true)]
        public Input<string> UrlProtocol { get; set; } = null!;

        public SyntheticsCreateBrowserCheckV2TestArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2TestArgs Empty => new SyntheticsCreateBrowserCheckV2TestArgs();
    }
}