dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true
Move-Item -Path '.\bin\Release\netcoreapp3.1\win-x64\publish\C# Hex to Ascii.exe' -Destination .\