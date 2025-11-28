using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

public sealed class ApplicationDbContextLazy : DbContext
{
    public DbSet<EntityLazy1> EntityLazy1 => field ??= Set<EntityLazy1>();
    public DbSet<EntityLazy2> EntityLazy2 => field ??= Set<EntityLazy2>();
    public DbSet<EntityLazy3> EntityLazy3 => field ??= Set<EntityLazy3>();
    public DbSet<EntityLazy4> EntityLazy4 => field ??= Set<EntityLazy4>();
    public DbSet<EntityLazy5> EntityLazy5 => field ??= Set<EntityLazy5>();
    public DbSet<EntityLazy6> EntityLazy6 => field ??= Set<EntityLazy6>();
    public DbSet<EntityLazy7> EntityLazy7 => field ??= Set<EntityLazy7>();
    public DbSet<EntityLazy8> EntityLazy8 => field ??= Set<EntityLazy8>();
    public DbSet<EntityLazy9> EntityLazy9 => field ??= Set<EntityLazy9>();
    public DbSet<EntityLazy10> EntityLazy10 => field ??= Set<EntityLazy10>();
    public DbSet<EntityLazy11> EntityLazy11 => field ??= Set<EntityLazy11>();
    public DbSet<EntityLazy12> EntityLazy12 => field ??= Set<EntityLazy12>();
    public DbSet<EntityLazy13> EntityLazy13 => field ??= Set<EntityLazy13>();
    public DbSet<EntityLazy14> EntityLazy14 => field ??= Set<EntityLazy14>();
    public DbSet<EntityLazy15> EntityLazy15 => field ??= Set<EntityLazy15>();
    public DbSet<EntityLazy16> EntityLazy16 => field ??= Set<EntityLazy16>();
    public DbSet<EntityLazy17> EntityLazy17 => field ??= Set<EntityLazy17>();
    public DbSet<EntityLazy18> EntityLazy18 => field ??= Set<EntityLazy18>();
    public DbSet<EntityLazy19> EntityLazy19 => field ??= Set<EntityLazy19>();
    public DbSet<EntityLazy20> EntityLazy20 => field ??= Set<EntityLazy20>();
    public DbSet<EntityLazy21> EntityLazy21 => field ??= Set<EntityLazy21>();
    public DbSet<EntityLazy22> EntityLazy22 => field ??= Set<EntityLazy22>();
    public DbSet<EntityLazy23> EntityLazy23 => field ??= Set<EntityLazy23>();
    public DbSet<EntityLazy24> EntityLazy24 => field ??= Set<EntityLazy24>();
    public DbSet<EntityLazy25> EntityLazy25 => field ??= Set<EntityLazy25>();
    public DbSet<EntityLazy26> EntityLazy26 => field ??= Set<EntityLazy26>();
    public DbSet<EntityLazy27> EntityLazy27 => field ??= Set<EntityLazy27>();
    public DbSet<EntityLazy28> EntityLazy28 => field ??= Set<EntityLazy28>();
    public DbSet<EntityLazy29> EntityLazy29 => field ??= Set<EntityLazy29>();
    public DbSet<EntityLazy30> EntityLazy30 => field ??= Set<EntityLazy30>();
    public DbSet<EntityLazy31> EntityLazy31 => field ??= Set<EntityLazy31>();
    public DbSet<EntityLazy32> EntityLazy32 => field ??= Set<EntityLazy32>();
    public DbSet<EntityLazy33> EntityLazy33 => field ??= Set<EntityLazy33>();
    public DbSet<EntityLazy34> EntityLazy34 => field ??= Set<EntityLazy34>();
    public DbSet<EntityLazy35> EntityLazy35 => field ??= Set<EntityLazy35>();
    public DbSet<EntityLazy36> EntityLazy36 => field ??= Set<EntityLazy36>();
    public DbSet<EntityLazy37> EntityLazy37 => field ??= Set<EntityLazy37>();
    public DbSet<EntityLazy38> EntityLazy38 => field ??= Set<EntityLazy38>();
    public DbSet<EntityLazy39> EntityLazy39 => field ??= Set<EntityLazy39>();
    public DbSet<EntityLazy40> EntityLazy40 => field ??= Set<EntityLazy40>();
    public DbSet<EntityLazy41> EntityLazy41 => field ??= Set<EntityLazy41>();
    public DbSet<EntityLazy42> EntityLazy42 => field ??= Set<EntityLazy42>();
    public DbSet<EntityLazy43> EntityLazy43 => field ??= Set<EntityLazy43>();
    public DbSet<EntityLazy44> EntityLazy44 => field ??= Set<EntityLazy44>();
    public DbSet<EntityLazy45> EntityLazy45 => field ??= Set<EntityLazy45>();
    public DbSet<EntityLazy46> EntityLazy46 => field ??= Set<EntityLazy46>();
    public DbSet<EntityLazy47> EntityLazy47 => field ??= Set<EntityLazy47>();
    public DbSet<EntityLazy48> EntityLazy48 => field ??= Set<EntityLazy48>();
    public DbSet<EntityLazy49> EntityLazy49 => field ??= Set<EntityLazy49>();
    public DbSet<EntityLazy50> EntityLazy50 => field ??= Set<EntityLazy50>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=TestLazy")
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging();
}

public sealed class EntityLazy1
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy2
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy3
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy4
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy5
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy6
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy7
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy8
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy9
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy10
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy11
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy12
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy13
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy14
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy15
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy16
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy17
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy18
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy19
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy20
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy21
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy22
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy23
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy24
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy25
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy26
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy27
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy28
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy29
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy30
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy31
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy32
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy33
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy34
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy35
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy36
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy37
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy38
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy39
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy40
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy41
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy42
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy43
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy44
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy45
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy46
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy47
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy48
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy49
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class EntityLazy50
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}