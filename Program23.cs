using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CacheResultAttribute : Attribute { }

public class CacheManager
{
    private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();

    public static bool TryGetCachedResult(MethodInfo method, object[] args, out object result)
    {
        var key = GenerateCacheKey(method, args);
        return cache.TryGetValue(key, out result);
    }

    public static void CacheResult(MethodInfo method, object[] args, object result)
    {
        var key = GenerateCacheKey(method, args);
        cache[key] = result;
    }

    private static string GenerateCacheKey(MethodInfo method, object[] args)
    {
        var methodName = method.DeclaringType.FullName + "." + method.Name;
        var arguments = string.Join(",", args.Select(a => a != null ? a.ToString() : "null"));
        return methodName + "(" + arguments + ")";
    }
}

public class ExpensiveComputation
{
    [CacheResult]
    public int Compute(int x, int y)
    {
        Console.WriteLine($"Computing ExpensiveComputation({x}, {y})...");
        return x * y;
    }
}

public class Program12
{
    public static void Main(string[] args)
    {
        var computation = new ExpensiveComputation();

        InvokeWithCaching(computation, nameof(computation.Compute), new object[] { 2, 3 });
        InvokeWithCaching(computation, nameof(computation.Compute), new object[] { 2, 3 });
        InvokeWithCaching(computation, nameof(computation.Compute), new object[] { 3, 2 });
        InvokeWithCaching(computation, nameof(computation.Compute), new object[] { 2, 3 });
    }

    public static void InvokeWithCaching(object instance, string methodName, object[] args)
    {
        var method = instance.GetType().GetMethod(methodName);
        var attribute = method.GetCustomAttribute<CacheResultAttribute>();

        if (attribute != null)
        {
            if (CacheManager.TryGetCachedResult(method, args, out var cachedResult))
            {
                Console.WriteLine("Returning cached result for " + methodName);
                Console.WriteLine("Result: " + cachedResult);
                return;
            }

            var result = method.Invoke(instance, args);
            CacheManager.CacheResult(method, args, result);

            Console.WriteLine("Result: " + result);
        }
        else
        {
            var result = method.Invoke(instance, args);
            Console.WriteLine("Result: " + result);
        }
    }
}