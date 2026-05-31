# CI/CD

El proyecto utilizará GitHub Actions para automatizar validaciones y despliegues.

## Objetivos

- Validar Pull Requests.
- Compilar la aplicación.
- Ejecutar pruebas.
- Construir imagen Docker.
- Validar infraestructura con Terraform.
- Desplegar de forma controlada.

## Pipeline inicial

Pull Request
  |
  ├── restore
  ├── build
  ├── test
  └── docker build validation
  

### Pipeline de infraestructura
Cambios en infra/
  |
  ├── terraform fmt
  ├── terraform validate
  └── terraform plan


### Pipeline de despliegue futuro
Merge a main
  |
  ├── build Docker image
  ├── push to registry
  ├── terraform apply
  └── deploy to Kubernetes