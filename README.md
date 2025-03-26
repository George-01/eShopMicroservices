# eShopMicroservices

## Overview

This project, **eShopMicroservices**, is a hands-on implementation of a microservices-based e-commerce application using **.NET 8, DDD, CQRS, Vertical/Clean Architecture**, **Docker** and other cloud-native technologies. It was developed by following the highly-rated Udemy course [Microservices Architecture and Implementation on .NET](https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/) by **Mehmet Ozkaya**.

The goal of this project was to gain practical experience in building scalable and modular microservices applications while reinforcing industry best practices.

## Features

- **Microservices Architecture**: Independent services for different functionalities such as Catalog, Basket, Discount, Ordering, and YARP.
- **API Gateway**: Secure and unified access to microservices using **YARP API Gateway**.
- **Event-Driven Communication**: Implemented **RabbitMQ** with **MassTransit** for asynchronous messaging between services.
- **Database Per Microservice**: Leveraged **SQL Server** and **PostgreSQL** for different services.
- **Containerization & Orchestration**: Used **Docker**.
- **Redis**: Used **Redis** for cached data
- **gRPC Communication**: Used **gRPC** for efficient interservice communication between the Basket and Discount microservices.


## Tech Stack

| Category               | Technology |
|------------------------|------------|
| Backend Framework      | .NET 8, ASP.NET Core |
| API Gateway           | YARP | Design Patterns |
| Database     | SQL Server, PostgreSQL |
| Containerization       | Docker |
| Messaging & Streaming  | RabbitMQ, MassTransit |
| Logging   | (MediatR)

## Microservices Breakdown

1. **Catalog Service** - Manages product listings (CRUD operations with PostgreSQL)
2. **Basket Service** - Handles user shopping cart functionality
3. **Discount Service** - Manages promotional discounts (gRPC-based communication)
4. **Ordering Service** - Handles order processing and transactions
5. **API Gateway** - Provides a single entry point to all services

## Key Learnings & Takeaways

✅ Deep understanding of microservices architecture and best practices.

✅ Implemented real-world patterns like CQRS, event-driven communication, and database-per-microservice.

✅ Hands-on experience with Docker, and cloud-native application development.

✅ Improved ability to troubleshoot distributed systems and build resilient applications.

## Course Reference
This project was implemented while following the Udemy course:
[Microservices Architecture and Implementation on .NET](https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/) by **Mehmet Ozkaya**.

## Future Improvements
- Implement GraphQL for data fetching efficiency.
- Add distributed tracing using OpenTelemetry.
- Improve logging and monitoring with ELK Stack.
- Deployment on Azure using AKS, ACR etc
- Identity Service to implement authentication and authorization
- Authentication & Authorization: Implement Identity Server 4 for secure authentication.
- Resiliency Patterns: Use Polly for retry policies, circuit breakers, and resiliency strategies.
- CI/CD Integration: Automate builds and deployments with GitHub Actions and Azure DevOps. (Next steps)
