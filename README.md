# tree-manager

tree-manager es una aplicación web containerizada orientada a la gestión de operaciones básicas sobre servicios de directorio, inspirada en la estructura de árboles y bosques utilizada en Active Directory.

El proyecto funciona como un laboratorio DevOps para practicar desarrollo backend, contenerización, infraestructura como código, CI/CD, despliegue en Azure y Kubernetes.

## Stack inicial

- .NET / ASP.NET Core Web API
- Docker
- Terraform
- GitHub Actions
- Azure
- Kubernetes

## Estado actual

La primera versión expone un endpoint operativo de salud:

```bash 
GET /health
```

## Ejecutar con Docker Compose

Construir y levantar el servicio:

```bash 
docker compose up --build
```

Verificar el health check:

```bash
curl http://localhost:8080/health
````

Detener los servicios:
```bash
docker compose down
```