# **Code-Dokumentation: Interaktives Dashboard**

## **Inhaltsverzeichnis**
1. [Run Projekt](#run-project)
1. [Projekteigenschaften](#projektkonfiguration)
2. [Projektstrukturen](#projektstrukturen)
3. [Datenbankkonfiguration](#datenbankkonfiguration)
    - [Installaton SQL Server Express 2022](#installaton-sql-server)
	- [Datenbankscripts ausführen](#db-publishen)

---


## 1. **How to run this project** <a name="run-project"></a>  

1. Repository Klonen ``` https://github.com/espas-bi-it/api-dashboard.git ```

2. [Publish Database and Tables](#datenbankkonfiguration)

3. Projekt starten ``` dotnet run --launch-profile https  ```  oder direkt in VS. 


## 2. **Projekteigenschaften** <a name="projektkonfiguration"></a>  

Die Solution **APIDashboard** besteht aus folgenden **eigenständige Projekten**.

-  ### **ApiDashboard-Projekt**:
	- **ASP.NET Core Web API**
	- **Framework**: .NET 8.0 (langfristiger Support)
	- **Authentifizierung**: Kein Authentifizierungstyp konfiguriert
	- **HTTPS**: Für HTTPS konfiguriert
	- **OpenAPI-Unterstützung**: Aktiviert
	- **Controller**: Verwendung von Controllern zur Handhabung von API-Anfragen
	- **Backend**: Läuft auf `http://localhost:5000`

-	### **Frontend-Projekt**:
	- **ASP.NET MVC UI**
	- **Framework**: .NET 8.0 (langfristiger Support)
	- **Authentifizierung**: Kein Authentifizierungstyp konfiguriert
	- **HTTPS**: Für HTTPS konfiguriert
	- **Blazor**: Server render mode
	- **Extensions**: [Syncfusion](https://ej2.syncfusion.com/aspnetmvc/documentation/introduction?_gl=1*101euba*_gcl_au*MTE5Njg5MTMwNS4xNzMwNjM3NDg4*_ga*Nzk0MTc2NTk1LjE3MzA1OTM0NTM.*_ga_41J4HFMX1J*MTczMTA5NDE1NC4xMy4wLjE3MzEwOTQxNTQuMC4wLjA. "Optionaler Linktitel") Web Template Studio mit [Bootstrap 5](https://getbootstrap.com/docs/5.0/getting-started/introduction/ "Bootstrap 5")
	-  **Frontend**: Läuft auf `http://localhost:5001`

-	### **DataAccess-Projekt**:
	- Class-Libray

-	### **Database-Projekt**:
	- SQL-Server Projekt


## 3. **Projektstrukturen** <a name="projektstrukturen"></a>  

 ### **ApiDashboard:** :arrow_down:

```plaintext
/api-dashboard
│
├── /ApiDashboard			-> Backend (ASP.NET Core)
│   ├── /Controllers			-> API-Controller
│   │    └── UserController		-> Beispiel-Controller
│   ├── /Properties			-> Projekteigenschaften
│   │    └── launchSettings.json	-> Konfiguriert Startoptionen für die Entwicklung
│   ├── ApiDasboad.csproj		-> Projektdatei für das Backend
│   ├── ApiDasboard-csproj.user		-> Weitere Projektdatei
│   ├── appsettings.Development.json	-> Entwicklungs-Konfiguration
│   ├── appsettings.json		-> Allgemeine Konfiguration
│   └── Program.cs			-> Einstiegspunkt der Anwendung 
│   └── ApiDashboard.sln 		-> Visual Studio-Lösung

```

In der Vorlage habe ich die autoamtisch generierte ApiDashboard.http entfernt. Diese .http Datei ist zum testen der Api. Wir haben mit Swagger bereits alle Möglichkeiten http-request zu testen.



### **Frontend:** :arrow_down:

```plaintext
/api-dashboard
│
├── /Frontend				-> Frontend (ASP.NET MVC UI)
│   ├── /Components			
│   │    └── Layout			-> Ordner für HTML-Struktur und Stylesheets
│   │    └── Pages			
│   │        └── ApiDashboard.razor	-> Dashboard-View (/apidashboard)
│   │        └── Index.razor		-> Syncfusion Beispiel Komponenten
│   │    └── _Imports.razor		-> Zentrale Anweisungen/Direktiven für alle Razor-Komponenten
│   │    └── App.razor			-> Definiert Routing und Layout der Anwendung
│   │    └── Routes.razor		-> Definiert das Routing zu Razor-Komponenten
│   ├── /Data				-> Enthält Klassen und Dienste für Datenzugriff und -verwaltung
│   ├── /Properties			-> Projekteigenschaften
│   │    └── launchSettings.json	-> Konfiguriert Startoptionen für die Entwicklung
│   ├── /wwwroot			-> Enthält statische Dateien für die Anwendung
│   ├── appsettings.Development.json	-> Entwicklungs-Konfiguration
│   ├── appsettings.json		-> Allgemeine Konfiguration
│   ├── Frontend.csproj			-> Projektdatei für das Frontend
│   ├── Frontend.csproj.user		-> Weitere Projektdatei
│   └── Program.cs			-> Einstiegspunkt der Anwendung

```

## Syncfusion

Die Erweiterung **Syncfusion** ist installiert.

 <img src="https://bi-it-ws.github.io/doc-img/syncfusion_1.jpg" width="700" />


- https://blazor.syncfusion.com/demos/
- https://blazor.syncfusion.com/documentation/
- https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples


Syncfusion Blazor Template Studio ist kostenlos verfügbar und kann für Testprojekte verwendet werden.
Du kannst es nutzen, um Blazor-Anwendungen mit den vorgefertigten Syncfusion-Komponenten zu erstellen, einschließlich der Implementierung eines Logins.
Allerdings musst du beachten, dass Syncfusion eine Lizenzierung für ihre Komponenten hat. Wenn du die NuGet-Pakete von Syncfusion verwendest, musst du einen Lizenzschlüssel registrieren, auch wenn du die Testversion nutzt. Für Testprojekte und Evaluierungen ist dies jedoch in der Regel problemlos möglich.

### Installierte Packete:

* syncfusion.blazor.bulletchart\27.1.58
* syncfusion.blazor.buttons\27.1.58
* syncfusion.blazor.calendars\27.1.58
* syncfusion.blazor.cards\27.1.58
* syncfusion.blazor.charts\27.1.58
* syncfusion.blazor.dataform\27.1.58
* syncfusion.blazor.dropdowns\27.1.58
* syncfusion.blazor.grid\27.1.58
* syncfusion.blazor.inplaceeditor\27.1.58
* syncfusion.blazor.inputs\27.1.58
* syncfusion.blazor.kanban\27.1.58
* syncfusion.blazor.layouts\27.1.58
* syncfusion.blazor.lists\27.1.58
* syncfusion.blazor.navigations\27.1.58
* syncfusion.blazor.notifications\27.1.58
* syncfusion.blazor.pdfviewer\27.1.58
* syncfusion.blazor.pdfviewerserver.windows\27.1.58
* syncfusion.blazor.popups\27.1.58
* syncfusion.blazor.progressbar\27.1.58
* syncfusion.blazor.querybuilder\27.1.58
* syncfusion.blazor.richtexteditor\27.1.58
* syncfusion.blazor.spinner\27.1.58
* syncfusion.blazor.splitbuttons\27.1.58
* syncfusion.blazor.stockchart\27.1.58
* syncfusion.blazor.themes\27.1.58
* syncfusion.blazor.treegrid\27.1.58
* syncfusion.pdf.net.core\27.1.58

Man kann weiter NuGet Packete hinzufügen.

### **DataAccess:** :arrow_down:

```plaintext
/api-dashboard
│
├── /DataAccess				-> Backend (Class Library)
│   ├── /Data				-> Enthält Interfaces für den Datenzugriff und die Datenverwaltung
│   ├── /DBAccess			-> Führt Datenbankoperationen mit Dapper aus, lädt und speichert Daten über gespeicherte Prozeduren
│   ├── /Models				-> Ordner für Models - Definiert eine Datenstruktur mit spezifischen Eigenschaften
│   ├── /Services			-> Lorem Ipsum
│   ├── DataAccess.csproj		-> Projektdatei für das Backend


```

### **Database**: :arrow_down:

```plaintext
/api-dashboard
│
├── /Database	         -> Backend (SQL-Server Project)
│   ├── /Controllers     -> Lorem Ipsum
│   ├── /Properties      -> Lorem Ipsum
│   ├── Database.csproj	 -> Projektdatei für das Backend

```

## 4. **Publish Database and Tables** <a name="datenbankkonfiguration"></a>  

 > ⚠️ **Warnung:** Dieser Abschnitt wird bei Bedarf noch angepasst.

### Microsoft® SQL Server® 2022 Express installieren: <a name="installaton-sql-server"></a>  

Die SQL-Skripte laufen nur auf SQL-Server 2022. Wir müssen daher von SQL-Server 2019 auf die neuere Version upgraden.

1. [Microsoft® SQL Server® 2022 Express](https://www.microsoft.com/de-de/download/details.aspx?id=104781 "Download") herunterladen und installieren

2. **Installationstyp:** "Benutzerdefiniert" auswählen

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_1.png" width="700" />

3. Diese Meldung mit „Ja“ bestätigen

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_2.png" width="700" />

4. Standardeinstellungen belassen und „Installieren“

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_3.png" width="700" />

5. **Installation**: „New SQL Server standalone installation…“  auswählen

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_4.png" width="700" />

6. **License Terms**: „I accept…“ anklicken und dann auf  „Next“ 

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_5.png" width="700" />

7. **Install Rules** So lassen und auf „Next“

<img src="https://bi-it-ws.github.io/doc-img/sqlserver_6.png" width="700" />

8. **Azure Extension for SQL Server**: Checkbox deaktivieren und auf "Next"
 
 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_7.png" width="700" />

9. **Feature Selection**: Bei **Shared Features** „LocalDB“ aktivieren und „Next“

 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_8.png" width="700" />

10. **Feature Rules**: Falls nicht bereits automatisch geschen auf „Next“
	
11. **Instance Configuration:** Default instance“ auswählen und „Next“
	
 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_9.png" width="700" />

12. **Server Configuration:** 
	
 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_10.png" width="700" />

13. **Database Engine Configuration:** Auf "Next"
	
 <img src="https://bi-it-ws.github.io/doc-img/sqlserver_11.png" width="700" />

15. **Installation Progress** Startet automatisch
16.	**Complete:** Auf allfällige Fehler überprüfen und dann „Close“ 

### Datenbank publishen: <a name="db-publishen"></a>  

Bitte sicherstellen dass ihr das api-dashboard Repository geklont habt, auf dem aktuellen Stand sind (Kann mit git status überprüft werden) und dass Sie sich in Ihrem Branch befinden (kann mit git branch gemacht werden)

1. ❗Visual Studio als **Administrator** ausführen
2. ❗Das Repository `git clone https://github.com/espas-bi-it/api-dashboard.git` in das Verzeichnis **"C:\Users\benutzername\source\repos"** (oder ein anderes Verzeichnis, Hauptsache im "C:\Users\benutzername\") klonen
Oder den entsprechenden Ordner auswählen wenn das Repo bereits geklont wurde.
3. ❗In Ihren Branch wechseln: `git checkout dev_xyz`
4. ❗`git pull` ausführen und mit `git status` überprüfen ob ihr Branch auf dem aktuellesten Stand ist
3. In Visual Studio zum Projekt **"Database"**: Rechtsklick und **"Publish"** (oder Deutsch: "Veröffentlichen") auswählen

 <img src="https://bi-it-ws.github.io/doc-img/vssetup_2.png" width="400" />

4. Im Folgenden Fenster auf „Edit“

 <img src="https://bi-it-ws.github.io/doc-img/vssetup_3.png" width="400" />

5. Zum Tab „Browse/Durchsuchen“ navigieren und „Local“ aufklappen. 

 <img src="https://bi-it-ws.github.io/doc-img/vssetup_4.png" width="400" />

Es sollte eine Instanz mit dem Namen **"ZH-EDU-WSXXX"“** sichtbar sein. Diesen bitte auswählen. Bei **Encript/Verschlüsseln** auf **"Optional (False)"** umstellen
**"Test Connection"** ausführen. Wenn alles geklappt hat mit **"OK"** bestätigen.

6. Database name: **APIDashboardDB** eingeben und dann **"Publish"**

<img src="https://bi-it-ws.github.io/doc-img/vssetup_5.png" width="400" />

7. Es sollte folgender Dialog innerhalb von Visual Studio erscheinen:

<img src="https://bi-it-ws.github.io/doc-img/vssetup_6.png" width="400" />

8. In VS den SQL Server-Object-Explorer öffnen (im Menüpunkt "View", oder "Ansicht"). Die Instanz beginnend mit "ZH-EDU…." aufklappen. Hier sollte nun unter "Databeses" die ApiDashboardDB sichtbar sein

<img src="https://bi-it-ws.github.io/doc-img/vssetup_7.png" width="400" />

9. Rechtsklick auf **"ApiDashboardDB"** und auf "Eigenschaften" klicken. Bei **"Connection-String"** (oder Deutsch "Verbindungszeichenfolge") den Wert kopieren (gelb markiert)

<img src="https://bi-it-ws.github.io/doc-img/vssetup_8.png" width="400" />

10. In den `appsettings.Development.json` Dateien in den Projekten **"ApiDashboard"** und **"Frontend"** den kopierten Wert bei **"Default"** einfügen und alles abspeichern. 
	
	❗Alle Parameter nach **"Timeout=60"** müssen entfernt werden.	
	
	Beispiel:
	```c
	"ConnectionStrings": {
	"Default": "Data Source=ZH-EDU-WS078;Initial Catalog=ApiDashboardDB;Integrated Security=True;Connect Timeout=60"
	}
	```
 
> ℹ️ **Info:** Falls die Dateien `appsettings.Development.json` noch nicht existieren dann bitte eine in den jewiligen Stammverzeichnissen erstellen. Als Vorlage kann die bestehende `appsettings.json` genommen werden.
	