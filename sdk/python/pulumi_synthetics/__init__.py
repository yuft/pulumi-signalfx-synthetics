# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .provider import *
from .synthetics_api_v2_check import *
from .synthetics_browser_v2_check import *
from .synthetics_check import *
from .synthetics_create_api_check_v2 import *
from .synthetics_create_browser_check import *
from .synthetics_create_browser_check_v2 import *
from .synthetics_create_http_check import *
from .synthetics_create_http_check_v2 import *
from .synthetics_create_location_v2 import *
from .synthetics_create_port_check_v2 import *
from .synthetics_create_variable_v2 import *
from .synthetics_devices_v2_check import *
from .synthetics_http_v2_check import *
from .synthetics_location_v2_check import *
from .synthetics_locations_v2_check import *
from .synthetics_port_v2_check import *
from .synthetics_variable_v2_check import *
from .synthetics_variables_v2_check import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_synthetics.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumi_synthetics.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateApiCheckV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateApiCheckV2:SyntheticsCreateApiCheckV2": "SyntheticsCreateApiCheckV2"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateBrowserCheck",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateBrowserCheck:SyntheticsCreateBrowserCheck": "SyntheticsCreateBrowserCheck"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateBrowserCheckV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateBrowserCheckV2:SyntheticsCreateBrowserCheckV2": "SyntheticsCreateBrowserCheckV2"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateHttpCheck",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateHttpCheck:SyntheticsCreateHttpCheck": "SyntheticsCreateHttpCheck"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateHttpCheckV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateHttpCheckV2:SyntheticsCreateHttpCheckV2": "SyntheticsCreateHttpCheckV2"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateLocationV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateLocationV2:SyntheticsCreateLocationV2": "SyntheticsCreateLocationV2"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreatePortCheckV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreatePortCheckV2:SyntheticsCreatePortCheckV2": "SyntheticsCreatePortCheckV2"
  }
 },
 {
  "pkg": "synthetics",
  "mod": "index/syntheticsCreateVariableV2",
  "fqn": "pulumi_synthetics",
  "classes": {
   "synthetics:index/syntheticsCreateVariableV2:SyntheticsCreateVariableV2": "SyntheticsCreateVariableV2"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "synthetics",
  "token": "pulumi:providers:synthetics",
  "fqn": "pulumi_synthetics",
  "class": "Provider"
 }
]
"""
)
