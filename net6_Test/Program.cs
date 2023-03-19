// See https://aka.ms/new-console-template for more information

// 顶级语句（C#9.0）
Console.WriteLine("Hello, World!");

// 全局using指令(C#10)
// global using System.IO;
// csproj启用<ImplicitUsings>enable</ImplicitUsings>

// using声明(c#8.0)
// 当代码执行离开变量作用域，自动释放对象
using SqlConnection conn = new SqlConnection("");

// 文件范围的命名空间声明(C#10)
// namespace可以省略大括号

// 可空的引用类型(C#8)
// <Nullable>enable</Nullable>
// string?

// 只能初始化赋值init
// public string Name { get; init; }

// record(记录)类型(C#9)
// record类型的类自动添加一些方法，比如构造方法、ToString方法
// 深拷贝 object with {}
