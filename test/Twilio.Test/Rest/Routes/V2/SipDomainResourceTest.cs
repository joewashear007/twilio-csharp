/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Routes.V2;

namespace Twilio.Tests.Rest.Routes.V2
{

    [TestFixture]
    public class SipDomainTest : TwilioTest
    {
        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Routes,
                "/v2/SipDomains/sip_domain",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SipDomainResource.Update("sip_domain", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"url\": \"https://routes.twilio.com/v2/SipDomains/test.sip.twilio.com\",\"sip_domain\": \"test.sip.twilio.com\",\"sid\": \"QQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"voice_region\": \"au1\",\"date_created\": \"2020-08-07T22:29:24Z\",\"date_updated\": \"2020-08-07T22:29:24Z\"}"
                                     ));

            var response = SipDomainResource.Update("sip_domain", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Routes,
                "/v2/SipDomains/sip_domain",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SipDomainResource.Fetch("sip_domain", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"url\": \"https://routes.twilio.com/v2/SipDomains/test.sip.twilio.com\",\"account_sid\": \"AC00000000000000000000000000000000\",\"sid\": \"QQ00000000000000000000000000000000\",\"sip_domain\": \"test.sip.twilio.com\",\"friendly_name\": \"string\",\"voice_region\": \"string\",\"date_created\": \"2022-06-02T22:33:47Z\",\"date_updated\": \"2022-06-02T22:33:47Z\"}"
                                     ));

            var response = SipDomainResource.Fetch("sip_domain", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}