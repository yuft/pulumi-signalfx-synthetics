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
    public sealed class SyntheticsCreateBrowserCheckViewport
    {
        public readonly int? Height;
        public readonly int? Width;

        [OutputConstructor]
        private SyntheticsCreateBrowserCheckViewport(
            int? height,

            int? width)
        {
            Height = height;
            Width = width;
        }
    }
}
