# 📅 [Timetable to calendar tool]


> A simple tool to convert your school timetable into a universal .csv file, ready for one-click import into Google Calendar or Outlook.



---

## 📋 Table of Contents

* [About The Project](#about-the-project)
* [✨ Features](#-features)
* [🚀 Getting Started](#-getting-started)
    * [Prerequisites](#prerequisites)
* [Usage Guide](#usage-guide)

---

## ℹ️ About The Project

Manually entering your entire timetable into a digital calendar is tedious and prone to errors. This tool automates the entire process.

It reads your timetable file, asks for your term dates, and instantly generates a correctly formatted CSV file. You can then import this file directly into Google Calendar or Outlook, populating your entire semester in seconds.

### Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET 8](https://dotnet.microsoft.com/)

---

## ✨ Features

* Intelligently handles recurring events based on your term dates including 2 week timetable (issues with half term pausing weeks swap)
* Generates a universal `.csv` file compatible with:
    * Google Calendar
    * Microsoft Outlook (Desktop & 365)
    * Apple Calendar
* Simple, clean user interface.

---

## 🚀 Getting Started

Follow these steps to get a local copy up and running.

### Prerequisites

You will need the following software installed on your machine:
* [.NET SDK (8.0)](https://dotnet.microsoft.com/download)
* (Optional) [Visual Studio 2022](https://visualstudio.microsoft.com/)

---

## 💡 Usage Guide

Using the tool is a simple 2-step process:

### Step 1: Set Your Term Dates

<img width="573" height="428" alt="image" src="https://github.com/user-attachments/assets/38d5e813-5c88-485b-bf53-9bb6e3373417" />

1. Set the first day of term
2. Set the first Monday of each holiday
3. Click the Set Term Dates button.

> [!TIP]
> Once you have done this it saves the term dates to the program and will load by default each time




### Step 2: Load Your Timetable

#### Part 1: Create your timetable file
First, create a text file with each lesson on each line.
You will need 6 lessons a day (Reg, P1, P2, P3, P4, P5)
5 days a week
2 week timetable
60 rows in total

> [!NOTE]
> My school starts on Week B so make sure you set your timetable up for the first 2 weeks of term

#### Part 2: load the timetable file into the program

1.  Click the **"Load Timetable File"** button.
2.  Select your timetable file from your computer.
3.  **Supported Formats:** `[.csv]`



---
#### **Importing to Google Calendar:**
1.  Open Google Calendar on your desktop.
2.  Click the **Settings gear** > **Settings**.
3.  On the left, click **"Import & export"**.
4.  Select the `.csv` file you just saved and choose the calendar you want to add it to.
5.  Click **"Import"**.
Set the term dates to create the timetaable.

#### **Importing to Outlook:**
1.  Open Outlook on your desktop.
2.  Go to **File** > **Open & Export** > **Import/Export**.
3.  Choose **"Import from another program or file"** and click **Next**.
4.  Choose **"Comma Separated Values"** and click **Next**.
5.  **Browse** for the `.csv` file, select it, and click **Next**.
6.  Select your **"Calendar"** as the destination folder and click **Next**.
7.  Click **Finish**.
