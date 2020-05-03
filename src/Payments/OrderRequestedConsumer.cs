﻿using System;
using System.Threading.Tasks;
using MassTransit;
using Messages;

namespace Payments
{
    public class OrderRequestedConsumer : IConsumer<OrderRequested>
    {
        public async Task Consume(ConsumeContext<OrderRequested> context)
        {
            if (TakePayment(context.Message))
            {
                await context.Publish<IOrderAccepted>(new { context.Message.Products });
            }
            else
            {
                throw new Exception("Payment Failed");
            }
        }

        private bool TakePayment(OrderRequested contextMessage)
        {
            // 1 in 10 payments fail
            var paymentFailed = Random.Next(1, 10) == 1;

            if (paymentFailed) Console.WriteLine("Payment Failed");
            if (!paymentFailed) Console.WriteLine("Payment Successful");

            return !paymentFailed;
        }

        private static readonly Random Random = new Random();
    }
}