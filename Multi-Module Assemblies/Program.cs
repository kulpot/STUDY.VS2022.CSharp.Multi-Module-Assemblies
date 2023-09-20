using System;

//ref link:https://www.youtube.com/watch?v=Yb-ZL4lexTk&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=6
//

// UsesAssemblyA.exe    //ref: AssemblyA
// UsesAssemblyB.exe    //ref: AssemblyB
// AssemblyA -> contains Module 1,2
// AssemblyB -> contains Module 2,3

// cmd type - /t:library - means a dll, means no entry point, no main

/*-----------------------------------CMD------------------------------------
 * 
 *
 *
C:\Users\sunny\source\repos\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies

21/09/2023  05:07 am    <DIR>          .
21/09/2023  05:07 am    <DIR>          ..
21/09/2023  05:08 am    <DIR>          Multi-Module Assemblies
21/09/2023  05:07 am             1,175 Multi-Module Assemblies.sln
               1 File(s)          1,175 bytes
               3 Dir(s)  490,449,326,080 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies>cd Multi-Module Assemblies

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:08 am    <DIR>          .
21/09/2023  05:08 am    <DIR>          ..
21/09/2023  05:07 am               189 App.config
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:07 am             2,396 Multi-Module Assemblies.csproj
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:08 am               191 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               3 File(s)          2,776 bytes
               5 Dir(s)  490,449,334,272 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>erase *.*
C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:10 am    <DIR>          .
21/09/2023  05:10 am    <DIR>          ..
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:07 am    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  490,447,704,064 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:10 am    <DIR>          .
21/09/2023  05:10 am    <DIR>          ..
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:10 am               253 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               1 File(s)            253 bytes
               5 Dir(s)  490,447,388,672 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /t:module /out:MeFirstModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:13 am    <DIR>          .
21/09/2023  05:13 am    <DIR>          ..
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:13 am             3,379 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               2 File(s)          6,451 bytes
               5 Dir(s)  490,445,021,184 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /t:module /out:MeSecondModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /t:module /out:MeThirdModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:17 am    <DIR>          .
21/09/2023  05:17 am    <DIR>          ..
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:16 am             3,072 MeSecondModule.netmodule
21/09/2023  05:17 am             3,072 MeThirdModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:17 am             4,900 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               4 File(s)         14,116 bytes
               5 Dir(s)  490,450,305,024 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /t:library /out:AssemblyA.dll /addmodule:MeFirstModule.netmodule /addmodule:MeSecondModule.netmodule
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:25 am    <DIR>          .
21/09/2023  05:25 am    <DIR>          ..
21/09/2023  05:24 am             3,072 AssemblyA.dll
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:16 am             3,072 MeSecondModule.netmodule
21/09/2023  05:17 am             3,072 MeThirdModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:25 am             6,177 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               5 File(s)         18,465 bytes
               5 Dir(s)  490,445,553,664 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /t:library /out:AssemblyB.dll /addmodule:MeSecondModule.netmodule /addmodule:MeThirdModule.netmodule
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:26 am    <DIR>          .
21/09/2023  05:26 am    <DIR>          ..
21/09/2023  05:24 am             3,072 AssemblyA.dll
21/09/2023  05:26 am             3,072 AssemblyB.dll
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:16 am             3,072 MeSecondModule.netmodule
21/09/2023  05:17 am             3,072 MeThirdModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:25 am             6,177 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
               6 File(s)         21,537 bytes
               5 Dir(s)  490,443,845,632 bytes free

----------------------Created-------------------
class MeMainClass
{
    static void Main()
    {
        MeFirstModuleClass.Hello();
        MeSecondModuleClass.Hello();
    }
}
--------------------------------------------------
C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /r:AssemblyA.dll /out:UsesAssemblyA.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:32 am    <DIR>          .
21/09/2023  05:32 am    <DIR>          ..
21/09/2023  05:24 am             3,072 AssemblyA.dll
21/09/2023  05:26 am             3,072 AssemblyB.dll
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:16 am             3,072 MeSecondModule.netmodule
21/09/2023  05:17 am             3,072 MeThirdModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:30 am             8,685 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
21/09/2023  05:32 am             4,096 UsesAssemblyA.exe
               7 File(s)         28,141 bytes
               5 Dir(s)  490,440,060,928 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>UsesAssemblyA.exe
Helllo from module 1
Helllo from module 2
----------------------Created-------------------
class MeMainClass
{
    static void Main()
    {
        //MeFirstModuleClass.Hello();
        MeSecondModuleClass.Hello();
        MeThirdModuleClass.Hello();
    }
}
--------------------------------------------------
C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>csc /r:AssemblyB.dll /out:UsesAssemblyB.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies

21/09/2023  05:35 am    <DIR>          .
21/09/2023  05:35 am    <DIR>          ..
21/09/2023  05:24 am             3,072 AssemblyA.dll
21/09/2023  05:26 am             3,072 AssemblyB.dll
21/09/2023  05:07 am    <DIR>          bin
21/09/2023  05:12 am             3,072 MeFirstModule.netmodule
21/09/2023  05:16 am             3,072 MeSecondModule.netmodule
21/09/2023  05:17 am             3,072 MeThirdModule.netmodule
21/09/2023  05:07 am    <DIR>          obj
21/09/2023  05:34 am            10,386 Program.cs
21/09/2023  05:07 am    <DIR>          Properties
21/09/2023  05:32 am             4,096 UsesAssemblyA.exe    //ref: AssemblyA
21/09/2023  05:35 am             4,096 UsesAssemblyB.exe    //ref: AssemblyB
               8 File(s)         33,938 bytes
               5 Dir(s)  490,440,613,888 bytes free

C:\Users\sunny\source\repos\Multi-Module Assemblies\Multi-Module Assemblies>UsesAssemblyB.exe
Helllo from module 2
Helllo from module 3





  
 
 *
 *
 */


class MeMainClass
{
    static void Main()
    {
        //MeFirstModuleClass.Hello();
        MeSecondModuleClass.Hello();
        MeThirdModuleClass.Hello();
    }
}



//public class MeFirstModuleClass
//{
//    public static void Hello()
//    {
//        Console.WriteLine("Helllo from module 1");
//    }
//}

//public class MeSecondModuleClass
//{
//    public static void Hello()
//    {
//        Console.WriteLine("Helllo from module 2");
//    }
//}

//public class MeThirdModuleClass
//{
//    public static void Hello()
//    {
//        Console.WriteLine("Helllo from module 3");
//    }
//}