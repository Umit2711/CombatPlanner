
# 🧪 Development Workflow – Combat Planner

Dieser Workflow zeigt, wie du professionell mit GitHub arbeitest – mit Branches, Issues und dem Project Board.

---

## 🧩 1. Workflow-Übersicht

- 🔧 **Erstelle ein Issue** für jede Aufgabe (z. B. „Wochenansicht UI erstellen“)
- 🌿 **Lege einen Branch an**, z. B. `feature/wochenansicht-ui`
- 💻 **Entwickle lokal**, committe mit sinnvollen Nachrichten
- ⬆️ **Push den Branch** und öffne einen **Pull Request**
- 🧹 **Merge** nach `main`, verschiebe die Issue-Karte auf „Done“

---

## 🌿 2. Branch-Namenskonvention

| Zweck         | Prefix      | Beispiel                          |
|---------------|-------------|-----------------------------------|
| Neues Feature | `feature/`  | `feature/weight-tracking`         |
| Bugfix        | `fix/`      | `fix/login-error`                 |
| Refactor      | `refactor/` | `refactor/user-service-cleanup`   |
| Hotfix        | `hotfix/`   | `hotfix/crash-on-startup`         |

Nur Kleinbuchstaben, keine Umlaute oder Sonderzeichen!

---

## 🗂️ 3. Commits

```bash
git add .
git commit -m "feat: implementiere Wochenansicht (#12)"
```

| Prefix   | Bedeutung                 |
|----------|---------------------------|
| feat     | Neues Feature              |
| fix      | Fehlerbehebung             |
| chore    | Konfiguration, Setup       |
| docs     | Dokumentation              |
| refactor | Code-Umstrukturierung      |
| test     | Tests hinzufügen           |

---

## 🔁 4. Pull Request (PR)

1. Erstelle einen PR gegen `main`
2. Nutze die Beschreibung:
   - Was wurde gemacht?
   - Warum?
   - Was ist noch offen?
3. Verlinke das Issue:  
   `Closes #12`

---

## 🗃️ 5. GitHub Project Board nutzen

- Spalte `Todo` → `In Progress` → `Done`
- Verknüpfe das Issue mit dem Board
- Bewege es nach Abschluss in `Done`

---

## 📌 Beispielablauf

```bash
# Neues Feature: Trainingsformular
git checkout -b feature/training-form

# Entwicklung & Commit
git commit -m "feat: Trainingsformular in Blazor erstellt (#7)"

# Push & PR
git push origin feature/training-form
```

---

> Halte deine Branches und Commits sauber – du arbeitest wie ein Profi!
