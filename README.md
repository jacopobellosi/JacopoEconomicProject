# Break-Even Analysis Tool

## Abstract
This project presents a Windows Forms application designed for the economic analysis of business organizations, specifically focusing on Break-Even Analysis. The tool facilitates the computation of the break-even point by allowing users to input and manage fixed and variable costs. It provides a graphical representation of cost-volume-profit relationships, aiding in decision-making processes regarding production and pricing strategies.

## Key Features
*   **Cost Management System**: A structured interface for the detailed entry and categorization of fixed and variable costs.
*   **Automated Break-Even Computation**: Algorithms to calculate the precise break-even point based on user-defined parameters.
*   **Graphical Visualization**: Interactive charting capabilities to visualize the intersection of total cost and total revenue curves.
*   **Data Persistence**: Functionality to serialize project data into a proprietary format (\.JEP\) for storage and retrieval.

## System Requirements
*   **Operating System**: Microsoft Windows
*   **Runtime Environment**: .NET Framework 4.7.2

## Installation and Execution

### Method 1: Pre-compiled Binary
To execute the application using the pre-compiled binary, run the following command in the terminal:
\\\ash
.\BreakEvenAnalysis\bin\Debug\BreakEvenAnalysis.exe
\\\`r

### Method 2: Source Compilation

#### Prerequisites
*   Visual Studio 2019/2022 with the ".NET desktop development" workload installed.
*   Alternatively, the MSBuild toolchain.

#### Compilation via Visual Studio
1.  Open the solution file \BreakEvenAnalysis.sln\ in Visual Studio.
2.  Build and execute the project by pressing \F5\ or selecting "Start Debugging".

#### Compilation via Command Line (MSBuild)
For environments lacking the full Visual Studio IDE, the project can be built using the .NET Framework MSBuild:

\\\powershell
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" BreakEvenAnalysis.sln
\\\`r

## Project Architecture
The application is structured into several distinct modules, each responsible for specific functionalities:

*   **MainForm.cs**: Serves as the primary entry point and main menu of the application.
*   **NewProjectForm.cs**: Provides the interface for initializing new analysis projects and data entry.
*   **ImportProjectForm.cs**: Handles the logic for importing and parsing existing project files.
*   **ChartForm.cs**: Implements the visualization logic for generating break-even charts.

## Author
**Jacopo Bellosi**
