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

```http
GET /health