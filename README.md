# cs_like_lua


填坑进度1/100

参考项目:cslight cs-script

目标:cs_like_lua的脚本可以很容易的被C#代码调用，也可以反过来调用c#的函数
支持语法到c#7
支持伪-反射
支持dllimport->[js调用webassembly运行c/c++代码]
语法分析:gold-parser

应用场景:u3d热更新

支持脚本语言
c#
webassembly


未完成项目，无法使用

实例1
CLL_Context script = CLL_Zone.Eval
                         .ParseWithStr(@"using System;
                                     public class Script
                                     {
                                         public int Sum(int a, int b)
                                         {
                                             return a+b;
                                         }
                                     }");
var result = script['Sum'](1, 2);
Console.WriteLine(result.value);
