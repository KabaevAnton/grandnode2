﻿using Grand.Domain.Payments;
using MediatR;

namespace Grand.Business.Core.Commands.Checkout.Orders;

public class RefundOfflineCommand : IRequest<bool>
{
    public PaymentTransaction PaymentTransaction { get; set; }
}