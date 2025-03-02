# ory_client.api.V0alpha0Api

## Load the API package
```dart
import 'package:ory_client/api.dart';
```

All URIs are relative to *https://playground.projects.oryapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createProject**](V0alpha0Api.md#createproject) | **POST** /backoffice/public/projects | Create a Project
[**getProject**](V0alpha0Api.md#getproject) | **GET** /backoffice/public/projects/{project_id} | Get a Project
[**listProjects**](V0alpha0Api.md#listprojects) | **GET** /backoffice/public/projects | List All Projects
[**updateProject**](V0alpha0Api.md#updateproject) | **PUT** /backoffice/public/projects/{project_id} | Update a Project


# **createProject**
> Project createProject(projectPatch)

Create a Project

Creates a new project.

### Example 
```dart
import 'package:ory_client/api.dart';
// TODO Configure API key authorization: oryAccessToken
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKey = 'YOUR_API_KEY';
// uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKeyPrefix = 'Bearer';

var api_instance = new V0alpha0Api();
var projectPatch = new ProjectPatch(); // ProjectPatch | 

try { 
    var result = api_instance.createProject(projectPatch);
    print(result);
} catch (e) {
    print('Exception when calling V0alpha0Api->createProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectPatch** | [**ProjectPatch**](ProjectPatch.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[oryAccessToken](../README.md#oryAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProject**
> Project getProject(projectId)

Get a Project

Get a projects you have access to by its ID.

### Example 
```dart
import 'package:ory_client/api.dart';
// TODO Configure API key authorization: oryAccessToken
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKey = 'YOUR_API_KEY';
// uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKeyPrefix = 'Bearer';

var api_instance = new V0alpha0Api();
var projectId = projectId_example; // String | Project ID  The project's ID.

try { 
    var result = api_instance.getProject(projectId);
    print(result);
} catch (e) {
    print('Exception when calling V0alpha0Api->getProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **String**| Project ID  The project's ID. | 

### Return type

[**Project**](Project.md)

### Authorization

[oryAccessToken](../README.md#oryAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **listProjects**
> BuiltList<Project> listProjects()

List All Projects

Lists all projects you have access to.

### Example 
```dart
import 'package:ory_client/api.dart';
// TODO Configure API key authorization: oryAccessToken
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKey = 'YOUR_API_KEY';
// uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKeyPrefix = 'Bearer';

var api_instance = new V0alpha0Api();

try { 
    var result = api_instance.listProjects();
    print(result);
} catch (e) {
    print('Exception when calling V0alpha0Api->listProjects: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList<Project>**](Project.md)

### Authorization

[oryAccessToken](../README.md#oryAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **updateProject**
> Project updateProject(projectId, projectPatch)

Update a Project

Creates a new configuration revision for a project.

### Example 
```dart
import 'package:ory_client/api.dart';
// TODO Configure API key authorization: oryAccessToken
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKey = 'YOUR_API_KEY';
// uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//defaultApiClient.getAuthentication<ApiKeyAuth>('oryAccessToken').apiKeyPrefix = 'Bearer';

var api_instance = new V0alpha0Api();
var projectId = projectId_example; // String | Project ID  The project's ID.
var projectPatch = new ProjectPatch(); // ProjectPatch | 

try { 
    var result = api_instance.updateProject(projectId, projectPatch);
    print(result);
} catch (e) {
    print('Exception when calling V0alpha0Api->updateProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **String**| Project ID  The project's ID. | 
 **projectPatch** | [**ProjectPatch**](ProjectPatch.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[oryAccessToken](../README.md#oryAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

