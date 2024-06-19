// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics
{
    public static class SyntheticsVariableV2Check
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
        ///     var datasourceCheckVariable = Synthetics.SyntheticsVariableV2Check.Invoke(new()
        ///     {
        ///         Variables = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsVariableV2CheckVariableInputArgs
        ///             {
        ///                 Id = 246,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<SyntheticsVariableV2CheckResult> InvokeAsync(SyntheticsVariableV2CheckArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<SyntheticsVariableV2CheckResult>("synthetics:index/syntheticsVariableV2Check:syntheticsVariableV2Check", args ?? new SyntheticsVariableV2CheckArgs(), options.WithDefaults());

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
        ///     var datasourceCheckVariable = Synthetics.SyntheticsVariableV2Check.Invoke(new()
        ///     {
        ///         Variables = new[]
        ///         {
        ///             new Synthetics.Inputs.SyntheticsVariableV2CheckVariableInputArgs
        ///             {
        ///                 Id = 246,
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<SyntheticsVariableV2CheckResult> Invoke(SyntheticsVariableV2CheckInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<SyntheticsVariableV2CheckResult>("synthetics:index/syntheticsVariableV2Check:syntheticsVariableV2Check", args ?? new SyntheticsVariableV2CheckInvokeArgs(), options.WithDefaults());
    }


    public sealed class SyntheticsVariableV2CheckArgs : global::Pulumi.InvokeArgs
    {
        [Input("variables", required: true)]
        private List<Inputs.SyntheticsVariableV2CheckVariableArgs>? _variables;
        public List<Inputs.SyntheticsVariableV2CheckVariableArgs> Variables
        {
            get => _variables ?? (_variables = new List<Inputs.SyntheticsVariableV2CheckVariableArgs>());
            set => _variables = value;
        }

        public SyntheticsVariableV2CheckArgs()
        {
        }
        public static new SyntheticsVariableV2CheckArgs Empty => new SyntheticsVariableV2CheckArgs();
    }

    public sealed class SyntheticsVariableV2CheckInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("variables", required: true)]
        private InputList<Inputs.SyntheticsVariableV2CheckVariableInputArgs>? _variables;
        public InputList<Inputs.SyntheticsVariableV2CheckVariableInputArgs> Variables
        {
            get => _variables ?? (_variables = new InputList<Inputs.SyntheticsVariableV2CheckVariableInputArgs>());
            set => _variables = value;
        }

        public SyntheticsVariableV2CheckInvokeArgs()
        {
        }
        public static new SyntheticsVariableV2CheckInvokeArgs Empty => new SyntheticsVariableV2CheckInvokeArgs();
    }


    [OutputType]
    public sealed class SyntheticsVariableV2CheckResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.SyntheticsVariableV2CheckVariableResult> Variables;

        [OutputConstructor]
        private SyntheticsVariableV2CheckResult(
            string id,

            ImmutableArray<Outputs.SyntheticsVariableV2CheckVariableResult> variables)
        {
            Id = id;
            Variables = variables;
        }
    }
}
