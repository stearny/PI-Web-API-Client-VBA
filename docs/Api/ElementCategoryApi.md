# ElementCategoryApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](ElementCategoryApi.md#getbypath) | **GET** /elementcategories | Retrieve an element category by path.
[**GetByPathWithHttpInfo**](ElementCategoryApi.md#getbypathwithhttpinfo) | **GET** /elementcategories | Retrieve an element category by path.
[**Get**](ElementCategoryApi.md#get) | **GET** /elementcategories/{webId} | Retrieve an element category.
[**GetWithHttpInfo**](ElementCategoryApi.md#getwithhttpinfo) | **GET** /elementcategories/{webId} | Retrieve an element category.
[**Update**](ElementCategoryApi.md#update) | **PATCH** /elementcategories/{webId} | Update an element category by replacing items in its definition.
[**UpdateWithHttpInfo**](ElementCategoryApi.md#updatewithhttpinfo) | **PATCH** /elementcategories/{webId} | Update an element category by replacing items in its definition.
[**Delete**](ElementCategoryApi.md#delete) | **DELETE** /elementcategories/{webId} | Delete an element category.
[**DeleteWithHttpInfo**](ElementCategoryApi.md#deletewithhttpinfo) | **DELETE** /elementcategories/{webId} | Delete an element category.
[**GetSecurity**](ElementCategoryApi.md#getsecurity) | **GET** /elementcategories/{webId}/security | Get the security information of the specified security item associated with the element category for a specified user.
[**GetSecurityWithHttpInfo**](ElementCategoryApi.md#getsecuritywithhttpinfo) | **GET** /elementcategories/{webId}/security | Get the security information of the specified security item associated with the element category for a specified user.
[**GetSecurityEntries**](ElementCategoryApi.md#getsecurityentries) | **GET** /elementcategories/{webId}/securityentries | Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.
[**GetSecurityEntriesWithHttpInfo**](ElementCategoryApi.md#getsecurityentrieswithhttpinfo) | **GET** /elementcategories/{webId}/securityentries | Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.
[**CreateSecurityEntry**](ElementCategoryApi.md#createsecurityentry) | **POST** /elementcategories/{webId}/securityentries | Create a security entry owned by the element category.
[**CreateSecurityEntryWithHttpInfo**](ElementCategoryApi.md#createsecurityentrywithhttpinfo) | **POST** /elementcategories/{webId}/securityentries | Create a security entry owned by the element category.
[**GetSecurityEntryByName**](ElementCategoryApi.md#getsecurityentrybyname) | **GET** /elementcategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the element category with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](ElementCategoryApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /elementcategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the element category with the specified name.
[**UpdateSecurityEntry**](ElementCategoryApi.md#updatesecurityentry) | **PUT** /elementcategories/{webId}/securityentries/{name} | Update a security entry owned by the element category.
[**UpdateSecurityEntryWithHttpInfo**](ElementCategoryApi.md#updatesecurityentrywithhttpinfo) | **PUT** /elementcategories/{webId}/securityentries/{name} | Update a security entry owned by the element category.
[**DeleteSecurityEntry**](ElementCategoryApi.md#deletesecurityentry) | **DELETE** /elementcategories/{webId}/securityentries/{name} | Delete a security entry owned by the element category.
[**DeleteSecurityEntryWithHttpInfo**](ElementCategoryApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /elementcategories/{webId}/securityentries/{name} | Delete a security entry owned by the element category.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an element category by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIElementCategory**](../Responses/ApiResponsePIElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an element category by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIElementCategory**](../Model/PIElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The id of the element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIElementCategory**](../Responses/ApiResponsePIElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The id of the element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIElementCategory**](../Model/PIElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIElementCategory elementCategory)

Update an element category by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category to update.. |
 **elementCategory** | **PIElementCategory**| A partial element category containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIElementCategory elementCategory)

Update an element category by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category to update.. |
 **elementCategory** | **PIElementCategory**| A partial element category containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category to delete.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete an element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category to delete.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the element category for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityRights**](../Responses/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the element category for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Responses/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntry**
> CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element category where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the element category with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityEntry**](../Responses/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the element category with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element category.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the element category where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntry**
> UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the element category where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)

Delete a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element category where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntry**
> DeleteSecurityEntry(string name, string webId, bool applyToChildren)

Delete a security entry owned by the element category.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element category where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)