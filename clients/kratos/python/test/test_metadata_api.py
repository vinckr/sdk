"""
    Ory Kratos API

    Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests.   # noqa: E501

    The version of the OpenAPI document: v0.8.0-alpha.2
    Contact: hi@ory.sh
    Generated by: https://openapi-generator.tech
"""


import unittest

import ory_kratos_client
from ory_kratos_client.api.metadata_api import MetadataApi  # noqa: E501


class TestMetadataApi(unittest.TestCase):
    """MetadataApi unit test stubs"""

    def setUp(self):
        self.api = MetadataApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_get_version(self):
        """Test case for get_version

        Return Running Software Version.  # noqa: E501
        """
        pass

    def test_is_alive(self):
        """Test case for is_alive

        Check HTTP Server Status  # noqa: E501
        """
        pass

    def test_is_ready(self):
        """Test case for is_ready

        Check HTTP Server and Database Status  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
