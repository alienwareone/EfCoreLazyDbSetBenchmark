using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;

/*

// * Summary *

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.7171)
Intel Core Ultra 9 185H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2


| Method              | Mean         | Error      | StdDev     | Gen0   | Gen1   | Allocated |
|-------------------- |-------------:|-----------:|-----------:|-------:|-------:|----------:|
| Eager               |  3,197.44 ns |  20.540 ns |  19.213 ns | 0.8163 | 0.0229 |   10272 B |
| Eager_access        |  3,250.08 ns |  63.279 ns |  92.753 ns | 0.8163 | 0.0229 |   10272 B |
| Eager_access_scoped |     24.20 ns |   0.125 ns |   0.098 ns |      - |      - |         - |
| Lazy                |    302.95 ns |   2.579 ns |   2.412 ns | 0.0973 |      - |    1224 B |
| Lazy_access         | 23,479.49 ns | 157.998 ns | 140.061 ns | 4.1809 | 0.2747 |   52815 B |
| Lazy_access_scoped  |     23.17 ns |   0.103 ns |   0.092 ns |      - |      - |         - |

*/

[MemoryDiagnoser(true)]
// [ShortRunJob]
public class BenchmarkWithDependencyInjection
{
    private IServiceProvider _serviceProvider = null!;
    private IServiceScope _serviceScope = null!;

    [GlobalSetup]
    public void Setup()
    {
        _serviceProvider = new ServiceCollection()
            .AddDbContext<ApplicationDbContext>()
            .AddDbContext<ApplicationDbContextLazy>()
            .BuildServiceProvider();

        _serviceScope = _serviceProvider.CreateScope();

        var eager = _serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        _ = eager.Entity1;
        _ = eager.Entity2;
        _ = eager.Entity3;

        var lazy = _serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContextLazy>();
        _ = lazy.EntityLazy1;
        _ = lazy.EntityLazy2;
        _ = lazy.EntityLazy3;
    }

    [Benchmark]
    public void Eager()
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    }

    [Benchmark]
    public void Eager_access()
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var dbSet1 = context.Entity1;
        var dbSet2 = context.Entity2;
        var dbSet3 = context.Entity3;
    }

    [Benchmark]
    public void Eager_access_scoped()
    {
        var context = _serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var dbSet1 = context.Entity1;
        var dbSet2 = context.Entity2;
        var dbSet3 = context.Entity3;
    }

    [Benchmark]
    public void Lazy()
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContextLazy>();
    }

    [Benchmark]
    public void Lazy_access()
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContextLazy>();
        var dbSet1 = context.EntityLazy1;
        var dbSet2 = context.EntityLazy2;
        var dbSet3 = context.EntityLazy3;
    }

    [Benchmark]
    public void Lazy_access_scoped()
    {
        var context = _serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContextLazy>();
        var dbSet1 = context.EntityLazy1;
        var dbSet2 = context.EntityLazy2;
        var dbSet3 = context.EntityLazy3;
    }
}