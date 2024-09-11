### Repository with simple MSB3277 example

Build warnings:

```
warning MSB3277: Found conflicts between different versions of "SharedDependency" that could not be resolved. [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277: There was a conflict between "SharedDependency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=3e1fed751cb61585" and "SharedDependency, Version=1.0.0.1, Culture=neutral, PublicKeyToken=3e1fed751cb61585". [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:     "SharedDependency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=3e1fed751cb61585" was chosen because it was primary and "SharedDependency, Version=1.0.0.1, Culture=neutral, PublicKeyToken=3e1fed751cb61585" was not. [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:     References which depend on "SharedDependency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=3e1fed751cb61585" [C:\Users\Me\source\repos\SharedDependency\Versions\1.0.0.0\SharedDependency.dll]. [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:         C:\Users\Me\source\repos\SharedDependency\Versions\1.0.0.0\SharedDependency.dll [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:           Project file item includes which caused reference "C:\Users\Me\source\repos\SharedDependency\Versions\1.0.0.0\SharedDependency.dll". [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:             SharedDependency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=3e1fed751cb61585 [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:     References which depend on "SharedDependency, Version=1.0.0.1, Culture=neutral, PublicKeyToken=3e1fed751cb61585" [C:\Users\Me\source\repos\LibraryB\bin\Debug\SharedDependency.dll]. [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:         C:\Users\Me\source\repos\LibraryA\bin\Debug\LibraryA.dll [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:           Project file item includes which caused reference "C:\Users\Me\source\repos\LibraryA\bin\Debug\LibraryA.dll". [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:             LibraryA [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:         C:\Users\Me\source\repos\LibraryB\bin\Debug\LibraryB.dll [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:           Project file item includes which caused reference "C:\Users\Me\source\repos\LibraryB\bin\Debug\LibraryB.dll". [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]
warning MSB3277:             LibraryB [C:\Users\Me\source\repos\ExampleProgram\ExampleProgram.csproj]			
```

Visualized:

![image](https://user-images.githubusercontent.com/8726792/186794177-0cd378b1-8014-41be-a6c8-a4019916bc3e.png)
