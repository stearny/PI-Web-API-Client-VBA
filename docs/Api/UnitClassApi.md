# UnitClassApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](UnitClassApi.md#getbypath) | **GET** /unitclasses | Retrieve a unit class by path.
[**GetByPathWithHttpInfo**](UnitClassApi.md#getbypathwithhttpinfo) | **GET** /unitclasses | Retrieve a unit class by path.
[**Get**](UnitClassApi.md#get) | **GET** /unitclasses/{webId} | Retrieve a unit class.
[**GetWithHttpInfo**](UnitClassApi.md#getwithhttpinfo) | **GET** /unitclasses/{webId} | Retrieve a unit class.
[**Update**](UnitClassApi.md#update) | **PATCH** /unitclasses/{webId} | Update a unit class.
[**UpdateWithHttpInfo**](UnitClassApi.md#updatewithhttpinfo) | **PATCH** /unitclasses/{webId} | Update a unit class.
[**Delete**](UnitClassApi.md#delete) | **DELETE** /unitclasses/{webId} | Delete a unit class.
[**DeleteWithHttpInfo**](UnitClassApi.md#deletewithhttpinfo) | **DELETE** /unitclasses/{webId} | Delete a unit class.
[**GetCanonicalUnit**](UnitClassApi.md#getcanonicalunit) | **GET** /unitclasses/{webId}/canonicalunit | Get the canonical unit of a unit class.
[**GetCanonicalUnitWithHttpInfo**](UnitClassApi.md#getcanonicalunitwithhttpinfo) | **GET** /unitclasses/{webId}/canonicalunit | Get the canonical unit of a unit class.
[**GetUnits**](UnitClassApi.md#getunits) | **GET** /unitclasses/{webId}/units | Get a list of all units belonging to the unit class.
[**GetUnitsWithHttpInfo**](UnitClassApi.md#getunitswithhttpinfo) | **GET** /unitclasses/{webId}/units | Get a list of all units belonging to the unit class.
[**CreateUnit**](UnitClassApi.md#createunit) | **POST** /unitclasses/{webId}/units | Create a unit in the specified Unit Class.
[**CreateUnitWithHttpInfo**](UnitClassApi.md#createunitwithhttpinfo) | **POST** /unitclasses/{webId}/units | Create a unit in the specified Unit Class.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve a unit class by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIUnitClass**](../Responses/ApiResponsePIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a unit class by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIUnitClass**](../Model/PIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIUnitClass**](../Responses/ApiResponsePIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIUnitClass**](../Model/PIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIUnitClass unitClassDTO)

Update a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |
 **unitClassDTO** | **PIUnitClass**| A partial unit class containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIUnitClass unitClassDTO)

Update a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |
 **unitClassDTO** | **PIUnitClass**| A partial unit class containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCanonicalUnitWithHttpInfo**
> GetCanonicalUnitWithHttpInfo(string webId, string selectedFields = null)

Get the canonical unit of a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIUnit**](../Responses/ApiResponsePIUnit.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCanonicalUnit**
> GetCanonicalUnit(string webId, string selectedFields = null)

Get the canonical unit of a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetUnitsWithHttpInfo**
> GetUnitsWithHttpInfo(string webId, string selectedFields = null)

Get a list of all units belonging to the unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIUnit**](../Responses/ApiResponsePIUnit.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetUnits**
> GetUnits(string webId, string selectedFields = null)

Get a list of all units belonging to the unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateUnitWithHttpInfo**
> CreateUnitWithHttpInfo(string webId, PIUnit unitDTO)

Create a unit in the specified Unit Class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. |
 **unitDTO** | **PIUnit**| The new unit definition.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateUnit**
> CreateUnit(string webId, PIUnit unitDTO)

Create a unit in the specified Unit Class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. |
 **unitDTO** | **PIUnit**| The new unit definition.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)