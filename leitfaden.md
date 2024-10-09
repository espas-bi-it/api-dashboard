# 🤝 Leitfaden zum Beitragen
Damit jeder weiss, wie er eigenen Einträge zu unserem Linux Cookbook beitragen kann, steht hier eine klare Anleitung.

* [Leitfaden zum Beitragen](leitfaden.md#leitfaden-zum-beitragen)
  * [Repository aufsetzen](leitfaden.md#repository-aufsetzen)
  * [Eintrag erstellen](leitfaden.md#eintrag-erstellen)
  * [Eintrag ins Hauptrepository mergen](leitfaden.md#eintrag-ins-hauptrepository-mergen)
  * [Eigener Fork synchronisieren](leitfaden.md#eigener-fork-synchronisieren)

> ℹ️ Fork = geklontes Repository auf dem eigenen Account

📝 [**Markdown Cheatsheet**](https://www.markdownguide.org/cheat-sheet/)

### Repository aufsetzen
Bevor du starten kannst mit dem Erstellen deiner Einträge, muss zuerst das Repository aufgesetzt werden.

1. Gehe auf das Repository [API Dashboard](https://github.com/bi-it-elc/api-dashboard)
2. Klicke oben rechts auf "Fork" und erstelle deinen Fork

Nun hast du das Hauptrepository auf deinen eigenen Account "geforkt" und hast deine eigene Kopie des Linux Cookbook. Im eigenen Fork wird ab jetzt gearbeitet.

### Eigener Fork auf Desktop clonen
git clone https://github.com/<username>/api-dashboard
Fork im gewünschten Texteditor öffnen
Eintrag erstellen
Um nun zu beginnen mit dem Schreiben deiner Einträge, erstellst du nach simplen Vorschriften deine Dateien.

Neue Datei erstellen mit dem Namen in kebab-case und der Endung auf .md. Beispiel: permission-system.md
ℹ️ Der erste Titel (Heading 1) in der Datei wird auch als Seitentitel verwendet.

Falls der Eintrag in ein Unterthema gehört, dann in den jeweiligen Ordner verschieben.
Der Link zu deinem erstellten Eintrag an richtiger Stelle in das SUMMARY.md schreiben.
Eintrag ins Hauptrepository mergen
Nach dem Beenden deines Eintrages muss er jetzt in das Hauptrepository gemergt werden. Damit dies problemlos verläuft, folge den folgenden Schritten.

Alle Änderungen in den eigene Fork committen
Gehe auf die Seite deines Forkes
Klicke auf das "Conribute" dropdown
Klicke nun auf "Open pull request"
Beschreibe falls nötig kurz deine Veränderungen
Warte bis dein Pull Request von den Leads angeschaut wird und möglicherweise nach Revisionen gefragt wird
Nachdem dein Eintrag angenommen wurde, beginnt das ganze wieder von vorne. Nicht vergessen deinen Fork zu synchronisieren.

### Eigener Fork synchronisieren
Wenn jeder seine Änderungen zum Hauptrepository beiträgt, kann es schnell passieren dass der eigene Fork nicht mehr auf dem neusten Stand ist. Darum muss man ihn regelmässig synchronisieren.

Geh auf die Seite deines Forkes.
Klicke auf das "Sync fork" dropdown und bestätige das synchronisieren.
ℹ️ Aufpassen, nur synchronisieren wenn alle Änderungen schon im Hauptrepository sind. Ansonsten können diese möglicherweise gelöscht/überschrieben werden.

Bei Fragen/Problemen, einen Lead anschreiben.
