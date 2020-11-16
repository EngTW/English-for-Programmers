# Project Creation Log

```
$ date
Sat Nov 14 01:46:53 UTC 2020
$ dotnet --version
5.0.100
$ # List installed templates.
$ dotnet new --uninstall
Template Instantiation Commands for .NET Core CLI

Currently installed items:
  NUnit3.DotNetNew.Template
    Details:
      NuGetPackageId: NUnit3.DotNetNew.Template
      Version: 1.8.1
      Author: akharlov
    Templates:
      NUnit 3 Test Project (nunit) C#
      NUnit 3 Test Item (nunit-test) C#
      NUnit 3 Test Project (nunit) F#
      NUnit 3 Test Item (nunit-test) F#
      NUnit 3 Test Project (nunit) VB
      NUnit 3 Test Item (nunit-test) VB
    Uninstall Command:
      dotnet new -u NUnit3.DotNetNew.Template

  Microsoft.DotNet.Web.Spa.ProjectTemplates.5.0
    Details:
      NuGetPackageId: Microsoft.DotNet.Web.Spa.ProjectTemplates.5.0
      Version: 5.0.0
      Author: Microsoft
    Templates:
      ASP.NET Core with Angular (angular) C#
      ASP.NET Core with React.js (react) C#
      ASP.NET Core with React.js and Redux (reactredux) C#
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Web.Spa.ProjectTemplates.5.0

  Microsoft.DotNet.Test.ProjectTemplates.5.0
    Details:
      NuGetPackageId: Microsoft.DotNet.Test.ProjectTemplates.5.0
      Version: 1.0.2-beta4.20420.1
      Author: Microsoft
    Templates:
      Unit Test Project (mstest) C#
      Unit Test Project (mstest) F#
      Unit Test Project (mstest) VB
      xUnit Test Project (xunit) C#
      xUnit Test Project (xunit) F#
      xUnit Test Project (xunit) VB
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Test.ProjectTemplates.5.0

  Microsoft.DotNet.Web.ItemTemplates
    Details:
      NuGetPackageId: Microsoft.DotNet.Web.ItemTemplates
      Version: 5.0.0
      Author: Microsoft
    Templates:
      Protocol Buffer File (proto)
      Razor Component (razorcomponent) C#
      Razor Page (page) C#
      MVC ViewImports (viewimports) C#
      MVC ViewStart (viewstart) C#
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Web.ItemTemplates

  Microsoft.DotNet.Web.ProjectTemplates.5.0
    Details:
      NuGetPackageId: Microsoft.DotNet.Web.ProjectTemplates.5.0
      Version: 5.0.0
      Author: Microsoft
    Templates:
      Blazor Server App (blazorserver) C#
      Blazor WebAssembly App (blazorwasm) C#
      ASP.NET Core Empty (web) C#
      ASP.NET Core Empty (web) F#
      ASP.NET Core gRPC Service (grpc) C#
      Razor Class Library (razorclasslib) C#
      ASP.NET Core Web App (webapp) C#
      ASP.NET Core Web App (Model-View-Controller) (mvc) C#
      ASP.NET Core Web App (Model-View-Controller) (mvc) F#
      ASP.NET Core Web API (webapi) C#
      ASP.NET Core Web API (webapi) F#
      Worker Service (worker) C#
      Worker Service (worker) F#
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Web.ProjectTemplates.5.0

  Microsoft.DotNet.Common.ProjectTemplates.5.0
    Details:
      NuGetPackageId: Microsoft.DotNet.Common.ProjectTemplates.5.0
      Version: 5.0.0
      Author: Microsoft
    Templates:
      Class library (classlib) C#
      Class library (classlib) F#
      Class library (classlib) VB
      Console Application (console) C#
      Console Application (console) F#
      Console Application (console) VB
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Common.ProjectTemplates.5.0

  Microsoft.DotNet.Common.ItemTemplates
    Details:
      NuGetPackageId: Microsoft.DotNet.Common.ItemTemplates
      Version: 5.0.0
      Author: Microsoft
    Templates:
      dotnet gitignore file (gitignore)
      global.json file (globaljson)
      NuGet Config (nugetconfig)
      Solution File (sln)
      Dotnet local tool manifest file (tool-manifest)
      Web Config (webconfig)
    Uninstall Command:
      dotnet new -u Microsoft.DotNet.Common.ItemTemplates

$ basename $(pwd)
Common
$ dotnet new classlib --no-restore
The template "Class library" was created successfully.
```
