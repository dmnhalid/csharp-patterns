<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0d1117,50:1a1a2e,100:16213e&height=180&section=header&text=csharp-patterns&fontSize=48&fontColor=7CFFB2&fontAlignY=38&desc=C%23%20%2F%20.NET%208%20%E2%80%94%20Temel%20S%C3%B6zdiziminden%20%C4%B0leri%20Pattern%27lere&descAlignY=58&descSize=14&descColor=8892b0&animation=fadeIn" />

</div>

<br/>

> Sıfırdan başlayarak C# dilinin temellerini ve .NET 8 ekosisteminde kullanılan gerçek dünya pattern'lerini ele alan adım adım bir çalışma deposu.

---

## `> tree ./`

```
csharp-patterns/
│
├── 01-basics/              # Tipler, Kontrol & OOP
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

| # | Konu | İçerik | Kategori |
|---|------|---------|----------|
| 01 | Tipler, Kontrol & OOP | Değişkenler, if/switch, class, interface, inheritance, generics | Temel |
| 02 | LINQ & Lambda | Select, Where, GroupBy, aggregate, method chaining | Temel |
| 03 | Async / Await | Task, ValueTask, CancellationToken, parallel patterns | Temel |
| 04 | Exception & Logging | try/catch, global handler, Serilog, structured logging | Temel |
| 05 | Repository + Unit of Work | Generic repo, IUnitOfWork, transaction yönetimi | Mimari Pattern |
| 06 | Result Pattern | Result\<T\>, Error tipi, exception'sız akış kontrolü | Mimari Pattern |
| 07 | Options Pattern | IOptions\<T\>, IOptionsSnapshot, config binding, validation | Mimari Pattern |
| 08 | Fluent Validation | AbstractValidator, RuleFor, custom rule, async validation | Mimari Pattern |
| 09 | Decorator Pattern | IDecorator, pipeline davranışı, cross-cutting concern | Mimari Pattern |
| 10 | Specification Pattern | ISpecification\<T\>, CompositeSpec, EF Core entegrasyonu | Mimari Pattern |
| 11 | AutoMapper / Mapster | Profile, ProjectTo, custom converter, nested mapping | Cross-cutting |
| 12 | Middleware Pipeline | IMiddleware, request/response logging, correlation ID | Cross-cutting |
| 13 | Domain Events | IDomainEvent, dispatcher, EF Core ile publish | Cross-cutting |
| 14 | Idempotency | Idempotency key, request cache, duplicate koruması | Cross-cutting |
| 15 | Soft Delete + Audit Trail | ISoftDeletable, CreatedAt/UpdatedBy, EF Core interceptor | Cross-cutting |
| 16 | Global Exception Middleware | ProblemDetails, RFC 7807, exception → HTTP map | Cross-cutting |
| 17 | Feature Flags | IFeatureManager, env bazlı toggle, A/B test altyapısı | İleri Seviye |
| 18 | Background Jobs | Hangfire, Quartz.NET, IHostedService, cron ifadeleri | İleri Seviye |
| 19 | OpenTelemetry & Tracing | ActivitySource, trace/span, Jaeger/Zipkin entegrasyonu | İleri Seviye |
| 20 | Saga Pattern | Orchestration vs choreography, compensating transaction | İleri Seviye |

---

## `> cat progress.md`

| Kategori | İlerleme |
|----------|----------|
| 🔵 Temel | ![0/4](https://img.shields.io/badge/0%2F4-gray?style=flat-square) |
| 🟢 Mimari Pattern | ![0/6](https://img.shields.io/badge/0%2F6-gray?style=flat-square) |
| 🟣 Cross-cutting | ![0/6](https://img.shields.io/badge/0%2F6-gray?style=flat-square) |
| 🔴 İleri Seviye | ![0/4](https://img.shields.io/badge/0%2F4-gray?style=flat-square) |

---

## `> cat structure.md`

Her klasör kendi içinde aynı yapıyı takip eder:

```
XX-konu-adi/
├── README.md        # Konunun açıklaması ve notlar
├── src/             # Kaynak kodlar
│   ├── *.cs
│   └── *.csproj
└── tests/           # Varsa test dosyaları
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
