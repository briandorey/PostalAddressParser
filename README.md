Postal Address Parser
===================

A simple C# postal address parser to format the input address in international formats for postal labels.

I have included 3 different formatting modes into the class but it is simple to add extra formats and countries if needed.

Usage:

    ParseAddress(string CustomerName, string Organisation, string address1, string address2, string address3, string address4, string address5, string town, string county, string postcode, string country, bool returnhtml)
Returns a string containing the formatted address
