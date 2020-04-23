cd "C:\Users\francisco.sosa\source\repos\dockertraining_compose_francisco_sosa_v1\dockertraining_compose_francisco_sosa_v1" 

dotnet tool install -g dotnet-ef

dotnet ef migrations add Initial

docker volume create docker_compose_vol

docker-compose -f docker-compose.yml config



