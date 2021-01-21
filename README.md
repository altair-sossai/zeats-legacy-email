<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-email

Extensions to solve common problems when working with Email addresses

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-email?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=19&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Email.svg)](https://www.nuget.org/packages/Zeats.Legacy.Email)

## Installation

```PM>
Install-Package Zeats.Legacy.Email
```

## Extensions

### IpValidator.IsIpV4(string email)
Checks if the content of a string is a valid Email V4
```c#
IpValidator.IsIpV4("10.a.30.40") /* return false */
IpValidator.IsIpV4("10.0.0.150") /* return true */
```
---
