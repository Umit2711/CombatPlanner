# 🥋 Combat Planner

**Combat Planner** ist eine Full-Stack Webanwendung zur strukturierten Planung, Dokumentation und Analyse von MMA-Trainingscamps. Kämpfer können Trainingseinheiten erfassen, Tagesnotizen machen, Gewicht tracken und Fortschrittsziele festlegen.

## 🚀 Ziel
Eine App, die es Kampfsportlern ermöglicht, ihr Training wie ein Profi zu strukturieren – mit Fokus auf Wochenübersicht, Tagesansicht und langfristige Camp-Ziele.

## ⚙️ Tech Stack

| Bereich       | Technologie               |
|---------------|----------------------------|
| Backend       | .NET 9 (ASP.NET Core Web API) |
| Frontend      | Blazor WebAssembly         |
| Authentifizierung | ASP.NET Core Identity + JWT |
| Datenbank     | SQL Server + EF Core       |
| Architektur   | Clean Architecture         |
| Tests         | xUnit, Moq, bUnit          |

## 📦 Projektstruktur

- `CombatPlanner.API/` – API Layer mit Controllern und Middleware
- `CombatPlanner.Application/` – UseCases, Services, Interfaces
- `CombatPlanner.Domain/` – Entities und Kernlogik
- `CombatPlanner.Infrastructure/` – EF Core, Identity, DB
- `CombatPlanner.Client/` – Blazor Frontend
- `tests/` – Unit- und Komponententests

## 🛠 Setup (in Entwicklung)
```bash
git clone https://github.com/dein-user/combat-planner.git
cd CombatPlanner
dotnet build
```

## 🧪 Tests ausführen
```bash
dotnet test
```

## 📌 Features (MVP)
- Benutzer-Login & Registrierung
- Trainingsplan (Wochenansicht)
- Tagesnotizen & Gewichtstracking
- Zielverfolgung

## 🧱 Architektur
Clean Architecture: Trennung von Domäne, Anwendung, Infrastruktur & UI

## 📝 Lizenz
MIT License – siehe LICENSE Datei.
