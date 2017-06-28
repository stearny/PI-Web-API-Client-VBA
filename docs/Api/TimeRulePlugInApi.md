# TimeRulePlugInApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](TimeRulePlugInApi.md#getbypath) | **GET** /timeruleplugins | Retrieve a Time Rule Plug-in by path.
[**GetByPathWithHttpInfo**](TimeRulePlugInApi.md#getbypathwithhttpinfo) | **GET** /timeruleplugins | Retrieve a Time Rule Plug-in by path.
[**Get**](TimeRulePlugInApi.md#get) | **GET** /timeruleplugins/{webId} | Retrieve a Time Rule Plug-in.
[**GetWithHttpInfo**](TimeRulePlugInApi.md#getwithhttpinfo) | **GET** /timeruleplugins/{webId} | Retrieve a Time Rule Plug-in.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve a Time Rule Plug-in by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the Time Rule Plug-in.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePITimeRulePlugIn**](../Responses/ApiResponsePITimeRulePlugIn.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a Time Rule Plug-in by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the Time Rule Plug-in.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PITimeRulePlugIn**](../Model/PITimeRulePlugIn.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve a Time Rule Plug-in.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Time Rule Plug-in.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePITimeRulePlugIn**](../Responses/ApiResponsePITimeRulePlugIn.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a Time Rule Plug-in.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Time Rule Plug-in.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PITimeRulePlugIn**](../Model/PITimeRulePlugIn.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)