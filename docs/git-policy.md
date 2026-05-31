# Política Git

## Estrategia de ramas

El proyecto utiliza una estrategia simple basada en ramas protegidas y Pull Requests.


main
dev
feature/*
fix/*
hotfix/*


## Reglas
- No se permite push directo a main.
- Todo cambio debe entrar mediante Pull Request.
- Los Pull Requests deben tener una descripción clara.
- Los checks de CI deben pasar antes del merge.
- Los cambios de infraestructura deben incluir revisión de Terraform Plan.
- No se deben subir secretos, archivos .env ni credenciales.
- Los commits deben seguir Conventional Commits.
- Conventional Commits

Formato:

tipo(scope): descripción

Ejemplos:

feat(api): add health check endpoint
fix(docker): correct exposed port
ci(actions): add dotnet workflow
infra(terraform): add resource group
docs(readme): update project description
test(api): add health endpoint tests