# CluedIn.Crawling.Dynamics365

CluedIn crawler for Dynamics365.

[![Build Status](https://dev.azure.com/CluedIn-io/CluedIn%20Crawlers/_apis/build/status/CluedIn-io.CluedIn.Crawling.Dynamics365?branchName=master)](https://dev.azure.com/CluedIn-io/CluedIn%20Crawlers/_build/latest?definitionId=TODO&branchName=master)
------

## Overview

This repository contains the code and associated tests for the Dynamics365 crawler.

## Working with the Code

Load [Crawling.Dynamics365.sln](.\Crawling.Dynamics365.sln) in Visual Studio or your preferred development IDE.

## Authentication with Dynamics365

This tutorial shows how to setup authentication with Dynamics365: <https://www.youtube.com/watch?v=Td7Bk3IXJ9s>

In order to create application users in Dynamics365, make sure that you are assigned the role "Dynamics 365 Administrator" in Azure AD.
After having this role assigned you'll have to log out and in again for the changes to take effect.

### OAuth with Postman

Using implicit flow, follow guide in <https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/webapi/setup-postman-environment>.


Remember to allow access tokens under authentication for app in Azure AD.
Use <https://localhost> as callback URL, since Azure AD does not accept <https://callbackurl>.

### Running Tests

<!-- A mocked environment is required to run `integration` and `acceptance` tests. The mocked environment can be built and run using the following [Docker](https://www.docker.com/) command:

```Shell
docker-compose up --build -d
``` -->

To run all `unit` and `integration` tests

```Shell
dotnet test --filter Unit
```

To run only `integration` tests

```Shell
dotnet test --filter Integration
```

To run [Pester](https://github.com/pester/Pester) `acceptance` tests

```PowerShell
invoke-pester test\acceptance
```

<!-- 
To review the [WireMock](http://wiremock.org/) HTTP proxy logs

```Shell
docker-compose logs wiremock
``` -->

## References

* [Dynamics365](TODO)

### Tooling

* [Docker](https://www.docker.com/)
* [Pester](https://github.com/pester/Pester)
<!-- * [WireMock](http://wiremock.org/) -->
