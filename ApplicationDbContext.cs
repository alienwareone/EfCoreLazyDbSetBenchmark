using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Entity1> Entity1 { get; set; }
    public DbSet<Entity2> Entity2 { get; set; }
    public DbSet<Entity3> Entity3 { get; set; }
    public DbSet<Entity4> Entity4 { get; set; }
    public DbSet<Entity5> Entity5 { get; set; }
    public DbSet<Entity6> Entity6 { get; set; }
    public DbSet<Entity7> Entity7 { get; set; }
    public DbSet<Entity8> Entity8 { get; set; }
    public DbSet<Entity9> Entity9 { get; set; }
    public DbSet<Entity10> Entity10 { get; set; }
    public DbSet<Entity11> Entity11 { get; set; }
    public DbSet<Entity12> Entity12 { get; set; }
    public DbSet<Entity13> Entity13 { get; set; }
    public DbSet<Entity14> Entity14 { get; set; }
    public DbSet<Entity15> Entity15 { get; set; }
    public DbSet<Entity16> Entity16 { get; set; }
    public DbSet<Entity17> Entity17 { get; set; }
    public DbSet<Entity18> Entity18 { get; set; }
    public DbSet<Entity19> Entity19 { get; set; }
    public DbSet<Entity20> Entity20 { get; set; }
    public DbSet<Entity21> Entity21 { get; set; }
    public DbSet<Entity22> Entity22 { get; set; }
    public DbSet<Entity23> Entity23 { get; set; }
    public DbSet<Entity24> Entity24 { get; set; }
    public DbSet<Entity25> Entity25 { get; set; }
    public DbSet<Entity26> Entity26 { get; set; }
    public DbSet<Entity27> Entity27 { get; set; }
    public DbSet<Entity28> Entity28 { get; set; }
    public DbSet<Entity29> Entity29 { get; set; }
    public DbSet<Entity30> Entity30 { get; set; }
    public DbSet<Entity31> Entity31 { get; set; }
    public DbSet<Entity32> Entity32 { get; set; }
    public DbSet<Entity33> Entity33 { get; set; }
    public DbSet<Entity34> Entity34 { get; set; }
    public DbSet<Entity35> Entity35 { get; set; }
    public DbSet<Entity36> Entity36 { get; set; }
    public DbSet<Entity37> Entity37 { get; set; }
    public DbSet<Entity38> Entity38 { get; set; }
    public DbSet<Entity39> Entity39 { get; set; }
    public DbSet<Entity40> Entity40 { get; set; }
    public DbSet<Entity41> Entity41 { get; set; }
    public DbSet<Entity42> Entity42 { get; set; }
    public DbSet<Entity43> Entity43 { get; set; }
    public DbSet<Entity44> Entity44 { get; set; }
    public DbSet<Entity45> Entity45 { get; set; }
    public DbSet<Entity46> Entity46 { get; set; }
    public DbSet<Entity47> Entity47 { get; set; }
    public DbSet<Entity48> Entity48 { get; set; }
    public DbSet<Entity49> Entity49 { get; set; }
    public DbSet<Entity50> Entity50 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=Test")
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging();
}

public sealed class Entity1
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity2
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity3
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity4
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity5
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity6
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity7
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity8
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity9
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity10
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity11
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity12
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity13
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity14
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity15
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity16
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity17
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity18
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity19
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity20
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity21
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity22
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity23
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity24
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity25
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity26
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity27
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity28
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity29
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity30
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity31
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity32
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity33
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity34
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity35
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity36
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity37
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity38
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity39
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity40
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity41
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity42
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity43
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity44
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity45
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity46
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity47
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity48
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity49
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}

public sealed class Entity50
{
    public int Id { get; private set; }
    public required string Property1 { get; set; }
    public required string Property2 { get; set; }
    public required string Property3 { get; set; }
}