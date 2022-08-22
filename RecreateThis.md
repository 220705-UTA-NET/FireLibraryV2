CI/CD Adaption for other repos

1. Fork the project to a personal repo.
2. Create a dockerhub repo for the project on your DockerHub. 
3. Add the DOCKERHUB_USERNAME and DOCKERHUB_TOKEN secrets to your fork (see .github/workflows/API-docker-azure.yml for exact names)
4. Run Entity Framework and connect to a fresh Azure SQL database.
5. Add-Migration + Update-Database in the Visual Studio package manager to create database tables using Entity Framework.
6. Populate DB. See SQL file in repo for commands. 
