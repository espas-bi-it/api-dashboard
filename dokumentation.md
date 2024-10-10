# **Projekt-Dokumentation: Interaktives Dashboard**

## **Inhaltsverzeichnis**
1. [Projektbeschreibung](#projektbeschreibung)
2. [Technologie-Stack](#technologie-stack)
3. [Projektstruktur](#projektstruktur)
4. [API-Entwicklung](#api-entwicklung)
    - [API-Endpunkte](#api-endpunkte)
5. [Frontend-Entwicklung](#frontend-entwicklung)
    - [Datenvisualisierung](#datenvisualisierung)
6. [Datenbank und Dapper-Integration](#datenbank-und-dapper-integration)
7. [Docker-Containerisierung](#docker-containerisierung)
8. [Deployment auf Azure](#deployment-auf-azure)
9. [Tests und Qualitätssicherung](#tests-und-qualitätssicherung)
10. [Installationsanleitung](#installationsanleitung)

---

## **1. Projektbeschreibung** <a name="projektbeschreibung"></a>

Dieses Projekt zielt darauf ab, ein **interaktives Dashboard** zu entwickeln, das eine benutzerfreundliche Schnittstelle zur Visualisierung von Daten bietet. Es kombiniert verschiedene Datenquellen, stellt Key Performance Indicators (KPIs) dar und bietet Funktionen wie Filtern, Suchen und Sortieren.

Das Dashboard besteht aus mehreren Komponenten:
- **Backend**: RESTful API in C# (ASP.NET Core), um Daten von externen APIs abzurufen und in einer Datenbank zu speichern.
- **Frontend**: Blazor-Anwendung zur Darstellung der Daten und zur Interaktion mit dem Benutzer.
- **Datenbank**: MariaDB für die Speicherung und das Abrufen von Daten mit Dapper.
- **Docker**: Containerisierung der Anwendung zur einfachen Bereitstellung.
- **Azure**: Deployment der Anwendung in der Cloud mit Azure Container Instances oder Azure Kubernetes Service.

## **2. Technologie-Stack** <a name="technologie-stack"></a>

- **Programmiersprachen**: C# (Backend), Blazor (Frontend)
- **Frameworks**:
  - **ASP.NET Core Web API** für die API-Entwicklung
  - **Blazor** für die Benutzeroberfläche
- **Datenbank**: MariaDB
- **ORM**: Dapper
- **Containerisierung**: Docker
- **Cloud**: Microsoft Azure
- **Testing-Frameworks**: xUnit, NUnit

## **3. Projektstruktur** <a name="projektstruktur"></a>

```plaintext
/DeinProjektName
│
├── /Backend             -> API (ASP.NET Core)
│   ├── Controllers      -> API-Controller
│   ├── Models           -> Datenmodelle
│   ├── Services         -> Business-Logik
│   └── Data             -> Dapper-Implementierung für Datenbankzugriffe
│
├── /Frontend            -> UI (Blazor)
│   ├── Components       -> Blazor-Komponenten
│   └── wwwroot          -> Statische Dateien (CSS, JS, Bilder)
│
├── /Database            -> Datenbank (MariaDB)
│   └── Migrations       -> Datenbankschemata und Migrationen
│
├── /Docker              -> Docker-Konfigurationsdateien
│   ├── Dockerfile-API   -> Dockerfile für die API
│   └── Dockerfile-UI    -> Dockerfile für das Frontend
│
└── /Docs                -> Dokumentationen und ReadMe-Dateien
## **4. API-Entwicklung** <a name="api-entwicklung"></a>

Die API wurde unter Verwendung von **ASP.NET Core Web API** erstellt und befolgt die REST-Prinzipien. Sie dient dazu, Daten von externen APIs abzurufen, zu verarbeiten und in der MariaDB-Datenbank zu speichern.

### **API-Endpunkte** <a name="api-endpunkte"></a>

- **GET /api/data**: Holt Daten von einer externen API und speichert sie in der Datenbank.
- **GET /api/data/{id}**: Holt spezifische Datensätze basierend auf der ID.
- **POST /api/data**: Fügt neue Datensätze zur Datenbank hinzu.
- **PUT /api/data/{id}**: Aktualisiert bestehende Daten in der Datenbank.
- **DELETE /api/data/{id}**: Löscht einen Datensatz basierend auf der ID.

## **5. Frontend-Entwicklung** <a name="frontend-entwicklung"></a>

Das Frontend wurde mit **Blazor** entwickelt, um eine interaktive Benutzeroberfläche zu bieten, die in Echtzeit Daten anzeigt. Die wichtigsten Komponenten beinhalten:

- **DashboardComponent**: Stellt KPIs, Diagramme und Tabellen dar.
- **FilterComponent**: Ermöglicht das Filtern und Sortieren von Daten.
- **ChartComponent**: Verwendet eine Visualisierungsbibliothek (z. B. Chart.js oder Syncfusion Blazor) zur Darstellung von Diagrammen.

### **Datenvisualisierung** <a name="datenvisualisierung"></a>

- **Bibliothek**: Für die Diagramme wird eine JavaScript-basierte Visualisierungsbibliothek verwendet, die in Blazor integriert ist.
- **Diagrammtypen**: Linien-, Balken-, Kreisdiagramme und andere grafische Darstellungen zur Anzeige von KPIs und Trends.

## **6. Datenbank und Dapper-Integration** <a name="datenbank-und-dapper-integration"></a>

Die **MariaDB**-Datenbank speichert alle relevanten Daten, die über die API abgerufen werden. Für den Zugriff auf die Datenbank wird **Dapper** verwendet, ein leichtes ORM für schnelle und effiziente Abfragen.

- **Verbindung zur Datenbank**: Die API verbindet sich zur MariaDB-Datenbank mittels einer Verbindungsschicht, die mit Dapper erstellt wurde.
- **Datenabfragen**: CRUD-Operationen werden durch Dapper ausgeführt, um Daten effizient zu speichern, abzurufen und zu aktualisieren.

## **7. Docker-Containerisierung** <a name="docker-containerisierung"></a>

Sowohl das Backend als auch das Frontend werden in **Docker-Containern** ausgeführt, was die Bereitstellung und Skalierung der Anwendung vereinfacht.

### **Dockerfiles**:
- **Backend Dockerfile**:
  - Erstellt ein Container-Image für die API.
- **Frontend Dockerfile**:
  - Erstellt ein Container-Image für die Blazor-Anwendung.

### **Docker Compose**:
- Eine `docker-compose.yml`-Datei wird verwendet, um die verschiedenen Services (API, UI und Datenbank) zu orchestrieren.

## **8. Deployment auf Azure** <a name="deployment-auf-azure"></a>

Das Projekt wird auf **Microsoft Azure** bereitgestellt. Die Docker-Container werden auf **Azure Container Instances** oder **Azure Kubernetes Service (AKS)** gehostet.

- **Schritte**:
  - Docker-Images auf die Azure-Container-Registry hochladen.
  - Container auf Azure-Instanzen bereitstellen.
  - Sicherstellen, dass das Dashboard öffentlich zugänglich und sicher ist.

## **9. Tests und Qualitätssicherung** <a name="tests-und-qualitätssicherung"></a>

Die Anwendung wird durch Unit- und Integrationstests abgesichert:

- **Unit-Tests**: Mithilfe von **xUnit** oder **NUnit** werden die einzelnen API-Funktionen getestet.
- **Integrationstests**: Testen der Interaktion zwischen API und Datenbank sowie zwischen API und externen Diensten.
- **UI-Tests**: Sicherstellen, dass die Benutzeroberfläche korrekt funktioniert und auf verschiedenen Geräten responsive ist.

## **10. Installationsanleitung** <a name="installationsanleitung"></a>

### **Voraussetzungen**:
- **.NET SDK** (mindestens .NET 5.0)
- **Docker** (für Containerisierung)
- **MariaDB** (für die Datenbank)

### **Schritte zur Installation**:
1. **Repository klonen**:
   ```bash
   git clone https://github.com/your-repo/project-name.git
   cd project-name
   ```

2. **Docker-Container starten**:
    ```bash
   docker-compose up --build
   ```

3. **Anwendung lokal starten**:
- **Backend**: Läuft auf `http://localhost:5000`
- **Frontend**: Läuft auf `http://localhost:5001`

4. **Deployment auf Azure**:
- Folge den Azure Deployment-Anweisungen in der Dokumentation zur Bereitstellung.