@echo on
set MSBuild="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\amd64\MSBuild.exe"
set JenkinsMathLibBase="D:\JenkinsPrototype\source\JenkinsMathLib\JenkinsMathLib\JenkinsMathLib\"
set JenkinsMathLibProj="D:\JenkinsPrototype\source\JenkinsMathLib\JenkinsMathLib\JenkinsMathLib\JenkinsMathLib.csproj"
set Configuration="Configuration=Release"
%MSBuild% %JenkinsMathLibProj% /p:%Configuration% 
pause