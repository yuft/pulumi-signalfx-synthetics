// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCheckJavascriptFileArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id")]
        public int? Id { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public SyntheticsCheckJavascriptFileArgs()
        {
        }
        public static new SyntheticsCheckJavascriptFileArgs Empty => new SyntheticsCheckJavascriptFileArgs();
    }
}
