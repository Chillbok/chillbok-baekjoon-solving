using System;
using System.Reflection;

if (args.Length == 0)
{
    Console.WriteLine("문제 번호를 언급해주세요.");
    Console.WriteLine("사용법: dotnet run <문제번호>");
    return;
}

string problemNumber = args[0];
string typeName = $"Csharp.Problems.Problem{problemNumber}";

try
{
    //문제 번호에 해당하는 타입 찾기
    Type? problemType = Assembly.GetExecutingAssembly().GetType(typeName);

    if (problemType == null)
    {
        Console.WriteLine($"Error: 문제 {problemNumber}번 존재하지 않음.");
        return;
    }

    //문제 클래스의 인스턴스를 생성
    object? problemInstance = Activator.CreateInstance(problemType);
    if (problemInstance == null)
    {
        Console.WriteLine($"Error: {typeName}이라는 인스턴스 생성 불가능");
        return;
    }

    //'Solve' 메서드 찾기
    MethodInfo? solveMethod = problemType.GetMethod("Solve");
    if (solveMethod == null)
    {
        Console.WriteLine($"Error: 'Solve' 메서드 클래스 '{typeName}'에서 찾을 수 없음");
        return;
    }

    //'Solve' 메서드 호출
    solveMethod.Invoke(problemInstance, null);
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}