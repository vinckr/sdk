# OryOathkeeperClient::SwaggerJSONWebKeySet

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **keys** | [**Array&lt;SwaggerJSONWebKey&gt;**](SwaggerJSONWebKey.md) | The value of the \&quot;keys\&quot; parameter is an array of JWK values.  By default, the order of the JWK values within the array does not imply an order of preference among them, although applications of JWK Sets can choose to assign a meaning to the order for their purposes, if desired. | [optional] |

## Example

```ruby
require 'ory-oathkeeper-client'

instance = OryOathkeeperClient::SwaggerJSONWebKeySet.new(
  keys: null
)
```

