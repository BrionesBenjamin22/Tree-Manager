# Infraestructura

La infraestructura del proyecto será definida como código utilizando Terraform.

## Cloud provider

El proveedor cloud objetivo es Microsoft Azure.

## Etapa inicial

La primera etapa contempla una infraestructura liviana basada en una máquina virtual Linux.

Recursos previstos:

- Resource Group
- Virtual Network
- Subnet
- Network Security Group
- Public IP
- Network Interface
- Linux Virtual Machine

## Etapa posterior

Como evolución, el proyecto podrá incorporar:

- Azure Container Registry
- Kubernetes liviano sobre VM
- Azure Kubernetes Service
- Azure Monitor
- Log Analytics

## Criterio de diseño

La infraestructura inicial prioriza bajo consumo de recursos debido al uso de credenciales de estudiante. Por ese motivo, se evita comenzar directamente con AKS o Windows Server.