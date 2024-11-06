# 1. Allgemeine Informationen

## **1. Projekte** 

In der **ApiDashboard Solution** existieren folgende **eigenständige Projekte**, welche
miteinander verknüft sind.

| Projektname        | Projekttyp                                                       | Stichworte                         |
|:-------------------|:----------------------------------------------------------------|:------------------------------------|
| APIDashboard       | ASP.NET Core Web API                                             | Backend, RestfulAPI, Swagger       |
| DataAccess         | Class Library                                                    | Backend, Dapper                    |
| Database           | SQL-Server Projekt                                               | Backend, SQL, Dapper               |
| Frontend           | Syncfusion Blazor Template Studio (Blazor Render mode: Server)   | Frontend, Blazor Server-Application|

- **Backend**: Läuft auf `http://localhost:5000`
- **Frontend**: Läuft auf `http://localhost:5001`



## 2. **Datenbanken**

<div style="border: 1px solid red; padding: 10px; background-color: #f8d7da; color: #721c24;">
  <strong>Dieser Abschnitt ist noch nicht vollständig und wird laufend angepasst.</strong> 
</div>

### Herunterladen von SQL Server Management Studio (SSMS)

1. Download: https://aka.ms/ssmsfullsetup
2. Database-Name: `ApiDashboardDB`
3. Tabelle `User`.

## Connection String anpassen

In `appsettings.json` -> Replace the Connection String

Example:

```c#
 "ConnectionStrings": {
   "Default": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApiDashboardDB;Integrated Security=True;Connect Timeout=60;"
 }
```

## 3. **Abschnitt**

In progress