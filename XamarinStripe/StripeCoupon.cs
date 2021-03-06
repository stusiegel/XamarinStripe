/*
 * Copyright 2011 Joe Dluzen, 2012 Xamarin, Inc.
 *
 * Author(s):
 *  Joe Dluzen (jdluzen@gmail.com)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using Newtonsoft.Json;

namespace Xamarin.Payments.Stripe {
    [JsonObject (MemberSerialization.OptIn)]
    public class StripeCoupon : StripeId {
        [JsonProperty (PropertyName = "times_redeemed")]
        public int TimesRedeemed { get; set; }

        [JsonProperty (PropertyName = "livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty (PropertyName = "duration")]
        public StripeCouponDuration Duration { get; set; }

        [JsonProperty (PropertyName = "percent_off")]
        public int PercentOff { get; set; }

        [JsonProperty (PropertyName = "deleted")]
        public bool? Deleted { get; set; }
    }
}
