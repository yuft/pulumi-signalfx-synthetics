// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsApiV2CheckTestRequestInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("configurations")]
        private InputList<Inputs.SyntheticsApiV2CheckTestRequestConfigurationInputArgs>? _configurations;
        public InputList<Inputs.SyntheticsApiV2CheckTestRequestConfigurationInputArgs> Configurations
        {
            get => _configurations ?? (_configurations = new InputList<Inputs.SyntheticsApiV2CheckTestRequestConfigurationInputArgs>());
            set => _configurations = value;
        }

        [Input("setups", required: true)]
        private InputList<Inputs.SyntheticsApiV2CheckTestRequestSetupInputArgs>? _setups;
        public InputList<Inputs.SyntheticsApiV2CheckTestRequestSetupInputArgs> Setups
        {
            get => _setups ?? (_setups = new InputList<Inputs.SyntheticsApiV2CheckTestRequestSetupInputArgs>());
            set => _setups = value;
        }

        [Input("validations", required: true)]
        private InputList<Inputs.SyntheticsApiV2CheckTestRequestValidationInputArgs>? _validations;
        public InputList<Inputs.SyntheticsApiV2CheckTestRequestValidationInputArgs> Validations
        {
            get => _validations ?? (_validations = new InputList<Inputs.SyntheticsApiV2CheckTestRequestValidationInputArgs>());
            set => _validations = value;
        }

        public SyntheticsApiV2CheckTestRequestInputArgs()
        {
        }
        public static new SyntheticsApiV2CheckTestRequestInputArgs Empty => new SyntheticsApiV2CheckTestRequestInputArgs();
    }
}
