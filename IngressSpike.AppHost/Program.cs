var builder = DistributedApplication.CreateBuilder(args);



var microservice1 = builder.AddProject<Projects.microservice1>("microservice1");
var microservice2 = builder.AddProject<Projects.microservice2>("microservice2");


var apiGateway = builder.AddProject<Projects.apigateway>("apigateway")
    .WithReference(microservice1)
    .WithReference(microservice2);

builder.Build().Run();
