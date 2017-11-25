WePay.NET
=================
A complete C# Library for integrating with WePay's API

Table of Contents
=================

  * [WePay.NET](#wePay.NET)
  * [Table of Contents](#table-of-contents)
  * [Structure](#structure)
  * [User](#user)
  * [Account](#account)
  * [Checkout](#checkout)
  * [Callbacks](#callbacks)
  
Structure
=================
The root namespace is `WePay` and this library namespacing structure tries to follow the API reference (https://developer.wepay.com/api/) as closely as possible.

Each WePay API endpoint is given its own namespace (e.g. `User`, `Account`, `Checkout`, `CreditCard` etc.). Each namespace will generally follow the structure below,
  * `WePay.<API>.Common`
  * `WePay.<API>.Request`
  * `WePay.<API>.Response`
  * `WePay.<API>.Structure`
  * `WePay.<API>.<API>Service` (e.g. `WePay.User.UserService`, `WePay.Account.AccountService`, `WePay.Checkout.CheckoutService`)

`WePay.<API>.Commmon` contains predefined values that WePay uses for that API endpoint, these are values that are not free form but rather values for fields which can only come from a predefined list of values. `WePay.Shared.Common` contains the predfined value which are used across differing API endpoints (e.g. `Currencies`, `Countries` etc.)

`WePay.<API>.Request` contains the actual request objects for a given API endpoint.

`WePay.<API>.Response` contains the actual response objects for a given API endpoint.

`WePay.<API>.Structure` contains all the substructures used in the requests and responses for a given API endpoint. `WePay.Shared.Structure` contains the substructures used in requests and responses which are used across differing API endpoints (e.g. `Address`, `ShippingAddress`, `Theme` etc.).

`WePay.<API>.<API>Service` is a class which contains all the actual API endpoints as functions. Each class itself is initialized with a constructor that takes 3 values,
  * a `bool`, `enableValidation` (defaults to `false`), this enables validation of the request objects and will throw an error if the request is malformed according to the WePay API Reference (e.g. You specified an invalid country or currency etc.). PLEASE NOTE THIS IS CURRENTLY NOT FUNCTIONING CORRECTLY, I will be working on it soon.
  * a `string`, `accessToken` (defaults to `null`), this is the actual Access Token which is REQUIRED to make any request to the WePay API.
  * a `bool`, `useStaging` (defaults to `false`), this toggles whether or not the requests should use the staging WePay API urls instead of the production API urls.

The functions in each `WePay.<API>.<API>Service` generally (with very few exceptions) follow the same structure they take as arguments,
  * a `WePay.<API>.Request` object.
  * a `string`, `accessToken` (defaults to `null`) which is used to override the constructor's value of `accessToken` if so desired.
  * a `bool`, `useStaging` (defaults to `null`) which is used to override the constructor's value of `useStaging` if so desired.
  
Please note that all functions are Async, and unless there is strong feedback requesting non-Async versions of the functions, it will likely stay this way.

Each `WePay.<API>.<API>Service` inherits from `WePay.Shared.WePayApiService<T>`, and provides a `public readonly List<string> EndPoints` which are the suffixes of the WePay API endpoint Urls used in each function. Please note, should you decide to venture out on your own that you will need to prefix these strings with either,
  * https://stage.wepayapi.com/INSERT_VERSION_HERE/ for staging,
  * https://wepayapi.com/INSERT_VERSION_HERE/ for production.

Each `WePay.<API>.Structure`, `WePay.<API>.Request` and `WePay.<API>.Response` object is documented within the code about each field and where the predefined values can be found (if it accepts predefined values), if it's required or not and what the specific requirements are (e.g. max length of string, min length of string etc.).

Generally, each `WePay.<API>.Common` object contains,
  * A bunch of `public const string`'s which are the actual predefined values.
  * A `public static readonly List<string> Values` of all the values, so they can be iterated through.
  * An `enum` called `ValueIndices` which contains all the named indices for `Values`
  
I know this structure is not perfect by any means, but my hope is that everyone will find it versatile enough to make use of it regardless of their needs. If this is not the case, please let me know so I can make revisions to allow for more flexibility. More to come! Thanks! :)

User
====

First you need to initialize the service,

    var wePayUserService = new WePay.User.UserService(false, ACCESS_TOKEN, false);

Then we can register a user,

    var registerResponse = await wePayUserService.RegisterAsync(new WePay.User.Request.RegisterRequest
    {
        ClientId = CLIENT_ID,
        ClientSecret = CLIENT_SECRET,
        Email = "example@example.com",
        Scope = WePay.User.Common.Scopes.AllowAllScopes(),
        FirstName = "John",
        LastName = "Doe",
        OriginalIp = IP_ADDRESS,
        OriginalDevice = USER_AGENT,
        TosAcceptanceTime = DateTimeOffset.UtcNow.Ticks,
        RedirectUri = "https://www.yourWebsiteGoesHere.com",
        CallbackUri = "https://www.yourApiUrlGoesHere.com"
    });

Then you can send a user confirmation email as follows,

    var sendConfirmationResponse = await wePayUserService.SendConfirmationAsync(new WePay.User.Request.SendConfirmationRequest
    {
        EmailMessage = "Please give us money with this.",
        EmailButtonText = "Click to Money",
        EmailSubject = "Hey You got WePay Now :)"
    }, WE_PAY_USER_ACCESS_TOKEN);
    
Account
=======

First you need to initialize the service,

    var wePayAccountService = new WePay.Account.AccountService(false, ACCESS_TOKEN, false);

Then we need to build up the Rbits (Risk data) for the account create request,

    long recieveTime = DateTimeOffset.UtcNow.Ticks / TimeSpan.TicksPerSecond;
    string source = WePay.Risk.Common.Sources.User;

    var businessNameRbit = new WePay.Risk.Structure.Rbit.BusinessNameRbit
    {
         ReceiveTime = recieveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.BusinessNameRbitProperties
         {
             BusinessName = "Example LLC"
         }
     };
     
     var personRbit = new WePay.Risk.Structure.Rbit.PersonRbit
     {
         ReceiveTime = recieveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.PersonRbitProperties
         {
             Name = "John Doe"
         }
     };

     var emailAddressRbit = new WePay.Risk.Structure.Rbit.EmailRbit
     {
         ReceiveTime = recieveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.EmailRbitProperties
         {
             Email = "example@example.com"
         }
     };

     var phoneNumberRbit = new WePay.Risk.Structure.Rbit.PhoneRbit
     {
          ReceiveTime = recieveTime,
          Source = source,
          Properties = new WePay.Risk.Structure.Rbit.RbitProperties.PhoneRbitProperties
          {
              Phone = "555-555-5555"
          }
     };
     
     var websiteUriRbit = new WePay.Risk.Structure.Rbit.WebsiteUriRbit
     {
          ReceiveTime = recieveTime,
          Source = source,
          Properties = new WePay.Risk.Structure.Rbit.RbitProperties.WebsiteUriRbitProperties
          {
               Uri = "https://www.examplellc.com"
          }
     };

     var businessAddressRbit = new WePay.Risk.Structure.Rbit.AddressRbit
     {
          ReceiveTime = recieveTime,
          Source = source,
          Properties = new WePay.Risk.Structure.Rbit.RbitProperties.AddressRbitProperties
          {
               Address = new WePay.Shared.Structure.Address
               {
                    Address1 = "123 Example Street",
                    Address2 = "Suite 123",
                    City = "Manhattan",
                    Region = "NY",
                    PostalCode = "12345",
                    Country = "US"
               }
          }
     };
     
     var industryCodeRbit = new WePay.Risk.Structure.Rbit.IndustryCodeRbit
     {
          ReceiveTime = recieveTime,
          Source = source,
          Properties = new WePay.Risk.Structure.Rbit.RbitProperties.IndustryCodeRbitProperties
          {
               IndustryCode = "",
               IndustryCodeType = WePay.Risk.Common.IndustryCodeTypes.Mcc,
               IndustryDetail = "Example LLC"
          }
     };
     
     var businessDescriptionRbit = new WePay.Risk.Structure.Rbit.BusinessDescriptionRbit
     {
          ReceiveTime = recieveTime,
          Source = source,
          Properties = new WePay.Risk.Structure.Rbit.RbitProperties.BusinessDescriptionRbitProperties
          {
                BusinessDescription = "Example LLC merchant",
                NumberOfEmployees = 300
          }
     };
     
     var externalAccountRbit = new WePay.Risk.Structure.Rbit.ExternalAccountRbit
     {
           ReceiveTime = organization.CreatedAt.Value.UtcTicks / TimeSpan.TicksPerSecond,
           Source = WePay.Risk.Common.Sources.PartnerDatabase,
           Properties = new WePay.Risk.Structure.Rbit.RbitProperties.ExternalAccountRbitProperties
           {
                IsPartnerAccount = WePay.Risk.Common.IsPartnerAccountOptions.Yes,
                AccountType = "Field Nimble " + organization.CreatedAt.Value.ToString("F")
           }
      };
      
      var accountCreateRbits = new WePay.Risk.Structure.Rbit.Rbit[]
      {
            businessNameRbit,
            personRbit,
            emailAddressRbit,
            phoneNumberRbit,
            websiteUriRbit,
            businessAddressRbit,
            industryCodeRbit,
            businessDescriptionRbit,
            externalAccountRbit
       };
       
Now we can build and make the actual Account create request,

    var createResponse = await wePayAccountService.CreateAsync(new WePay.Account.Request.CreateRequest {
         Name = "Example LLC Account",
         Description = "An account to receive payments for Example LLC",
         CallbackUri = "https://www.yourApiUrlGoesHere.com",
         ReferenceId = A_UNIQUE_STRING,
         Rbits = accountCreateRbits,
         Type = WePay.Account.Common.AccountTypes.Business
    }, WE_PAY_USER_ACCESS_TOKEN);
    
Now we can modify an Account later if so desired,

    var modifyResponse = await wePayAccountService.ModifyAsync(new WePay.Account.Request.ModifyRequest {
        AccountId = AN_ACCOUNT_ID,
        Name = "I changed it",
        Description = "Because I wanted to"
    }, WE_PAY_USER_ACCESS_TOKEN);
    
Or we can delete an Account,

    var stateResponse = await wePayAccountService.DeleteAsync(new WePay.Account.Request.DeleteRequest
    {
         AccountId = AN_ACCOUNT_ID,
         Reason = "Because I felt like it."
    }, WE_PAY_USER_ACCESS_TOKEN);
    
Checkout
========

First we need to initialize the service

    var wePayCheckoutService = new WePay.Checkout.CheckoutService(false, ACCESS_TOKEN, false);
    
Then we need to build up the Payer Rbits (Risk data) for the Checkout create request,

    long receiveTime = DateTimeOffset.UtcNow.Ticks / TimeSpan.TicksPerSecond;
    string source = WePay.Risk.Common.Sources.User;
    
    var emailAddressRbit = new WePay.Risk.Structure.Rbit.EmailRbit
    {
         ReceiveTime = receiveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.EmailRbitProperties
         {
              Email = PAYERS_EMAIL
         }
    };
    
    var personRbit = new WePay.Risk.Structure.Rbit.PersonRbit
    {
         ReceiveTime = receiveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.PersonRbitProperties
         {
             Name = PAYERS_FIRST_NAME + " " + PAYERS_LAST_NAME
         }
    };

    var phoneNumberRbit = new WePay.Risk.Structure.Rbit.PhoneRbit
    {
         ReceiveTime = receiveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.PhoneRbitProperties
         {
             Phone = PAYERS_PHONE_NUMBER
         }
    };
    
    var addressRbit = new WePay.Risk.Structure.Rbit.AddressRbit
    {
         ReceiveTime = receiveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.AddressRbitProperties
         {
              Address = new WePay.Shared.Structure.Address
              {
                  PostalCode = PAYERS_POSTAL_CODE
              }
         }
    };
            
    var checkoutCreatePayerRbits = new WePay.Risk.Structure.Rbit.Rbit[]
    {
        emailAddressRbit,
        personRbit,
        phoneNumberRbit,
        addressRbit
    };
    
Then we need to build up the Transaction Rbits (Risk data) for the Checkout create request,

    var transactionDetailRbit = new WePay.Risk.Structure.Rbit.TransactionDetailsRbit
    {
         ReceiveTime = receiveTime,
         Source = source,
         Properties = new WePay.Risk.Structure.Rbit.RbitProperties.TransactionDetailsRbitProperties
         {
              ItemizedReceipt = new List<WePay.Risk.Structure.ReceiptLineItem>() {
                   new WePay.Risk.Structure.ReceiptLineItem
                   {
                        Description = "A cool thing",
                        Currency = WePay.Shared.Common.Currencies.USD,
                        Quantity = 3,
                        ServiceBillingMethod = WePay.Risk.Common.ServiceBillingMethods.FreeFormEntry,
                        ProjectName = "Operation: Put food on the table",
                        ItemPrice = 300.00
                   },
                   new WePay.Risk.Structure.ReceiptLineItem
                   {
                        Description = "Another cool thing",
                        Currency = WePay.Shared.Common.Currencies.USD,
                        Quantity = 5,
                        ServiceBillingMethod = WePay.Risk.Common.ServiceBillingMethods.FreeFormEntry,
                        ProjectName = "Operation: Put the kids through college",
                        ItemPrice = 700.00
                   }
              },
              Discount = "I took off $20 bux ... after I charged them $100 for a restrictive software license >:)",
              Note = INVOICE_NUMBER_OR_SOMETHING,
              ServiceAddress = new WePay.Shared.Structure.Address
              {
                   Address1 = "123 Service Street",
                   Address2 = "Aparment 123",
                   City = "Manhattan",
                   Region = "NY",
                   PostalCode = "12345",
                   Country = WePay.Shared.Common.Countries.US
              },
              TermsText = ""
         }
    };

    var transactionDetailRbits = new WePay.Risk.Structure.Rbit.Rbit[]
    {
         transactionDetailRbit
    };

Now we can build and make the Checkout create request,

    var createResponse = await WePayCheckoutService.CreateAsync(new 
    {
        AccountId = ACCOUNT_ID,
        ShortDescription = "",
        Type = WePay.Checkout.Common.CheckoutTypes.Service,
        Amount = PAYMENT_AMOUNT,
        Currency = WePay.Shared.Common.Currencies.USD,
        Fee = new WePay.Checkout.Structure.Fee
        {
             AppFee = AMOUNT_YOUR_APP_COLLECTS_ON_THIS_CHECKOUT,
             FeePayer = WePay.Checkout.Common.FeePayers.Payee
        },
        EmailMessage = "HEYO",
        CallbackUri = CallbackUris.CheckoutCreate,
        ReferenceId = A_UNIQUE_STRING,
        UniqueId = ANOTHER_UNIQUE_STRING_BUT_COULD_BE_EQUAL_TO_REFERENCE_ID,
        PaymentMethod = new WePay.Checkout.Structure.PaymentMethod
        {
             Type = WePay.Checkout.Common.PaymentTypes.CreditCard,
             CreditCard = new WePay.CreditCard.Structure.CreditCard
             {
                 Id = CREDIT_CARD_ID,
                 Data = new WePay.CreditCard.Structure.CreditCardAdditionalData // or null if not coming from credit card reader
                 {
                     TransactionToken = EMV_TOKEN_FROM_CARD_READER
                 }
             }
        },
        PayerRbits = checkoutCreatePayerRbits,
        TransactionRbits = 
    }, WE_PAY_USER_ACCESS_TOKEN);
    
Now we can cancel Checkouts as follows,

    var cancelRequest = new WePay.Checkout.Request.CancelRequest
    {
         CheckoutId = CHECKOUT_ID
         CancelReason = "Cause I felt like it."
    };
    
Or we can refund Checkouts as follows,

    var refundRequest = new WePay.Checkout.Request.RefundRequest
    {
         CheckoutId = payment.WePayCheckout.CheckoutId,
         RefundReason = "Cause I felt like it."
    };

Callbacks
=========

Callbacks are how WePay updates your platform of any changes, they will send you request with an Id that corresponds to an `Account`, `User`, `Checkout` etc.

Use the `WePay.Shared.IpnNotification` object to recieve these requests and then route them as desired. This will typically entail making a request with that Id to see any changes and then taking action as you see fit, examples below,

    var userLookupResponse = await WePayUserService.LookupAsync(WE_PAY_USER_ACCESS_TOKEN);
    
    var accountLookupResponse = await WePayAccountService.LookupAsync(new WePay.Account.Request.LookupRequest
    {
         AccountId = accountId
    }, WE_PAY_USER_ACCESS_TOKEN);
                
    var checkoutLookupResponse = await WePayCheckoutService.LookupAsync(new WePay.Checkout.Request.LookupRequest
    {
         CheckoutId = CHECKOUT_ID
    });
    
More on the way! :)
