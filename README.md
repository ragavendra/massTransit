# massTransit
Repo to get started with Mass Transit

## Purpose
Mass Transit is package used to interface many message queue types behind it like the Azure Service Bus or the open source RabbitMQ. When developing locally it easier to make use of rmq and switch accordingly when on production to the Azure Service Bus.

This repo can be used as a template where `Producer.cs` is loaded as a background service and messages are sent periodically to the `Consumers`. Consumers processes the message in turn.

## Requirements
Setup `RabbitMQ` docker image locally to test it but is not required.

Running `RabbitMQ` container locally with `docker` should be easily achieved by running the below command.

```
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.12-management
```

Check `RabbitMQ`'s site for the updated image.

Say if the application is already running using `dotnet run --no-build Debug` command after `dotnet build`, starting the `RabbitMQ` docker instance should start processing the messages and should be accessible in `localhost:15267/#/queues` or similar.