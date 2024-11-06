# 🤝 Leitfaden zum Beitragen
Damit jeder weiss, wie er eigenen Einträge zum Dashboard Pojekt beitragen kann, steht hier eine klare Anleitung.

* [Leitfaden zum Beitragen](leitfaden.md#leitfaden-zum-beitragen)
  * [Repository aufsetzen](leitfaden.md#repository-aufsetzen)
  * [Eintrag erstellen](leitfaden.md#beitragen)
  * [Eintrag ins Hauptrepository mergen](leitfaden.md#eintrag-ins-hauptrepository-mergen)
  * [Eigener Fork synchronisieren](leitfaden.md#eigener-fork-synchronisieren)

> ℹ️ Fork = geklontes Repository auf dem eigenen Account

📝 [**Markdown Cheatsheet**](https://www.markdownguide.org/cheat-sheet/)

### Repository aufsetzen
Bevor du starten kannst mit dem Erstellen deiner Einträge, muss zuerst das Repository aufgesetzt werden.

1. Gehe auf das Repository [API Dashboard](https://github.com/espas-bi-it/api-dashboard)
2. Klicke oben rechts auf "Fork" und erstelle deinen Fork

Nun hast du das Hauptrepository auf deinen eigenen Account "geforkt" und hast deine eigene Kopie des Dasbboard Projektes. Im eigenen Fork wird ab jetzt gearbeitet.

3. Eigener Fork auf Desktop clonen

```sh
git clone https://github.com/<username>/api-dashboard
```

4. Fork im gewünschten Texteditor öffnen
   
## Beitragen
Jeder kann zum Projekt beitragen, indem er es forkt, cloned und daran arbeitet. Um nun zu beginnen mit dem Schreiben deiner Einträge, erstellst du nach simplen Vorschriften deine Dateien.

1. Neue Datei erstellen mit dem Namen in kebab-case.
2. Falls der Eintrag in ein Unterthema gehört, dann in den jeweiligen Ordner verschieben.
3. Der Link zu deinem erstellten Eintrag an richtiger Stelle in das SUMMARY.md schreiben.
4. Jede Änderung sollte dokumentiert werden und in die [dokumentation](https://github.com/espas-bi-it/api-dashboard/blob/main/Docs/dokumentation.md) hinzugefügt werden.
   
## Eintrag ins Hauptrepository mergen

Nach dem Beenden deines Eintrages muss er jetzt in das Hauptrepository gemergt werden. Damit dies problemlos verläuft, folge den folgenden Schritten.

1. Alle Änderungen in den eigene Fork committen
2. Gehe auf die Seite deines Forkes
3. Klicke auf das "Conribute" dropdown
4. Klicke nun auf "Open pull request"
5. Beschreibe falls nötig kurz deine Veränderungen
6. Warte bis dein Pull Request von den Leads angeschaut wird und möglicherweise nach Revisionen gefragt wird

Nachdem dein Eintrag angenommen wurde, beginnt das ganze wieder von vorne. Nicht vergessen deinen [Fork zu synchronisieren](leitfaden.md#eigener-fork-synchronisieren).

## Eigener Fork synchronisieren

Wenn jeder seine Änderungen zum Hauptrepository beiträgt, kann es schnell passieren dass der eigene Fork nicht mehr auf dem neusten Stand ist. Darum muss man ihn regelmässig synchronisieren.

1. Geh auf die Seite deines Forkes.
2. Klicke auf das "Sync fork" dropdown und bestätige das synchronisieren.
> ℹ️ Aufpassen, nur synchronisieren wenn alle Änderungen schon im Hauptrepository sind. Ansonsten können diese möglicherweise gelöscht/überschrieben werden.

_Bei Fragen/Problemen, einen Lead anschreiben._


---


# 🤝 Contribution Guide
To ensure everyone knows how to contribute entries to our Linux Cookbook, here is a clear guide.

* [Contribution Guide](leitfaden.md#contribution-guide)
  * [Setting up the Repository](leitfaden.md#setting-up-the-repository)
  * [Creating an Entry](leitfaden.md#contributing)
  * [Merging the Entry into the Main Repository](leitfaden.md#merging-the-entry-into-the-main-repository)
  * [Syncing Your Fork](leitfaden.md#syncing-your-fork)

> ℹ️ Fork = a cloned repository on your own account

📝 [**Markdown Cheatsheet**](https://www.markdownguide.org/cheat-sheet/)

### Setting up the Repository
Before you can start creating your entries, you must first set up the repository.

1. Go to the repository [API Dashboard](https://github.com/bi-it-elc/api-dashboard)
2. Click on "Fork" in the top right to create your fork

Now you have "forked" the main repository to your own account, and you have your own copy of the Linux Cookbook. You will work in your own fork from now on.

3. Clone your fork to your desktop:

```sh
git clone https://github.com/<username>/api-dashboard
```

4. Open the fork in your preferred text editor.

## **Contributing**
Anyone can contribute to the project by forking, cloning, and working on it. To start writing your entries, follow these simple guidelines to create your files.

1. Create a new file with a name in kebab-case.
2. If the entry belongs to a subtopic, move it to the appropriate folder.
3. Write the link to your created entry in the correct place in the `SUMMARY.md`.
4. Every change should be documented and added to the [Documentation](https://github.com/espas-bi-it/api-dashboard/blob/main/Docs/dokumentation.md).

## Merging the Entry into the Main Repository
After finishing your entry, it needs to be merged into the main repository. Follow these steps to ensure a smooth process.

1. Commit all changes in your fork.
2. Go to the page of your fork.
3. Click on the "Contribute" dropdown.
4. Click on "Open pull request."
5. Briefly describe your changes, if necessary.
6. Wait for your pull request to be reviewed by the leads and possibly revised.

After your entry is accepted, the process starts again. Don't forget to [sync your fork](leitfaden.md#syncing-your-fork).

## Syncing Your Fork
When everyone contributes to the main repository, your fork may quickly become outdated. That's why it must be regularly synchronized.

1. Go to the page of your fork.
2. Click on the "Sync fork" dropdown and confirm the synchronization.

   > ℹ️ Be careful to sync only when all your changes have already been merged into the main repository. Otherwise, they might be overwritten or deleted.

_If you have questions or run into problems, contact a lead._
