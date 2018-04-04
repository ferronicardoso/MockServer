using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MockServer.Enums
{
    public enum ResponseStatusType
    {
        [Description("Continue")]
        CONTINUE = 100,
        [Description("Switching Protocols")]
        SWITCHING_PROTOCOLS = 101,
        [Description("Processing")]
        PROCESSING = 102,
        [Description("OK")]
        OK = 200,
        [Description("Created")]
        CREATED = 201,
        [Description("Accepted")]
        ACCEPTED = 202,
        [Description("Non-Authoritative Information")]
        NON_AUTHORITATIVE_INFORMATION = 203,
        [Description("No Content")]
        NO_CONTENT = 204,
        [Description("Reset Content")]
        RESET_CONTENT = 205,
        [Description("Partial Content")]
        PARTIAL_CONTENT = 206,
        [Description("Multi-Status")]
        MULTI_STATUS = 207,
        [Description("Already Reported")]
        ALREADY_REPORTED = 208,
        [Description("IM Used")]
        IM_USED = 226,
        [Description("Multiple Choices")]
        MULTIPLE_CHOICES = 300,
        [Description("Moved Permanently")]
        MOVED_PERMANENTLY = 301,
        [Description("Found")]
        FOUND = 302,
        [Description("See Other")]
        SEE_OTHER = 303,
        [Description("Not Modified")]
        NOT_MODIFIED = 304,
        [Description("Use Proxy")]
        USE_PROXY = 305,
        [Description("Switch Proxy")]
        SWITCH_PROXY = 306,
        [Description("Temporary Redirect")]
        TEMPORARY_REDIRECT = 307,
        [Description("Permanent Redirect")]
        PERMANENT_REDIRECT = 308,
        [Description("Bad Request")]
        BAD_REQUEST = 400,
        [Description("Unauthorized")]
        UNAUTHORIZED = 401,
        [Description("Payment Required")]
        PAYMENT_REQUIRED = 402,
        [Description("Forbidden")]
        FORBIDDEN = 403,
        [Description("Not Found")]
        NOT_FOUND = 404,
        [Description("Method Not Allowed")]
        METHOD_NOT_ALLOWED = 405,
        [Description("Not Acceptable")]
        NOT_ACCEPTABLE = 406,
        [Description("Proxy Authentication Required")]
        PROXY_AUTHENTICATION_REQUIRED = 407,
        [Description("Request Timeout")]
        REQUEST_TIMEOUT = 408,
        [Description("Conflict")]
        CONFLICT = 409,
        [Description("Gone")]
        GONE = 410,
        [Description("Length Required")]
        LENGTH_REQUIRED = 411,
        [Description("Precondition Failed")]
        PRECONDITION_FAILED = 412,
        [Description("Request Entity Too Large")]
        REQUEST_ENTITY_TOO_LARGE = 413,
        [Description("Request-URI Too Long")]
        REQUEST_URI_TOO_LONG = 414,
        [Description("Unsupported Media Type")]
        UNSUPPORTED_MEDIA_TYPE = 415,
        [Description("Requested Range Not Satisfiable")]
        REQUESTED_RANGE_NOT_SATISFIABLE = 416,
        [Description("Expectation Failed")]
        EXPECTATION_FAILED = 417,
        [Description("I'm a teapot")]
        IM_A_TEAPOT = 418,
        [Description("Authentication Timeout")]
        AUTHENTICATION_TIMEOUT = 419,
        [Description("Enhance Your Calm")]
        ENHANCE_YOUR_CALM = 420,
        [Description("Unprocessable Entity")]
        UNPROCESSABLE_ENTITY = 422,
        [Description("Locked")]
        LOCKED = 423,
        [Description("Failed Dependency")]
        FAILED_DEPENDENCY = 424,
        [Description("Method Failure")]
        METHOD_FAILURE = 424,
        [Description("Unordered Collection")]
        UNORDERED_COLLECTION = 425,
        [Description("Upgrade Required")]
        UPGRADE_REQUIRED = 426,
        [Description("Precondition Required")]
        PRECONDITION_REQUIRED = 428,
        [Description("Too Many Requests")]
        TOO_MANY_REQUESTS = 429,
        [Description("Request Header Fields Too Large")]
        REQUEST_HEADER_FIELDS_TOO_LARGE = 431,
        [Description("No Response")]
        NO_RESPONSE = 444,
        [Description("Retry With")]
        RETRY_WITH = 449,
        [Description("Blocked by Windows Parental Controls")]
        BLOCKED_BY_WINDOWS_PARENTAL_CONTROLS = 450,
        [Description("Unavailable For Legal Reasons")]
        UNAVAILABLE_FOR_LEGAL_REASONS = 451,
        [Description("Redirect")]
        REDIRECT = 451,
        [Description("Request Header Too Large")]
        REQUEST_HEADER_TOO_LARGE = 494,
        [Description("Cert Error")]
        CERT_ERROR = 495,
        [Description("No Cert")]
        NO_CERT = 496,
        [Description("HTTP to HTTPS")]
        HTTP_TO_HTTPS = 497,
        [Description("Client Closed Request")]
        CLIENT_CLOSED_REQUEST = 499,
        [Description("Internal Server Error")]
        INTERNAL_SERVER_ERROR = 500,
        [Description("Not Implemented")]
        NOT_IMPLEMENTED = 501,
        [Description("Bad Gateway")]
        BAD_GATEWAY = 502,
        [Description("Service Unavailable")]
        SERVICE_UNAVAILABLE = 503,
        [Description("Gateway Timeout")]
        GATEWAY_TIMEOUT = 504,
        [Description("HTTP Version Not Supported")]
        HTTP_VERSION_NOT_SUPPORTED = 505,
        [Description("Variant Also Negotiates")]
        VARIANT_ALSO_NEGOTIATES = 506,
        [Description("Insufficient Storage")]
        INSUFFICIENT_STORAGE = 507,
        [Description("Loop Detected")]
        LOOP_DETECTED = 508,
        [Description("Bandwidth Limit Exceeded")]
        BANDWIDTH_LIMIT_EXCEEDED = 509,
        [Description("Not Extended")]
        NOT_EXTENDED = 510,
        [Description("Network Authentication Required")]
        NETWORK_AUTHENTICATION_REQUIRED = 511,
        [Description("Network read timeout error")]
        NETWORK_READ_TIMEOUT_ERROR = 598,
        [Description("Network connect timeout error")]
        NETWORK_CONNECT_TIMEOUT_ERROR = 599
    }
}