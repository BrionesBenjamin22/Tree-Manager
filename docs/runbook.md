# Runbook

## Verificar ejecución local

dotnet run --project src/TreeManager.Api

Para verificar health check
curl http://localhost:5000/health

- Si la API no levanta

Revisar:

Versión de .NET instalada.
Errores de compilación.
Puerto utilizado.
Variables de entorno.
Logs de la terminal.



### Comandos útiles
dotnet build
dotnet test
dotnet run --project src/TreeManager.Api


### Futuro troubleshooting Docker
docker ps
docker logs <container>
docker exec -it <container> sh

### Futuro troubleshooting Kubernetes
kubectl get pods
kubectl logs deployment/tree-manager-api
kubectl describe pod <pod>
kubectl rollout status deployment/tree-manager-api
kubectl rollout undo deployment/tree-manager-api