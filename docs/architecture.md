tree-manager se plantea inicialmente como un monolito modular desarrollado en .NET.

La aplicación expone una API HTTP que permitirá gestionar operaciones básicas relacionadas con servicios de directorio.

## Decisiones iniciales

- Se utiliza .NET por su madurez, rendimiento, soporte multiplataforma y afinidad con entornos Microsoft.
- Se inicia con una arquitectura monolítica modular para evitar complejidad innecesaria.
- La aplicación será containerizada desde el comienzo.
- La infraestructura será definida con Terraform.
- El despliegue objetivo será Azure, comenzando con máquinas virtuales Linux y evolucionando hacia Kubernetes.

## Arquitectura inicial

```text
Cliente
  |
  v
tree-manager API
  |
  v
Servicio de directorio
  |
  v
OpenLDAP / Active Directory futuro


### Evolución planificada

Fase 1: API mínima + health check
Fase 2: Docker + Docker Compose
Fase 3: CI/CD con GitHub Actions
Fase 4: Infraestructura Azure con Terraform
Fase 5: Kubernetes
Fase 6: Integración con OpenLDAP
Fase 7: Integración con Active Directory real