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


### 1. Automated HR Candidate Screening System (Latest Project)

## Project Overview
This RPA solution is an intelligent automation designed to streamline the recruitment screening process. By leveraging **Google Gemini AI**, the bot evaluates candidate CVs against specific Job Descriptions, handles file organization, and manages professional communication—all while maintaining high system resilience.

---

## Key Technical Features
* **AI-Powered Evaluation:** Direct integration with **Gemini LLM** to provide candidate scoring and qualitative feedback.
* **Self-Healing API Logic:** Features a **Failover Mechanism** that automatically detects API Key expiration (Error 400/401) and switches to a secondary key to ensure uninterrupted processing.
* **Optimized Performance:** Implements a dynamic pause between requests to respect API rate limits, with an optimized exit logic that skips the final pause to save execution time.
* **Smart File Management:** * **Shortlisting:** Automatically renames files to `CandidateName_Phone.pdf` and moves them to the 'Shortlisted' directory.
    * **Automated Clean-up:** Permanently deletes rejected files from the source folder after processing to maintain workspace hygiene.
* **Data Persistence:** Records all AI feedback and scores into a **DataTable**, exported into a final professional **Excel Report**.

---

## Workflow Architecture
The project follows a robust RPA lifecycle:
1.  **Initialization:** Loads constants and assets from a dynamic `Config.xlsx` file (Zero Hardcoding).
2.  **Pre-Condition Check:** Validates source directory paths and ensures necessary files exist before starting.
3.  **Process Engine:**
    * Iterates through candidate files via a Dictionary/DataTable.
    * Sends requests to Gemini API and converts output into a **JSON Object**.
    * Uses **Regex** to clean and extract specific data points.
    * Handles errors through a **Retry Scope** with API Key switching logic.
4.  **Post-Condition Check:** Verifies that the source folder is empty and confirms the successful generation of the final report and email dispatches.

---

## ⚠️ Important Notices
> [!IMPORTANT]
> This project is specifically architected for **Google Gemini APIs**. If you intend to use a different LLM provider (e.g., OpenAI or Anthropic), you must reconfigure the **HTTP Request** activities and update the **JSON Parsing** logic.

---

## How to Use
1.  **Clone the Repository:** 
2.  **Configure Config file:**

### 2. Calculate Client Security Hash (SHA1)

An enterprise-grade bot designed for high-performance data processing.

* **Logic:** Automates the ACME System 1 portal to retrieve customer data.
* **Technical Highlight:** Integrated **C# Coded Automation** for the SHA1 hashing process to ensure maximum execution speed.
* **Resilience:** Full exception handling (System & Business) with detailed Excel logging and automated email alerts upon failure.

### 3. Generate Yearly Report

A comprehensive data-aggregation bot focused on file management and system synchronization.

* **Logic:** Scrapes monthly vendor data, merges multiple reports into a single `CID-Yearlyreport.xlsx`, and uploads it back to the ACME system.
* **Features:** Implements a "clean-up" routine to delete temporary monthly files post-upload.
* **Flexibility:** Includes user-defined parameters for selecting specific months for download.

### 4. Document Understanding (AI Center)

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

---

## Contact:
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/hosnielsharkawi)
> **Please Note:** While the technical content, project architecture, and automation logic are entirely my own work, I have utilized AI tools to refine the grammar and formatting of this README for better readability.
