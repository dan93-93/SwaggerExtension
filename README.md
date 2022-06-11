# SwaggerExtension for C# API!

This is a quick copy and paste solution for de-cluttering your Program.cs file and dependency injecting the swagger service

## Requirements
NuGets:
- Swashbuckle.AspNetCore.SwaggerGen
- Swashbuckle.AspNetCore.NewtonSoft
- Implementation time: 5 minutes

## How to start
1) Create an Extensions folder and paste in the SwaggerExtension.cs code
2) Edit the extension however you want to
3) Then in the Program.cs add `builder.Services.AddSwaggerExtension();`

### Make sure to disable warnings for error code 1591
- In VS2022, code go to Project > [yourprojectname] Properties
- Scroll down and find the Errors and warnings section
- Add 1591 in to the 'Supress specific warnings' field
- Save

### Set your xmlPath
- In VS2022, code go to Project > [yourprojectname] Properties
- Scroll down and find the output section
- In the XML Documentation file path add your [projectname].xml
	- Note, it needs to be the project name exactly, otherwise it'll error
