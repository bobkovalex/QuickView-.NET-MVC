# QuickView .NET MVC Sample
###### version 18.4.0


## System Requirements
- .NET Framework 4.5
- Visual Studio 2015



## Description
Native, simple, fully configurable and optimized .NET document viewer application. Open and view your document without losing data and/or formatting.

Thanks to powerful and flexible [GroupDocs.Viewer for .NET](https://products.groupdocs.com/viewer/net) API, over 50 document formats are supported across all platforms (Windows, Unix) and browsers (Chrome, Firefox, Safari, Opera, IE). All rendered documents are 100% copies of original documents without any quality loss.

This sample can be run as service with RESTful API or as standalone application with built-in UI.

**Note** In order to get all benefits and to use all features without any limitations you need to purchase valid [GroupDocs.Viewer for .NET license](http://purchase.groupdocs.com/purchase/order-online-step-1-of-8.aspx) or request [GroupDocs.Viewer for .NET temporary license](https://forum.groupdocs.com/c/viewer)


## Instructions

#### Run as RESTful Service
Running QuickView .NET MVC Sample as service will allow you to host your application on any instance and provide fully working RESTful API.

###### Features
- Doesn't require to access working server all the time for UI updates.
- Doesn't require service restart for any UI updates.
- Allows to have multiple UI applications on a different instances but with one main server.
- Allows to implement additional features in your application, such as user-roles, additional permissions, groups, etc.
- Remote controls and access.

###### How to run in **Service Mode**
1. Download QuickView .NET MVC.
2. Extract QuickView .NET MVC to desired/work directory (if sample was downloaded as zip).
3. Navigate to QuickView .NET MVC root directory.
4. Open QuickView.sln in the Visual Studio.
4. Update `Web.config` file by setting 'runAsService' true in the "quickViewConfig" section.
5. Start the solution.
6. Download [QuickView](https://github.com/LilAlex/QuickView).
7. Extract QuickView to desired/work directory (if downloaded as zip).
8. Navigate to QuickView root directory.
10. Open `quickview.html` file in text editor.
11. Update `applicationPath` parameter with your server URL.
12. Open `quickview.html` with any browser.


#### Run as Standalone Application
Running QuickView .NET MVC as standalone application is more simple and host all-in-one on single server, which will be accessible by all users directly.

###### Features
- Simple all-in-one application.
- Allows to implement additional features in your application, such as user-roles, additional permissions, groups, etc.

###### How to run in **Standalone Mode**
1. Download QuickView .NET MVC.
2. Extract QuickView .NET MVC to desired/work directory (if sample was downloaded as zip).
3. Navigate to QuickView .NET MVC root directory.
4. Open QuickView.sln in the Visual Studio.
4. Update `Web.config` file by setting 'runAsService' false in the "quickViewConfig" section..
5. Start the solution
7. Go to `localhost:PORT/viewer/`, PORT - port number specified in project Properties (by default http://localhost:8080/viewer/).
