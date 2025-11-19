📘 Responsive ASP.NET Core MVC Website

This repository contains a responsive and fully featured web application built with ASP.NET Core MVC, Entity Framework Core, C#, and modern front-end technologies. The project demonstrates multi-page site design, role-based authentication, responsive UI development, and CRUD operations using an MVC architecture.

The application was developed using Visual Studio Code, following best practices for maintainability, scalability, and clean separation of concerns.


🚀 Key Features
Responsive Web Interface

Implemented with Bootstrap 5, Flexbox, CSS Grid, and media queries

Mobile-first design ensuring consistent presentation across devices

Full-width layout with seamless content flow and no outer white-space

ASP.NET Core MVC Architecture

Structured controllers, views, and models

Integrated Entity Framework Core for data management

CRUD functionality for managing AIImage records

Authentication & Role Management

User registration and login pages

Role-specific access:

Public users: Home and Contact pages

Authenticated users: Additional content and Create functionality

Admin users: Full access, including edit and delete operations

Consistent Site-Wide Layout

Shared layout powered by _Layout.cshtml

Reusable navigation menu and footer

Cohesive UI/UX theme across all pages

External Styling & Scripts

All CSS maintained in external stylesheets (site.css)

All JavaScript interactions implemented in site.js

No inline or embedded CSS/JS for clean, modular development

Custom Creative Page

Additional independently designed page

Fully responsive and stylistically aligned with the rest of the site

Linked from both navigation and footer menus


🗂️ Project Structure
├── Controllers/
│   ├── HomeController.cs
│   ├── AIImagesController.cs
│   └── AccountController.cs
│
├── Models/
│   └── AIImage.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Contact.cshtml
│   │
│   ├── AIImages/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Details.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   │
│   ├── Account/
│   │   ├── Login.cshtml
│   │   └── Register.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
│
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   └── media/
│
└── appsettings.json


🧰 Technologies
Backend

ASP.NET Core MVC (C#)

Entity Framework Core

Razor Views

Frontend

HTML5

CSS3

Bootstrap 5

Flexbox & CSS Grid

JavaScript (external modules)

Development Tools

Visual Studio Code

.NET 7/8 SDK

Chrome + Edge DevTools


🧪 Functionality Overview

Multi-page navigation with intuitive site structure

CRUD operations for image-related records using EF Core

Centralised layout for consistent branding

Robust exception handling

Verified compatibility with both Chrome and Microsoft Edge

Mobile-first layout tested through dev tools inspection


🖼️ Media & Attribution

All images, icons, and external media used within the project are sourced from copyright-free libraries or created independently. Full attributions are provided on the Contact page.


📬 Connect

For questions, suggestions, or collaboration:

GitHub: https://github.com/LowellMasibo
