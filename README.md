<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0d1117,50:1a1a2e,100:16213e&height=180&section=header&text=csharp-patterns&fontSize=48&fontColor=7CFFB2&fontAlignY=38&desc=C%23%20%2F%20.NET%208%20%E2%80%94%20From%20Fundamentals%20to%20Advanced%20Patterns&descAlignY=58&descSize=14&descColor=8892b0&animation=fadeIn" />

</div>

<br/>

> A step-by-step study repository covering C# fundamentals and real-world patterns used in the .NET 8 ecosystem.

---

## `> tree ./`

```
csharp-patterns/
│
├── 01-basics/              # Types, Control Flow & OOP
├── 02-linq-lambda/         # LINQ & Lambda
├── 03-async-await/         # Async / Await
├── 04-exception-logging/   # Exception & Logging
│
├── 05-repository-uow/      # Repository + Unit of Work
├── 06-result-pattern/      # Result Pattern
├── 07-options-pattern/     # Options Pattern
├── 08-fluent-validation/   # Fluent Validation
├── 09-decorator-pattern/   # Decorator Pattern
├── 10-specification/       # Specification Pattern
│
├── 11-automapper/          # AutoMapper / Mapster
├── 12-middleware/          # Middleware Pipeline
├── 13-domain-events/       # Domain Events
├── 14-idempotency/         # Idempotency
├── 15-soft-delete-audit/   # Soft Delete + Audit Trail
├── 16-global-exception/    # Global Exception Middleware
│
├── 17-feature-flags/       # Feature Flags
├── 18-background-jobs/     # Background Jobs
├── 19-opentelemetry/       # OpenTelemetry & Tracing
└── 20-saga-pattern/        # Saga Pattern
```

---

## `> cat roadmap.md`

| # | Topic | Content | Category |
|---|-------|---------|----------|
| 01 | Types, Control Flow & OOP | Variables, if/switch, class, interface, inheritance, generics | Fundamentals |
| 02 | LINQ & Lambda | Select, Where, GroupBy, aggregate, method chaining | Fundamentals |
| 03 | Async / Await | Task, ValueTask, CancellationToken, parallel patterns | Fundamentals |
| 04 | Exception & Logging | try/catch, global handler, Serilog, structured logging | Fundamentals |
| 05 | Repository + Unit of Work | Generic repo, IUnitOfWork, transaction management | Architecture Pattern |
| 06 | Result Pattern | Result\<T\>, Error type, exception-free flow control | Architecture Pattern |
| 07 | Options Pattern | IOptions\<T\>, IOptionsSnapshot, config binding, validation | Architecture Pattern |
| 08 | Fluent Validation | AbstractValidator, RuleFor, custom rule, async validation | Architecture Pattern |
| 09 | Decorator Pattern | IDecorator, pipeline behavior, cross-cutting concern | Architecture Pattern |
| 10 | Specification Pattern | ISpecification\<T\>, CompositeSpec, EF Core integration | Architecture Pattern |
| 11 | AutoMapper / Mapster | Profile, ProjectTo, custom converter, nested mapping | Cross-cutting |
| 12 | Middleware Pipeline | IMiddleware, request/response logging, correlation ID | Cross-cutting |
| 13 | Domain Events | IDomainEvent, dispatcher, publish with EF Core | Cross-cutting |
| 14 | Idempotency | Idempotency key, request cache, duplicate protection | Cross-cutting |
| 15 | Soft Delete + Audit Trail | ISoftDeletable, CreatedAt/UpdatedBy, EF Core interceptor | Cross-cutting |
| 16 | Global Exception Middleware | ProblemDetails, RFC 7807, exception → HTTP mapping | Cross-cutting |
| 17 | Feature Flags | IFeatureManager, env-based toggle, A/B test setup | Advanced |
| 18 | Background Jobs | Hangfire, Quartz.NET, IHostedService, cron expressions | Advanced |
| 19 | OpenTelemetry & Tracing | ActivitySource, trace/span, Jaeger/Zipkin integration | Advanced |
| 20 | Saga Pattern | Orchestration vs choreography, compensating transaction | Advanced |

---

## `> cat progress.md`

| Category | Progress |
|----------|----------|
| 🔵 Fundamentals | ![0/4](https://img.shields.io/badge/0%2F4-gray?style=flat-square) |
| 🟢 Architecture Pattern | ![0/6](https://img.shields.io/badge/0%2F6-gray?style=flat-square) |
| 🟣 Cross-cutting | ![0/6](https://img.shields.io/badge/0%2F6-gray?style=flat-square) |
| 🔴 Advanced | ![0/4](https://img.shields.io/badge/0%2F4-gray?style=flat-square) |

---

## `> cat structure.md`

Each folder follows the same structure:

```
XX-topic-name/
├── README.md        # Topic explanation and notes
├── src/             # Source code
│   ├── *.cs
│   └── *.csproj
└── tests/           # Test files (optional)
    └── *.Tests.csproj
```

---

## `> cat stack.txt`

```
Runtime   : .NET 8
Language  : C# 12
ORM       : Entity Framework Core 8
Validation: FluentValidation
Mapping   : AutoMapper / Mapster
Testing   : xUnit + Moq + FluentAssertions
Logging   : Serilog
Jobs      : Hangfire / Quartz.NET
Tracing   : OpenTelemetry
DB        : PostgreSQL (Docker)
```

---

<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:16213e,50:1a1a2e,100:0d1117&height=100&section=footer&animation=fadeIn" />

<sub><code>// built step by step — dmnhalid</code></sub>

</div>
