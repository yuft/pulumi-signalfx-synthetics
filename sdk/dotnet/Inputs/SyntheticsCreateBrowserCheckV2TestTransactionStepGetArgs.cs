// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckV2TestTransactionStepGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("action")]
        public Input<string>? Action { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("optionSelector")]
        public Input<string>? OptionSelector { get; set; }

        [Input("optionSelectorType")]
        public Input<string>? OptionSelectorType { get; set; }

        [Input("options")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionStepOptionGetArgs>? _options;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionStepOptionGetArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestTransactionStepOptionGetArgs>());
            set => _options = value;
        }

        [Input("selector")]
        public Input<string>? Selector { get; set; }

        [Input("selectorType")]
        public Input<string>? SelectorType { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("variableName")]
        public Input<string>? VariableName { get; set; }

        [Input("waitForNav", required: true)]
        public Input<bool> WaitForNav { get; set; } = null!;

        public SyntheticsCreateBrowserCheckV2TestTransactionStepGetArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2TestTransactionStepGetArgs Empty => new SyntheticsCreateBrowserCheckV2TestTransactionStepGetArgs();
    }
}
