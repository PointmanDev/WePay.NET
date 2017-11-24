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
