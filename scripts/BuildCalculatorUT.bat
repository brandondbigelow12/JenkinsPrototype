
@echo on
set MSBuild="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\amd64\MSBuild.exe"
set Configuration="Configuration=Release"
set MSTest="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\MSTest.exe"
set JenkinsCalcUTProj="D:\JenkinsPrototype\source\JenkinsMathLib\JenkinsMathLib\Unit Tests\JenkinsMathLibTests.csproj"
set JenkinsCalcUTDLL="D:\JenkinsPrototype\bin\UT bin\JenkinsMathLibTests.dll"
set UTBldResults="?D:\JenkinsPrototype\bin\UTResults\"
REM Building the unit test project
%MSBuild% %JenkinsCalcUTProj% /p:%Configuration% 

REM Executing the unit tests
%MSTest% /testcontainer:%JenkinsCalcUTDLL% /resultsfile:testresults.trx

pause