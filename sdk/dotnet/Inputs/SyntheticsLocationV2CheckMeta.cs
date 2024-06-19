// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsLocationV2CheckMetaArgs : global::Pulumi.InvokeArgs
    {
        [Input("activeTestIds", required: true)]
        private List<int>? _activeTestIds;
        public List<int> ActiveTestIds
        {
            get => _activeTestIds ?? (_activeTestIds = new List<int>());
            set => _activeTestIds = value;
        }

        [Input("pausedTestIds", required: true)]
        private List<int>? _pausedTestIds;
        public List<int> PausedTestIds
        {
            get => _pausedTestIds ?? (_pausedTestIds = new List<int>());
            set => _pausedTestIds = value;
        }

        public SyntheticsLocationV2CheckMetaArgs()
        {
        }
        public static new SyntheticsLocationV2CheckMetaArgs Empty => new SyntheticsLocationV2CheckMetaArgs();
    }
}
