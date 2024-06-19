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
    public sealed class SyntheticsCreateBrowserCheckCookie
    {
        public readonly string? Domain;
        public readonly string? Key;
        public readonly string? Path;
        public readonly string? Value;

        [OutputConstructor]
        private SyntheticsCreateBrowserCheckCookie(
            string? domain,

            string? key,

            string? path,

            string? value)
        {
            Domain = domain;
            Key = key;
            Path = path;
            Value = value;
        }
    }
}
