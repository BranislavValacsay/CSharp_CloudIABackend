# Hiring company portal backend written in C#

## About This Project

This repository contains the codebase for our company's comprehensive web platform. It includes a public-facing website, an employee portal, and an administrative backend, designed to streamline our online presence and internal operations.


## Built With

- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/) - The web framework used
- [Entity Framework](https://learn.microsoft.com/en-us/ef/) - Communication with SQL Database

## Features

### Public Section API Endpoints

### Landing Page Data

- Endpoint for hero section content
- Endpoint for About Us information
- Endpoint for services/products overview


### Job Listings

- Endpoint for retrieving job openings
- Implementation of advanced search and filtering logic
- Endpoint for detailed job descriptions


### Contact Form

- Endpoint for form submission
- Server-side input validation
- Implementation of spam protection measures



### Employee Portal Backend

- ### Authentication System

- Secure login endpoint
- Password recovery mechanism


### Internal Management

- API for task and project management
- Employee directory data management
- Backend support for internal communication tools



### Admin Dashboard Backend

- Job Posting Management

- CRUD operations for job listings
- Status management logic (new, active, inactive)


### User Management

- CRUD operations for user accounts
- Role and permission management system


### Analytics and Reporting

- Data collection and processing for website traffic
- Job listing interest data aggregation
- API for retrieving performance indicators



## Technical Specifications
### Authorization & Authentication

- Implement JWT (JSON Web Tokens) for secure authentication
- Role-based access control middleware

### API and Backend Architecture

- RESTful API design and implementation
- DTO (Data Transfer Objects) for data validation and transformation
- Request interceptors for logging, rate limiting, and request processing

### Search Functionality

- Implement search for advanced querying
- Design and implement multi-criteria filtering logic

### Database Design

- Optimize database schema for efficient querying
- Implement database indexing for frequently accessed data
- Database is accessed and processed by Entity Framework

Security Measures

- Implement HTTPS for all communications
- Cross-Origin Resource Sharing (CORS) configuration
- Input sanitization to prevent SQL injection and XSS attacks

Deployment and DevOps

- Containerization using Docker for consistent environments
- CI/CD pipeline setup for automated testing and deployment
- Environment-specific configuration management

### Installation
1. Clone the repository
   ```
   git clone https://github.com/BranislavValacsay/CSharp_CloudIABackend.git
   ```
2. Navigate to the project directory
   ```
   cd CSharp_CloudIABackend
   ```
3. [Any additional setup steps]

### Running the Application
- [Instructions on how to run the application locally]
```
  dotnet run
```

## Contact

- LinkedIn: [https://www.linkedin.com/in/branislav-valacsay/](https://www.linkedin.com/in/branislav-valacsay/)
- Email: branislav.valacsay@archdev.tech
- Website: http://archdev.tech

---

"Blending creativity with technology to create something useful and engaging."
