// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Outputs
{

    [OutputType]
    public sealed class SyntheticsBrowserV2CheckTestTransactionStepResult
    {
        public readonly string? Action;
        public readonly string? Name;
        public readonly string? OptionSelector;
        public readonly string? OptionSelectorType;
        public readonly ImmutableArray<Outputs.SyntheticsBrowserV2CheckTestTransactionStepOptionResult> Options;
        public readonly string? Selector;
        public readonly string? SelectorType;
        public readonly string? Type;
        public readonly string? Url;
        public readonly string? Value;
        public readonly string? VariableName;
        public readonly bool? WaitForNav;

        [OutputConstructor]
        private SyntheticsBrowserV2CheckTestTransactionStepResult(
            string? action,

            string? name,

            string? optionSelector,

            string? optionSelectorType,

            ImmutableArray<Outputs.SyntheticsBrowserV2CheckTestTransactionStepOptionResult> options,

            string? selector,

            string? selectorType,

            string? type,

            string? url,

            string? value,

            string? variableName,

            bool? waitForNav)
        {
            Action = action;
            Name = name;
            OptionSelector = optionSelector;
            OptionSelectorType = optionSelectorType;
            Options = options;
            Selector = selector;
            SelectorType = selectorType;
            Type = type;
            Url = url;
            Value = value;
            VariableName = variableName;
            WaitForNav = waitForNav;
        }
    }
}