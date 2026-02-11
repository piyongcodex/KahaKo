# KahaKo Point of Sale (POS) System

KahaKo Point of Sale System is a **mobile-first POS application** built with **.NET MAUI**.  
It provides secure user authentication, local data persistence, and essential product and sales management features.

The application is designed to work **offline-first**, making it ideal for small to medium retail businesses.

---

## Features

- 🔐 **User Authentication**
  - Secure login system
  - Password hashing using **BCrypt.Net**

- 📦 **Product Management**
  - Add, update, delete, and view products
  - Stored locally using **SQLite**

- 💰 **Sales Management**
  - Record and manage sales transactions
  - Fast and reliable local data access

- 📱 **Mobile-First Design**
  - Built with **.NET MAUI** for cross-platform support
  - Optimized for mobile devices

- 📴 **Offline Support**
  - Fully functional without an internet connection

---

## Tech Stack

- **Framework:** .NET MAUI  
- **Architecture:** MVVM (Model–View–ViewModel)  
- **Database:** SQLite  
- **ORM:** Microsoft.EntityFrameworkCore.Sqlite  
- **Security:** BCrypt.Net  
- **MVVM Toolkit:** CommunityToolkit.MAUI  

---

## Architecture

The application follows the **MVVM (Model–View–ViewModel)** design pattern to ensure:

- Clear separation of concerns  
- Improved code maintainability and scalability  
- Clean data binding between UI and business logic  

---

## License

© 2026 KahaKo POS System

This is a personal project owned by the author.  
The source code is provided for viewing and learning purposes only.

Unauthorized copying, modification, distribution, or commercial use of this project is not permitted without prior written permission from the author.
