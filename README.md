# JSON API with .NET 8

A simple REST API built with .NET 8 that returns JSON data. This project includes Docker support for easy deployment.

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop/) (optional, for containerization)
- [Visual Studio Code](https://code.visualstudio.com/) or your preferred IDE

## Getting Started

### Local Development
Run the application
```bash
dotnet run
```

The API will be available at:

http://localhost:5258
Swagger UI: http://localhost:5258/swagger

### Using Docker
1. Build the Docker image
```bash
docker build -t api-net .
```

2. Run the container
```bash
docker run -p 5258:80 api-net
```
Or using Docker Compose:
```bash
docker-compose up --build
```

## API Endpoints

### Products
- `GET /api/products` - Get all products
- `GET /api/products/{id}` - Get a specific product
- `POST /api/products` - Create a new product

### Example Requests
Get all products:
```bash
curl http://localhost:5258/api/products
```
Get a specific product:
```bash
curl http://localhost:5258/api/products/1
```
Create a new product:
```bash
curl -X POST http://localhost:5258/api/products \
     -H "Content-Type: application/json" \
     -d '{"name":"Tablet","price":299.99}'
```
### Project Structure
```
.
├── Controllers/
│   └── ProductsController.cs
├── Models/
│   └── Product.cs
├── Properties/
│   └── launchSettings.json
├── Dockerfile
├── docker-compose.yml
├── Program.cs
├── appsettings.json
└── README.md
```

### Configuration
Environment-specific configuration can be found in:
- appsettings.json
- appsettings.Development.json
- Properties/launchSettings.json

### Docker Support
The project includes:

- `Dockerfile` - For building the container image
- `docker-compose.yml` - For local development
- `.dockerignore` - To exclude unnecessary files

