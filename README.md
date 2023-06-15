# massTransit
Repo to get started with Mass Transit

## Purpose
Mass Transit is package used to interface many message queue types behind it like the Azure Service Bus or the open source RabbitMQ. When developing locally it easier to make use of rmq and switch accordingly when on production to the Azure Service Bus.

This repo can be used as a template where `Producer.cs` is loaded as a background service and messages are sent periodically to the `Consumers`. Consumers processes the message in turn.

## Requirements
Setup `RabbitMQ` docker image locally to test it but is not required.