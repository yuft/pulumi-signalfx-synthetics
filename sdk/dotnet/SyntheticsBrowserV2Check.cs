// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics
{
    public static class SyntheticsBrowserV2Check
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
        ///     var datasourceCheckBrowser = Synthetics.SyntheticsBrowserV2Check.Invoke(new()
        ///     {
        ///         Tests = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsBrowserV2CheckTestInputArgs
        ///             {
        ///                 Id = 496,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<SyntheticsBrowserV2CheckResult> InvokeAsync(SyntheticsBrowserV2CheckArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<SyntheticsBrowserV2CheckResult>("synthetics:index/syntheticsBrowserV2Check:syntheticsBrowserV2Check", args ?? new SyntheticsBrowserV2CheckArgs(), options.WithDefaults());

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
        ///     var datasourceCheckBrowser = Synthetics.SyntheticsBrowserV2Check.Invoke(new()
        ///     {
        ///         Tests = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsBrowserV2CheckTestInputArgs
        ///             {
        ///                 Id = 496,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<SyntheticsBrowserV2CheckResult> Invoke(SyntheticsBrowserV2CheckInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<SyntheticsBrowserV2CheckResult>("synthetics:index/syntheticsBrowserV2Check:syntheticsBrowserV2Check", args ?? new SyntheticsBrowserV2CheckInvokeArgs(), options.WithDefaults());
    }


    public sealed class SyntheticsBrowserV2CheckArgs : global::Pulumi.InvokeArgs
    {
        [Input("tests", required: true)]
        private List<Inputs.SyntheticsBrowserV2CheckTestArgs>? _tests;
        public List<Inputs.SyntheticsBrowserV2CheckTestArgs> Tests
        {
            get => _tests ?? (_tests = new List<Inputs.SyntheticsBrowserV2CheckTestArgs>());
            set => _tests = value;
        }

        public SyntheticsBrowserV2CheckArgs()
        {
        }
        public static new SyntheticsBrowserV2CheckArgs Empty => new SyntheticsBrowserV2CheckArgs();
    }

    public sealed class SyntheticsBrowserV2CheckInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("tests", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestInputArgs>? _tests;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestInputArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.SyntheticsBrowserV2CheckTestInputArgs>());
            set => _tests = value;
        }

        public SyntheticsBrowserV2CheckInvokeArgs()
        {
        }
        public static new SyntheticsBrowserV2CheckInvokeArgs Empty => new SyntheticsBrowserV2CheckInvokeArgs();
    }


    [OutputType]
    public sealed class SyntheticsBrowserV2CheckResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.SyntheticsBrowserV2CheckTestResult> Tests;

        [OutputConstructor]
        private SyntheticsBrowserV2CheckResult(
            string id,

            ImmutableArray<Outputs.SyntheticsBrowserV2CheckTestResult> tests)
        {
            Id = id;
            Tests = tests;
        }
    }
}
