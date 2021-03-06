﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.TestUtilities;
using Xunit;

namespace Microsoft.AspNet.WebHooks
{
    public class InstagramNotificationTests
    {
        private InstagramNotification _notification = new InstagramNotification();

        [Fact]
        public void ChangedAspect_Roundtrips()
        {
            PropertyAssert.Roundtrips(_notification, n => n.ChangedAspect, PropertySetter.NullRoundtrips, roundtripValue: "Value");
        }

        [Fact]
        public void Object_Roundtrips()
        {
            PropertyAssert.Roundtrips(_notification, n => n.Object, PropertySetter.NullRoundtrips, roundtripValue: "Value");
        }

        [Fact]
        public void UserId_Roundtrips()
        {
            PropertyAssert.Roundtrips(_notification, n => n.UserId, PropertySetter.NullRoundtrips, roundtripValue: "Value");
        }

        [Fact]
        public void SubscriptionId_Roundtrips()
        {
            PropertyAssert.Roundtrips(_notification, n => n.SubscriptionId, PropertySetter.NullRoundtrips, roundtripValue: "Value");
        }
    }
}
