# Getting started

Send SMS with Onfon Media SMS Platform.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (OnfonMediaSMSGateway.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the OnfonMediaSMSGateway library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

### 3. Add reference of the library project

In order to use the OnfonMediaSMSGateway library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` OnfonMediaSMSGateway.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```OnfonMediaSMSGateway.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=OnfonMedia%20SMS%20Gateway-CSharp&workspaceName=OnfonMediaSMSGateway&projectName=OnfonMediaSMSGateway.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| accessKey | Network Layer Access Key |
| apiKey | Used for authentication purpose and pass this parameter in URL encoded format. |
| clientId | Used for authentication purpose and pass this parameter in URL encoded format. |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string accessKey = "ACCESS_KEY"; // Network Layer Access Key
string apiKey = "API_KEY"; // Used for authentication purpose and pass this parameter in URL encoded format.
string clientId = "CLIENT_ID"; // Used for authentication purpose and pass this parameter in URL encoded format.

OnfonMediaSMSGatewayClient client = new OnfonMediaSMSGatewayClient(accessKey, apiKey, clientId);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [AccountController](#account_controller)
* [TemplateController](#template_controller)
* [SMSController](#sms_controller)
* [GROUPController](#group_controller)
* [CampaignController](#campaign_controller)

## <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "OnfonMediaSMSGateway.Standard.Controllers.AccountController") AccountController

### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

### <a name="get_credit_balance"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.AccountController.GetCreditBalance") GetCreditBalance

> Get Credit Balance


```csharp
Task<dynamic> GetCreditBalance()
```

#### Example Usage

```csharp

dynamic result = await account.GetCreditBalance();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="template_controller"></a>![Class: ](https://apidocs.io/img/class.png "OnfonMediaSMSGateway.Standard.Controllers.TemplateController") TemplateController

### Get singleton instance

The singleton instance of the ``` TemplateController ``` class can be accessed from the API Client.

```csharp
TemplateController template = client.Template;
```

### <a name="get_template_list"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.TemplateController.GetTemplateList") GetTemplateList

> Get Template List


```csharp
Task<dynamic> GetTemplateList()
```

#### Example Usage

```csharp

dynamic result = await template.GetTemplateList();

```


### <a name="create_new_template"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.TemplateController.CreateNewTemplate") CreateNewTemplate

> Create New Template


```csharp
Task<dynamic> CreateNewTemplate(string messageTemplate, string templateName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageTemplate |  ``` Required ```  | Template text. |
| templateName |  ``` Required ```  | Name of template |


#### Example Usage

```csharp
string messageTemplate = "MessageTemplate";
string templateName = "TemplateName";

dynamic result = await template.CreateNewTemplate(messageTemplate, templateName);

```


### <a name="update_template"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.TemplateController.UpdateTemplate") UpdateTemplate

> Update Template


```csharp
Task<dynamic> UpdateTemplate(string messageTemplate, string templateName, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageTemplate |  ``` Required ```  | Template text. |
| templateName |  ``` Required ```  | Name of template |
| id |  ``` Required ```  | id of template |


#### Example Usage

```csharp
string messageTemplate = "MessageTemplate";
string templateName = "TemplateName";
int id = 96;

dynamic result = await template.UpdateTemplate(messageTemplate, templateName, id);

```


### <a name="delete_template"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.TemplateController.DeleteTemplate") DeleteTemplate

> Delete Template


```csharp
Task<dynamic> DeleteTemplate(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | id of template |


#### Example Usage

```csharp
int id = 96;

dynamic result = await template.DeleteTemplate(id);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController") SMSController

### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

### <a name="get_sent_message_list"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.GetSentMessageList") GetSentMessageList

> Get Sent Message List


```csharp
Task<dynamic> GetSentMessageList(
        DateTime enddate,
        DateTime fromdate,
        int length,
        int start)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| enddate |  ``` Required ```  | Date format must be in yyyy-mm-dd |
| fromdate |  ``` Required ```  | Date format must be in yyyy-mm-dd |
| length |  ``` Required ```  | Ending index value to fetch the campaign detail. |
| start |  ``` Required ```  | Starting index value to fetch the campaign detail. |


#### Example Usage

```csharp
DateTime enddate = DateTime.Now();
DateTime fromdate = DateTime.Now();
int length = 96;
int start = 96;

dynamic result = await sMS.GetSentMessageList(enddate, fromdate, length, start);

```


### <a name="get_sent_message_status"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.GetSentMessageStatus") GetSentMessageStatus

> Get Sent Message Status


```csharp
Task<dynamic> GetSentMessageStatus(int messageId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageId |  ``` Required ```  | MessageId of message |


#### Example Usage

```csharp
int messageId = 96;

dynamic result = await sMS.GetSentMessageStatus(messageId);

```


### <a name="get_create_sms"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.GetCreateSMS") GetCreateSMS

> Create SMS


```csharp
Task<dynamic> GetCreateSMS(
        string message,
        string mobileNumber,
        string senderId,
        string coRelator = null,
        bool? isFlash = null,
        bool? isUnicode = null,
        string linkId = null,
        string groupId = null,
        string scheduleTime = null,
        string serviceId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| message |  ``` Required ```  | text message to send |
| mobileNumber |  ``` Required ```  | Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612 |
| senderId |  ``` Required ```  | Approved Sender Id |
| coRelator |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| isFlash |  ``` Optional ```  | Is_Flash is true or false for flash message |
| isUnicode |  ``` Optional ```  | Is_Unicode is true or false for unicode message |
| linkId |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| groupId |  ``` Optional ```  | Valid group-id of current user (only for group message otherwise leave empty string) |
| scheduleTime |  ``` Optional ```  | scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message) |
| serviceId |  ``` Optional ```  | Parameter required for using SDP OnSubscription Service |


#### Example Usage

```csharp
string message = "Message";
string mobileNumber = "MobileNumber";
string senderId = "SenderId";
string coRelator = "CoRelator";
bool? isFlash = false;
bool? isUnicode = false;
string linkId = "LinkId";
string groupId = "groupId";
string scheduleTime = "scheduleTime";
string serviceId = "serviceId";

dynamic result = await sMS.GetCreateSMS(message, mobileNumber, senderId, coRelator, isFlash, isUnicode, linkId, groupId, scheduleTime, serviceId);

```


### <a name="create_sms"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.CreateSMS") CreateSMS

> Create SMS


```csharp
Task<dynamic> CreateSMS(
        string message,
        string mobileNumber,
        string senderId,
        string coRelator = null,
        bool? isFlash = null,
        bool? isUnicode = null,
        string linkId = null,
        string groupId = null,
        string scheduleTime = null,
        string serviceId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| message |  ``` Required ```  | text message to send |
| mobileNumber |  ``` Required ```  | Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612 |
| senderId |  ``` Required ```  | Approved Sender Id |
| coRelator |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| isFlash |  ``` Optional ```  | Is_Flash is true or false for flash message |
| isUnicode |  ``` Optional ```  | Is_Unicode is true or false for unicode message |
| linkId |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| groupId |  ``` Optional ```  | Valid group-id of current user (only for group message otherwise leave empty string) |
| scheduleTime |  ``` Optional ```  | scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message) |
| serviceId |  ``` Optional ```  | Parameter required for using SDP OnSubscription Service |


#### Example Usage

```csharp
string message = "Message";
string mobileNumber = "MobileNumber";
string senderId = "SenderId";
string coRelator = "CoRelator";
bool? isFlash = false;
bool? isUnicode = false;
string linkId = "LinkId";
string groupId = "groupId";
string scheduleTime = "scheduleTime";
string serviceId = "serviceId";

dynamic result = await sMS.CreateSMS(message, mobileNumber, senderId, coRelator, isFlash, isUnicode, linkId, groupId, scheduleTime, serviceId);

```


### <a name="get_create_bulk_sms"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.GetCreateBulkSMS") GetCreateBulkSMS

> Create Bulk SMS


```csharp
Task<dynamic> GetCreateBulkSMS(
        string mobileNumberMessage,
        string senderId,
        string coRelator = null,
        bool? isFlash = null,
        bool? isUnicode = null,
        string linkId = null,
        DateTime? scheduleTime = null,
        string serviceId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mobileNumberMessage |  ``` Required ```  | Please ensure while submitting the request the message should be passed in encoded format. e.g. 78461230^test~78945612^hello |
| senderId |  ``` Required ```  | Approved Sender Id |
| coRelator |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| isFlash |  ``` Optional ```  | Is_Flash is true or false for flash message |
| isUnicode |  ``` Optional ```  | Is_Unicode is true or false for unicode message |
| linkId |  ``` Optional ```  | Parameter required for using SDP OnDemand Service |
| scheduleTime |  ``` Optional ```  | scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message) |
| serviceId |  ``` Optional ```  | Parameter required for using SDP OnSubscription Service |


#### Example Usage

```csharp
string mobileNumberMessage = "MobileNumber_Message";
string senderId = "SenderId";
string coRelator = "CoRelator";
bool? isFlash = false;
bool? isUnicode = false;
string linkId = "LinkId";
DateTime? scheduleTime = DateTime.Now();
string serviceId = "serviceId";

dynamic result = await sMS.GetCreateBulkSMS(mobileNumberMessage, senderId, coRelator, isFlash, isUnicode, linkId, scheduleTime, serviceId);

```


### <a name="create_bulk_sms"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.SMSController.CreateBulkSMS") CreateBulkSMS

> Create Bulk SMS


```csharp
Task<dynamic> CreateBulkSMS(
        List<string> messageParameters,
        string senderId,
        bool? isFlash = null,
        bool? isUnicode = null,
        DateTime? scheduleDateTime = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageParameters |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |
| senderId |  ``` Required ```  | Approved Sender Id |
| isFlash |  ``` Optional ```  | Is_Flash is true or false for flash message |
| isUnicode |  ``` Optional ```  | Is_Unicode is true or false for unicode message |
| scheduleDateTime |  ``` Optional ```  | scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message) |


#### Example Usage

```csharp
List<string> messageParameters = new List<string> { "MessageParameters" };
string senderId = "SenderId";
bool? isFlash = false;
bool? isUnicode = false;
DateTime? scheduleDateTime = DateTime.Now();

dynamic result = await sMS.CreateBulkSMS(messageParameters, senderId, isFlash, isUnicode, scheduleDateTime);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="group_controller"></a>![Class: ](https://apidocs.io/img/class.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController") GROUPController

### Get singleton instance

The singleton instance of the ``` GROUPController ``` class can be accessed from the API Client.

```csharp
GROUPController gROUP = client.GROUP;
```

### <a name="get_group_list"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController.GetGroupList") GetGroupList

> Get Group List


```csharp
Task<dynamic> GetGroupList()
```

#### Example Usage

```csharp

dynamic result = await gROUP.GetGroupList();

```


### <a name="create_new_group"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController.CreateNewGroup") CreateNewGroup

> Create New Group


```csharp
Task<dynamic> CreateNewGroup(string groupName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| groupName |  ``` Required ```  | Name for new group |


#### Example Usage

```csharp
string groupName = "GroupName";

dynamic result = await gROUP.CreateNewGroup(groupName);

```


### <a name="update_group"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController.UpdateGroup") UpdateGroup

> Update Group


```csharp
Task<dynamic> UpdateGroup(string groupName, string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| groupName |  ``` Required ```  | Name for new group |
| id |  ``` Required ```  | GroupID |


#### Example Usage

```csharp
string groupName = "GroupName";
string id = "id";

dynamic result = await gROUP.UpdateGroup(groupName, id);

```


### <a name="create_sub_group_group"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController.CreateSubGroupGroup") CreateSubGroupGroup

> Create Sub-Group Group


```csharp
Task<dynamic> CreateSubGroupGroup(string groupName, string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| groupName |  ``` Required ```  | Name for new group |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string groupName = "GroupName";
string id = "Id";

dynamic result = await gROUP.CreateSubGroupGroup(groupName, id);

```


### <a name="delete_group"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.GROUPController.DeleteGroup") DeleteGroup

> Delete Group


```csharp
Task<dynamic> DeleteGroup(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int id = 96;

dynamic result = await gROUP.DeleteGroup(id);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="campaign_controller"></a>![Class: ](https://apidocs.io/img/class.png "OnfonMediaSMSGateway.Standard.Controllers.CampaignController") CampaignController

### Get singleton instance

The singleton instance of the ``` CampaignController ``` class can be accessed from the API Client.

```csharp
CampaignController campaign = client.Campaign;
```

### <a name="get_campaign_message_status"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.CampaignController.GetCampaignMessageStatus") GetCampaignMessageStatus

> Get Campaign Message Status


```csharp
Task<dynamic> GetCampaignMessageStatus(int campaignId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| campaignId |  ``` Required ```  | First user have to call Get Campaigns api for CampaignId |


#### Example Usage

```csharp
int campaignId = 96;

dynamic result = await campaign.GetCampaignMessageStatus(campaignId);

```


### <a name="get_campaigns"></a>![Method: ](https://apidocs.io/img/method.png "OnfonMediaSMSGateway.Standard.Controllers.CampaignController.GetCampaigns") GetCampaigns

> Get Campaigns


```csharp
Task<dynamic> GetCampaigns(
        DateTime enddate,
        DateTime fromdate,
        int length,
        int start)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| enddate |  ``` Required ```  | Date format must be in yyyy-mm-dd |
| fromdate |  ``` Required ```  | Date format must be in yyyy-mm-dd |
| length |  ``` Required ```  | Ending index value to fetch the campaign detail. |
| start |  ``` Required ```  | Starting index value to fetch the campaign detail. |


#### Example Usage

```csharp
DateTime enddate = DateTime.Now();
DateTime fromdate = DateTime.Now();
int length = 96;
int start = 96;

dynamic result = await campaign.GetCampaigns(enddate, fromdate, length, start);

```


[Back to List of Controllers](#list_of_controllers)



