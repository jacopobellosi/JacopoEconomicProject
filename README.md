# JacopoEconomicProject - Break-even Analysis Tool

Un'applicazione Windows Forms per l'analisi del punto di pareggio (Break-even Point) in economia e organizzazione aziendale.

##  Descrizione

Questo progetto permette agli utenti di inserire e gestire costi fissi e variabili per calcolare il punto di Break-even. L'applicazione offre funzionalità per salvare e caricare progetti e visualizzare graficamente i risultati dell'analisi.

### Funzionalità Principali
- **Gestione Costi**: Inserimento dettagliato di costi fissi e variabili.
- **Analisi Break-even**: Calcolo automatico del punto di pareggio.
- **Visualizzazione Grafica**: Grafico interattivo per visualizzare l'andamento dei costi e dei ricavi.
- **Salvataggio/Caricamento**: Possibilità di salvare i progetti in formato .JEP e ricaricarli successivamente.

##  Requisiti di Sistema

- **Sistema Operativo**: Windows
- **Framework**: .NET Framework 4.7.2

##  Installazione e Esecuzione

### Metodo 1: Eseguibile Precompilato
Se hai scaricato la release, puoi avviare direttamente il file eseguibile:
`ash
.\BreakEvenAnalysis\bin\Debug\BreakEvenAnalysis.exe
``r

### Metodo 2: Compilazione da Sorgente

#### Prerequisiti
- Visual Studio 2019/2022 con il carico di lavoro ".NET desktop development" installato.
- Oppure MSBuild installato nel sistema.

#### Compilazione con Visual Studio
1. Apri il file BreakEvenAnalysis.sln con Visual Studio.
2. Premi F5 o clicca su "Avvia" per compilare ed eseguire il progetto.

#### Compilazione da Riga di Comando (MSBuild)
Se non hai Visual Studio completo ma hai il framework .NET installato, puoi usare MSBuild:

`powershell
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" BreakEvenAnalysis.sln
``r

##  Struttura del Progetto

- **MainForm.cs**: Menu principale dell'applicazione.
- **NewProjectForm.cs (Nuovo_progetto)**: Interfaccia per l'inserimento dei dati e la gestione del nuovo progetto.
- **ImportProjectForm.cs (Progetto_importato)**: Gestione dei progetti importati.
- **ChartForm.cs**: Logica per la visualizzazione del grafico di Break-even.

##  Autore

Jacopo Bellosi
