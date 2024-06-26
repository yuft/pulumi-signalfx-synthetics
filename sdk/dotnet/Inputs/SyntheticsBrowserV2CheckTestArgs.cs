// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsBrowserV2CheckTestInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("advancedSettings", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs>? _advancedSettings;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs> AdvancedSettings
        {
            get => _advancedSettings ?? (_advancedSettings = new InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs>());
            set => _advancedSettings = value;
        }

        [Input("businessTransactions", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionInputArgs>? _businessTransactions;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionInputArgs> BusinessTransactions
        {
            get => _businessTransactions ?? (_businessTransactions = new InputList<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionInputArgs>());
            set => _businessTransactions = value;
        }

        [Input("createdAt", required: true)]
        public Input<string> CreatedAt { get; set; } = null!;

        [Input("devices", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestDeviceInputArgs>? _devices;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestDeviceInputArgs> Devices
        {
            get => _devices ?? (_devices = new InputList<Inputs.SyntheticsBrowserV2CheckTestDeviceInputArgs>());
            set => _devices = value;
        }

        [Input("frequency", required: true)]
        public Input<int> Frequency { get; set; } = null!;

        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id", required: true)]
        public Input<int> Id { get; set; } = null!;

        [Input("locationIds", required: true)]
        private InputList<string>? _locationIds;
        public InputList<string> LocationIds
        {
            get => _locationIds ?? (_locationIds = new InputList<string>());
            set => _locationIds = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("schedulingStrategy", required: true)]
        public Input<string> SchedulingStrategy { get; set; } = null!;

        [Input("transactions", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestTransactionInputArgs>? _transactions;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestTransactionInputArgs> Transactions
        {
            get => _transactions ?? (_transactions = new InputList<Inputs.SyntheticsBrowserV2CheckTestTransactionInputArgs>());
            set => _transactions = value;
        }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("updatedAt", required: true)]
        public Input<string> UpdatedAt { get; set; } = null!;

        public SyntheticsBrowserV2CheckTestInputArgs()
        {
        }
        public static new SyntheticsBrowserV2CheckTestInputArgs Empty => new SyntheticsBrowserV2CheckTestInputArgs();
    }
}
