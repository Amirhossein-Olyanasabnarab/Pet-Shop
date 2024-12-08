# Pet Shop - Online Store

This project is a **Pet Shop Online Store** application built with **ASP.NET Core 5**. The application is designed using the **Clean Architecture** approach to ensure scalability, maintainability, and testability.

## Features

- **User Authentication & Authorization**: 
  - User registration and login.
  - Role-based access (Admin and Customers).
- **Product Management**:
  - View products by categories (Pets, Food, Accessories, etc.).
  - Add, edit, and delete products (Admin only).
- **Shopping Cart**:
  - Add/remove products to/from the cart.
  - View cart details.
- **Order Management**:
  - Place orders.
  - Track order history.
  - Admin can manage orders (view, approve, cancel).
- **Payment Integration**:
  - Integrate with popular payment gateways (e.g., Stripe, PayPal).
- **Search & Filters**:
  - Search products by name or description.
  - Filter products by category, price, or rating.
- **Admin Dashboard**:
  - View sales and revenue reports.
  - Manage users, orders, and inventory.

---

## Technologies Used

- **Framework**: ASP.NET Core 5
- **Database**: Microsoft SQL Server
- **Frontend**: Razor Pages or React (optional)
- **Authentication**: Identity Framework with JWT Tokens
- **Payment Gateway**: Stripe/PayPal (for demo purposes)
- **Architecture**: Clean Architecture
- **Dependency Injection**: Built-in DI in ASP.NET Core
- **Logging**: Serilog
- **Unit Testing**: xUnit or NUnit

---

## Clean Architecture Layers

1. **Core**: 
   - Contains business logic and entities.
   - Implements use cases and interfaces.

2. **Application**:
   - Handles use case implementations.
   - Mediates between the Core and Infrastructure layers.
   - Uses Mediator pattern (via MediatR).

3. **Infrastructure**:
   - Handles external concerns like database, file storage, and third-party integrations.
   - Includes EF Core for data persistence.

4. **Presentation**:
   - Contains the Web API project for user interaction.
   - Handles requests and returns responses.

---
