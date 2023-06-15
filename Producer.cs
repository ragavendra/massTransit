using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using MassTransit;
using Contracts;

namespace Producer
{
    public class Producer : BackgroundService
    {
        readonly IBus _bus;

        public Producer(IBus bus)
        {
            _bus = bus;
        }

        protected override async Task ExecuteAsync(CancellationToken cts)
        {
            while(!cts.IsCancellationRequested)
            {
                await _bus.Publish(new SampleMessage(){ Title = "Hi there!" }, cts);

                await Task.Delay(1000, cts);
            }
            
        }

    }
}