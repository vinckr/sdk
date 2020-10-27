# coding: utf-8

"""
    Ory Kratos

    Welcome to the ORY Kratos HTTP API documentation!  # noqa: E501

    The version of the OpenAPI document: v0.5.3-alpha.1
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from ory_kratos_client.configuration import Configuration


class RevokeSession(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'session_token': 'str'
    }

    attribute_map = {
        'session_token': 'session_token'
    }

    def __init__(self, session_token=None, local_vars_configuration=None):  # noqa: E501
        """RevokeSession - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._session_token = None
        self.discriminator = None

        self.session_token = session_token

    @property
    def session_token(self):
        """Gets the session_token of this RevokeSession.  # noqa: E501

        The Session Token  Invalidate this session token.  # noqa: E501

        :return: The session_token of this RevokeSession.  # noqa: E501
        :rtype: str
        """
        return self._session_token

    @session_token.setter
    def session_token(self, session_token):
        """Sets the session_token of this RevokeSession.

        The Session Token  Invalidate this session token.  # noqa: E501

        :param session_token: The session_token of this RevokeSession.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and session_token is None:  # noqa: E501
            raise ValueError("Invalid value for `session_token`, must not be `None`")  # noqa: E501

        self._session_token = session_token

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, RevokeSession):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, RevokeSession):
            return True

        return self.to_dict() != other.to_dict()
