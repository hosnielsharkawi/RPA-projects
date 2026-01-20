# 🤖 Personal RPA Portfolio:

Welcome to my central repository for Robotic Process Automation. This collection showcases my journey in building scalable, resilient, and intelligent automation solutions using **UiPath** .

## Repository Structure

The projects are categorized by complexity and technical depth:

* **Advanced Projects:** Complex enterprise-level workflows featuring ReFramework, C#, API integrations and AI.
* **Intermediate Projects:** Web automation, Data Manipulation.
* **Certificates:** Validation of my technical expertise in the RPA.

---

## Advanced Projects

*Each project in this section follows modular design principles and utilizes a Config file to eliminate hard-coding.*

### 1. Calculate Client Security Hash (SHA1)

An enterprise-grade bot designed for high-performance data processing.

* **Logic:** Automates the ACME System 1 portal to retrieve customer data.
* **Technical Highlight:** Integrated **C# Coded Automation** for the SHA1 hashing process to ensure maximum execution speed.
* **Resilience:** Full exception handling (System & Business) with detailed Excel logging and automated email alerts upon failure.

### 2. Generate Yearly Report

A comprehensive data-aggregation bot focused on file management and system synchronization.

* **Logic:** Scrapes monthly vendor data, merges multiple reports into a single `CID-Yearlyreport.xlsx`, and uploads it back to the ACME system.
* **Features:** Implements a "clean-up" routine to delete temporary monthly files post-upload.
* **Flexibility:** Includes user-defined parameters for selecting specific months for download.

### 3. Document Understanding (AI Center)

An Intelligent Automation solution for invoice processing.

* **AI Integration:** Utilizes **UiPath AI Center** with a trained model for invoice extraction.
* **Human-in-the-loop:** Features **Action Center** integration, where the bot escalates low-confidence data to a human for validation before final Excel storage.

---

## Intermediate Projects

### IMDb Top-Rated Movies & LINQ Analysis

A data-heavy automation that extracts movie rankings.

* **Advanced Logic:** Uses **LINQ** queries to sort and filter large datasets (descending order movies based on release year) before exporting to Excel.

### Weather & Movie Search Assistant

A user-driven bot that provides real-time information.

* **IMDb Extraction:** Navigates dynamic web pages to extract structured data.
* **Weather Service:** Retrieves weather details for specific countries and generates a text report with **outfit recommendations** based on the current temperature.

### RPA Challenge (Dynamic Selectors)

A demonstration of UI stability and speed.

* **Technical Achievement:** Successfully navigates the "RPA Challenge" by using **dynamic selectors** and a single "Type Into" activity to accurately populate fields despite changing labels/positions.

### Event Participants & Forms Automation

* **Workflow:** Scrapes participant data from web sources and automates the submission process into Microsoft Forms, maintaining a master log in Excel.

---

## Tech Stack

* **Primary Tool:** UiPath Studio
* **Languages:** C#, VB.NET
* **Concepts:** ReFramework, LINQ, AI Center, Document Understanding, Web Scraping.

---

## Certificates:
* Automation Dev Professional Training
* Automation Dev Associate Training
* Automation BA Associate Training
* rpaMaharaTech-1st
* rpaMaharaTech-2nd
* c_sharp_basic certificate
* python_basic certificate
