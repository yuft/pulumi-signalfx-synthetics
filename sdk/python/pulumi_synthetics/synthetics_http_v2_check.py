# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'SyntheticsHttpV2CheckResult',
    'AwaitableSyntheticsHttpV2CheckResult',
    'synthetics_http_v2_check',
    'synthetics_http_v2_check_output',
]

@pulumi.output_type
class SyntheticsHttpV2CheckResult:
    """
    A collection of values returned by syntheticsHttpV2Check.
    """
    def __init__(__self__, id=None, tests=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if tests and not isinstance(tests, list):
            raise TypeError("Expected argument 'tests' to be a list")
        pulumi.set(__self__, "tests", tests)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def tests(self) -> Sequence['outputs.SyntheticsHttpV2CheckTestResult']:
        return pulumi.get(self, "tests")


class AwaitableSyntheticsHttpV2CheckResult(SyntheticsHttpV2CheckResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return SyntheticsHttpV2CheckResult(
            id=self.id,
            tests=self.tests)


def synthetics_http_v2_check(tests: Optional[Sequence[pulumi.InputType['SyntheticsHttpV2CheckTestArgs']]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableSyntheticsHttpV2CheckResult:
    """
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_synthetics as synthetics

    datasource_check_http = synthetics.synthetics_http_v2_check(tests=[synthetics.SyntheticsHttpV2CheckTestArgs(
        id=490,
    )])
    ```
    <!--End PulumiCodeChooser -->
    """
    __args__ = dict()
    __args__['tests'] = tests
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('synthetics:index/syntheticsHttpV2Check:syntheticsHttpV2Check', __args__, opts=opts, typ=SyntheticsHttpV2CheckResult).value

    return AwaitableSyntheticsHttpV2CheckResult(
        id=pulumi.get(__ret__, 'id'),
        tests=pulumi.get(__ret__, 'tests'))


@_utilities.lift_output_func(synthetics_http_v2_check)
def synthetics_http_v2_check_output(tests: Optional[pulumi.Input[Sequence[pulumi.InputType['SyntheticsHttpV2CheckTestArgs']]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[SyntheticsHttpV2CheckResult]:
    """
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_synthetics as synthetics

    datasource_check_http = synthetics.synthetics_http_v2_check(tests=[synthetics.SyntheticsHttpV2CheckTestArgs(
        id=490,
    )])
    ```
    <!--End PulumiCodeChooser -->
    """
    ...
