
# Aspire & Aspir8 Microservices Tutorial

## Overview

Welcome to the Aspire & Aspir8 Microservices Tutorial repository. This repository contains the necessary code and resources to guide you through setting up and deploying microservices in a Kubernetes environment using Aspire & Aspir8. It's designed to simplify the process of managing container orchestration and service discovery without the need for complex Docker or YAML configurations. 

Blog Post: https://medium.com/@josephsims1/aspire-aspi8-deploy-microservices-effortlessly-with-cli-no-docker-or-yaml-needed-f30b58443107

## Prerequisites

Before starting with the tutorial, ensure you have the following tools installed:

- **Rancher Desktop by SUSE** - [Download Rancher Desktop](#)
- **.NET 8** - Suitable for Linux, macOS, and Windows. [Download .NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Aspire Tooling for .NET** - Learn about it on [Microsoft Learn](#)
- **Aspir8** - Necessary for deployment processes. [Installation Guide](#)

## Project Structure

This project includes:

1. **App Host**: The core of the project, responsible for initiating and managing microservices.
2. **Service Defaults**: Extension methods for integrating features like Prometheus, logging, health checks, and APM.

### Microservices

- **Microservice 1**: A simple service demonstrating basic functionality.
- **Microservice 2**: A secondary service showcasing additional routing capabilities.

### API Gateway

- Configured with YARP to demonstrate dynamic routing to different microservices.

## Getting Started
- Go into app host project and run <code> dotnet watch </code> or <code> dotnet run </code>
