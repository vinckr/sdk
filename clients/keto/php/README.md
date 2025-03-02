# ory/keto-client

Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.

For more information, please visit [https://www.ory.sh](https://www.ory.sh).

## Installation & Usage

### Requirements

PHP 7.3 and later.
Should also work with PHP 8.0 but has not been tested.

### Composer

To install the bindings via [Composer](https://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/ory/keto-client-php.git"
    }
  ],
  "require": {
    "ory/keto-client-php": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
<?php
require_once('/path/to/ory/keto-client/vendor/autoload.php');
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new Ory\Keto\Client\Api\HealthApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $result = $apiInstance->isInstanceAlive();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HealthApi->isInstanceAlive: ', $e->getMessage(), PHP_EOL;
}

```

## API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*HealthApi* | [**isInstanceAlive**](docs/Api/HealthApi.md#isinstancealive) | **GET** /health/alive | Check alive status
*HealthApi* | [**isInstanceReady**](docs/Api/HealthApi.md#isinstanceready) | **GET** /health/ready | Check readiness status
*ReadApi* | [**getCheck**](docs/Api/ReadApi.md#getcheck) | **GET** /check | Check a relation tuple
*ReadApi* | [**getExpand**](docs/Api/ReadApi.md#getexpand) | **GET** /expand | Expand a Relation Tuple
*ReadApi* | [**getRelationTuples**](docs/Api/ReadApi.md#getrelationtuples) | **GET** /relation-tuples | Query relation tuples
*ReadApi* | [**postCheck**](docs/Api/ReadApi.md#postcheck) | **POST** /check | Check a relation tuple
*VersionApi* | [**getVersion**](docs/Api/VersionApi.md#getversion) | **GET** /version | Get service version
*WriteApi* | [**createRelationTuple**](docs/Api/WriteApi.md#createrelationtuple) | **PUT** /relation-tuples | Create a Relation Tuple
*WriteApi* | [**deleteRelationTuple**](docs/Api/WriteApi.md#deleterelationtuple) | **DELETE** /relation-tuples | Delete a Relation Tuple
*WriteApi* | [**patchRelationTuples**](docs/Api/WriteApi.md#patchrelationtuples) | **PATCH** /relation-tuples | Patch Multiple Relation Tuples

## Models

- [ExpandTree](docs/Model/ExpandTree.md)
- [GetCheckResponse](docs/Model/GetCheckResponse.md)
- [GetRelationTuplesResponse](docs/Model/GetRelationTuplesResponse.md)
- [HealthNotReadyStatus](docs/Model/HealthNotReadyStatus.md)
- [HealthStatus](docs/Model/HealthStatus.md)
- [InlineResponse400](docs/Model/InlineResponse400.md)
- [InternalRelationTuple](docs/Model/InternalRelationTuple.md)
- [PatchDelta](docs/Model/PatchDelta.md)
- [RelationQuery](docs/Model/RelationQuery.md)
- [SubjectSet](docs/Model/SubjectSet.md)
- [Version](docs/Model/Version.md)

## Authorization
All endpoints do not require authorization.
## Tests

To run the tests, use:

```bash
composer install
vendor/bin/phpunit
```

## Author

hi@ory.sh

## About this package

This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: `v0.7.0-alpha.1`
- Build package: `org.openapitools.codegen.languages.PhpClientCodegen`
