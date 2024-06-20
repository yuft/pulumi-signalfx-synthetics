// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics
{
    public static class SyntheticsApiV2Check
    {
        /// <summary>
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Synthetics = Pulumi.Synthetics;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var datasourceCheckApi = Synthetics.SyntheticsApiV2Check.Invoke(new()
        ///     {
        ///         Tests = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsApiV2CheckTestInputArgs
        ///             {
        ///                 Id = 489,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<SyntheticsApiV2CheckResult> InvokeAsync(SyntheticsApiV2CheckArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<SyntheticsApiV2CheckResult>("synthetics:index/syntheticsApiV2Check:syntheticsApiV2Check", args ?? new SyntheticsApiV2CheckArgs(), options.WithDefaults());

        /// <summary>
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Synthetics = Pulumi.Synthetics;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var datasourceCheckApi = Synthetics.SyntheticsApiV2Check.Invoke(new()
        ///     {
        ///         Tests = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsApiV2CheckTestInputArgs
        ///             {
        ///                 Id = 489,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<SyntheticsApiV2CheckResult> Invoke(SyntheticsApiV2CheckInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<SyntheticsApiV2CheckResult>("synthetics:index/syntheticsApiV2Check:syntheticsApiV2Check", args ?? new SyntheticsApiV2CheckInvokeArgs(), options.WithDefaults());
    }


    public sealed class SyntheticsApiV2CheckArgs : global::Pulumi.InvokeArgs
    {
        [Input("tests", required: true)]
        private List<Inputs.SyntheticsApiV2CheckTestArgs>? _tests;
        public List<Inputs.SyntheticsApiV2CheckTestArgs> Tests
        {
            get => _tests ?? (_tests = new List<Inputs.SyntheticsApiV2CheckTestArgs>());
            set => _tests = value;
        }

        public SyntheticsApiV2CheckArgs()
        {
        }
        public static new SyntheticsApiV2CheckArgs Empty => new SyntheticsApiV2CheckArgs();
    }

    public sealed class SyntheticsApiV2CheckInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("tests", required: true)]
        private InputList<Inputs.SyntheticsApiV2CheckTestInputArgs>? _tests;
        public InputList<Inputs.SyntheticsApiV2CheckTestInputArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.SyntheticsApiV2CheckTestInputArgs>());
            set => _tests = value;
        }

        public SyntheticsApiV2CheckInvokeArgs()
        {
        }
        public static new SyntheticsApiV2CheckInvokeArgs Empty => new SyntheticsApiV2CheckInvokeArgs();
    }


    [OutputType]
    public sealed class SyntheticsApiV2CheckResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.SyntheticsApiV2CheckTestResult> Tests;

        [OutputConstructor]
        private SyntheticsApiV2CheckResult(
            string id,

            ImmutableArray<Outputs.SyntheticsApiV2CheckTestResult> tests)
        {
            Id = id;
            Tests = tests;
        }
    }
}