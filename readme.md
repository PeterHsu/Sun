# ASP.NET Core
## 1. 查版本
```
>dotnet --vesion
```
> 2.1.302
##2. 查資訊
```
>dotnet --info
```

> .NET Core SDK (反映任何 global.json):
>  Version:   2.1.302
>  Commit:    9048955601
> 
> 執行階段環境:
>  OS Name:     Windows
>  OS Version:  6.1.7601
>  OS Platform: Windows
>  RID:         win7-x64
>  Base Path:   C:\Program Files\dotnet\sdk\2.1.302\
> 
> Host (useful for support):
>   Version: 2.1.2
>   Commit:  811c3ce6c0
> 
> .NET Core SDKs installed:
>   2.1.302 [C:\Program Files\dotnet\sdk]
> 
> .NET Core runtimes installed:
>   Microsoft.AspNetCore.All 2.1.0 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
>   Microsoft.AspNetCore.All 2.1.1 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
>   Microsoft.AspNetCore.All 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
>   Microsoft.AspNetCore.App 2.1.0 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
>   Microsoft.AspNetCore.App 2.1.1 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
>   Microsoft.AspNetCore.App 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
>   Microsoft.NETCore.App 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
> 
> To install additional .NET Core runtimes or SDKs:
>   https://aka.ms/dotnet-download
## 3. 建立Web API專案, 目錄為Sun(預設專案為目錄名稱)
```
>dotnet new webapi -o Sun
```
## 4. 加入(從Visual Studio 2017複製來的)
  1. .gitattributes
  2. .gitignore
## 5. 加入版控
```
>git init
>git add .
>git commit -m “first commit”
```
## 6. 移除HTTPS
  1. 修改launchSettings.json
  2. 修改Startup.cs
## 7. 版控記錄差異
```
>git add .
>git commit -m “移除HTTPS”
```
看程式版本比對
## 8. 使用DI讀取組態
看程式版本比對