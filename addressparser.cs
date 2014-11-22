using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressFormater
{
    public class AddressParser
    {
        public string ParseAddress(string CustomerName, string Organisation, string address1, string address2, string address3, string address4, string address5, string town, string county, string postcode, string country, bool returnhtml)
        {
            // create postal address object with address info
            PostalAddress deladdress = new PostalAddress(CustomerName, Organisation, address1, address2, address3, address4, address5, town, county, postcode, country);

            // select formatting mode from country name
            int switchmode = 0;
            switch (country)
            {
                case "Albania":
                    switchmode = 1;
                    break;
                case "Algeria":
                    switchmode = 1;
                    break;
                case "American Samoa":
                    switchmode = 1;
                    break;
                case "Andorra":
                    switchmode = 1;
                    break;
                case "Angola":
                    switchmode = 1;
                    break;
                case "Anguilla":
                    switchmode = 1;
                    break;
                case "Antarctica":
                    switchmode = 1;
                    break;
                case "Antigua and Barbuda":
                    switchmode = 1;
                    break;
                case "Aruba":
                    switchmode = 1;
                    break;
                case "Australia":
                    switchmode = 2;
                    break;
                case "Austria":
                    switchmode = 1;
                    break;
                case "Bahamas":
                    switchmode = 1;
                    break;
                case "Bahrain":
                    switchmode = 1;
                    break;
                case "Bangladesh":
                    switchmode = 1;
                    break;
                case "Barbados":
                    switchmode = 1;
                    break;
                case "Belarus":
                    switchmode = 1;
                    break;
                case "Belgium":
                    switchmode = 1;
                    break;
                case "Belize":
                    switchmode = 1;
                    break;
                case "Bermuda":
                    switchmode = 1;
                    break;
                case "Bhutan":
                    switchmode = 1;
                    break;
                case "Bolivia":
                    switchmode = 1;
                    break;
                case "Botswana":
                    switchmode = 1;
                    break;
                case "Bouvet Island":
                    switchmode = 1;
                    break;
                case "Brazil":
                    switchmode = 1;
                    break;
                case "British Indian Ocean Territory":
                    switchmode = 1;
                    break;
                case "British Virgin Islands":
                    switchmode = 1;
                    break;
                case "Brunei":
                    switchmode = 1;
                    break;
                case "Bulgaria":
                    switchmode = 1;
                    break;
                case "Burundi":
                    switchmode = 1;
                    break;
                case "Cambodia":
                    switchmode = 1;
                    break;
                case "Cameroon":
                    switchmode = 1;
                    break;
                case "Canada":
                    switchmode = 2;
                    break;
                case "Cayman Islands":
                    switchmode = 1;
                    break;
                case "Central African Republic":
                    switchmode = 1;
                    break;
                case "Chad":
                    switchmode = 1;
                    break;
                case "Channel Islands":
                    switchmode = 1;
                    break;
                case "Chile":
                    switchmode = 1;
                    break;
                case "Christmas Island":
                    switchmode = 1;
                    break;
                case "Cocos (Keeling) Islands":
                    switchmode = 1;
                    break;
                case "Colombia":
                    switchmode = 1;
                    break;
                case "Comoros":
                    switchmode = 1;
                    break;
                case "Cook Islands":
                    switchmode = 1;
                    break;
                case "Costa Rica":
                    switchmode = 1;
                    break;
                case "Croatia":
                    switchmode = 1;
                    break;
                case "Cuba":
                    switchmode = 1;
                    break;
                case "Cyprus":
                    switchmode = 1;
                    break;
                case "Czech Republic":
                    switchmode = 1;
                    break;
                case "Denmark":
                    switchmode = 1;
                    break;
                case "Djibouti":
                    switchmode = 1;
                    break;
                case "Dominica":
                    switchmode = 1;
                    break;
                case "Dominican Republic":
                    switchmode = 1;
                    break;
                case "East Timor":
                    switchmode = 1;
                    break;
                case "Ecuador":
                    switchmode = 1;
                    break;
                case "Egypt":
                    switchmode = 1;
                    break;
                case "El Salvador":
                    switchmode = 1;
                    break;
                case "Equatorial Guinea":
                    switchmode = 1;
                    break;
                case "Estonia":
                    switchmode = 1;
                    break;
                case "Ethiopia":
                    switchmode = 1;
                    break;
                case "Falkland Islands (Malvinas)":
                    switchmode = 1;
                    break;
                case "Faroe Islands":
                    switchmode = 1;
                    break;
                case "Federated States of Micronesia":
                    switchmode = 1;
                    break;
                case "Fiji":
                    switchmode = 1;
                    break;
                case "Finland":
                    switchmode = 1;
                    break;
                case "France":
                    switchmode = 1;
                    break;
                case "French Guiana":
                    switchmode = 1;
                    break;
                case "French Polynesia":
                    switchmode = 1;
                    break;
                case "French Southern Territories":
                    switchmode = 1;
                    break;
                case "Gabon":
                    switchmode = 1;
                    break;
                case "Georgia":
                    switchmode = 1;
                    break;
                case "Germany":
                    switchmode = 1;
                    break;
                case "Gibraltar":
                    switchmode = 1;
                    break;
                case "Greece":
                    switchmode = 1;
                    break;
                case "Greenland":
                    switchmode = 1;
                    break;
                case "Grenada":
                    switchmode = 1;
                    break;
                case "Guadeloupe":
                    switchmode = 1;
                    break;
                case "Guam":
                    switchmode = 1;
                    break;
                case "Guatemala":
                    switchmode = 1;
                    break;
                case "Guyana":
                    switchmode = 1;
                    break;
                case "Heard Island and McDonald Islands":
                    switchmode = 1;
                    break;
                case "Honduras":
                    switchmode = 1;
                    break;
                case "Hungary":
                    switchmode = 1;
                    break;
                case "Iceland":
                    switchmode = 1;
                    break;
                case "India":
                    switchmode = 2;
                    break;
                case "Indonesia":
                    switchmode = 2;
                    break;
                case "Ireland":
                    switchmode = 2;
                    break;
                case "Israel":
                    switchmode = 1;
                    break;
                case "Italy":
                    switchmode = 1;
                    break;
                case "Jamaica":
                    switchmode = 1;
                    break;
                case "Japan":
                    switchmode = 2;
                    break;
                case "Jordan":
                    switchmode = 1;
                    break;
                case "Kazakhstan":
                    switchmode = 1;
                    break;
                case "Kenya":
                    switchmode = 1;
                    break;
                case "Kiribati":
                    switchmode = 1;
                    break;
                case "Kuwait":
                    switchmode = 1;
                    break;
                case "Kyrgyzstan":
                    switchmode = 1;
                    break;
                case "Laos":
                    switchmode = 1;
                    break;
                case "Latvia":
                    switchmode = 1;
                    break;
                case "Lesotho":
                    switchmode = 1;
                    break;
                case "Liechtenstein":
                    switchmode = 1;
                    break;
                case "Lithuania":
                    switchmode = 1;
                    break;
                case "Luxembourg":
                    switchmode = 1;
                    break;
                case "Macedonia":
                    switchmode = 1;
                    break;
                case "Madagascar":
                    switchmode = 1;
                    break;
                case "Malawi":
                    switchmode = 1;
                    break;
                case "Malaysia":
                    switchmode = 1;
                    break;
                case "Maldives":
                    switchmode = 1;
                    break;
                case "Malta":
                    switchmode = 1;
                    break;
                case "Marshall Islands":
                    switchmode = 1;
                    break;
                case "Martinique":
                    switchmode = 1;
                    break;
                case "Mauritania":
                    switchmode = 1;
                    break;
                case "Mauritius":
                    switchmode = 1;
                    break;
                case "Mayotte":
                    switchmode = 1;
                    break;
                case "Metropolitan France":
                    switchmode = 1;
                    break;
                case "Mexico":
                    switchmode = 1;
                    break;
                case "Monaco":
                    switchmode = 1;
                    break;
                case "Mongolia":
                    switchmode = 1;
                    break;
                case "Montserrat":
                    switchmode = 1;
                    break;
                case "Morocco":
                    switchmode = 1;
                    break;
                case "Mozambique":
                    switchmode = 1;
                    break;
                case "Myanmar":
                    switchmode = 1;
                    break;
                case "Namibia":
                    switchmode = 1;
                    break;
                case "Nauru":
                    switchmode = 1;
                    break;
                case "Nepal":
                    switchmode = 1;
                    break;
                case "Netherlands":
                    switchmode = 1;
                    break;
                case "Netherlands Antilles":
                    switchmode = 1;
                    break;
                case "New Caledonia":
                    switchmode = 1;
                    break;
                case "New Zealand":
                    switchmode = 2;
                    break;
                case "Nicaragua":
                    switchmode = 1;
                    break;
                case "Niue":
                    switchmode = 1;
                    break;
                case "Norfolk Island":
                    switchmode = 1;
                    break;
                case "Northern Mariana Islands":
                    switchmode = 1;
                    break;
                case "Norway":
                    switchmode = 1;
                    break;
                case "Oman":
                    switchmode = 1;
                    break;
                case "Palau":
                    switchmode = 1;
                    break;
                case "Panama":
                    switchmode = 1;
                    break;
                case "Papua New Guinea":
                    switchmode = 1;
                    break;
                case "Paraguay":
                    switchmode = 1;
                    break;
                case "Peru":
                    switchmode = 1;
                    break;
                case "Philippines":
                    switchmode = 1;
                    break;
                case "Pitcairn":
                    switchmode = 1;
                    break;
                case "Poland":
                    switchmode = 1;
                    break;
                case "Portugal":
                    switchmode = 1;
                    break;
                case "Puerto Rico":
                    switchmode = 1;
                    break;
                case "Qatar":
                    switchmode = 1;
                    break;
                case "Reunion":
                    switchmode = 1;
                    break;
                case "Romania":
                    switchmode = 1;
                    break;
                case "Russia":
                    switchmode = 1;
                    break;
                case "Rwanda":
                    switchmode = 1;
                    break;
                case "Samoa":
                    switchmode = 1;
                    break;
                case "San Marino":
                    switchmode = 1;
                    break;
                case "Sao Tome and Principe":
                    switchmode = 1;
                    break;
                case "Saudia Arabia":
                    switchmode = 1;
                    break;
                case "Seychelles":
                    switchmode = 1;
                    break;
                case "Singapore":
                    switchmode = 2;
                    break;
                case "Slovakia":
                    switchmode = 1;
                    break;
                case "Slovenia":
                    switchmode = 1;
                    break;
                case "Solomon Islands":
                    switchmode = 1;
                    break;
                case "South Africa":
                    switchmode = 2;
                    break;
                case "South Georgia and the South Sandwich Islands":
                    switchmode = 1;
                    break;
                case "South Korea":
                    switchmode = 2;
                    break;
                case "Spain":
                    switchmode = 1;
                    break;
                case "Sri Lanka":
                    switchmode = 1;
                    break;
                case "St. Helena":
                    switchmode = 1;
                    break;
                case "St. Kitts and Nevis":
                    switchmode = 1;
                    break;
                case "St. Lucia":
                    switchmode = 1;
                    break;
                case "St. Pierre and Miquelon":
                    switchmode = 1;
                    break;
                case "St. Vincent and the Grenadines":
                    switchmode = 1;
                    break;
                case "Suriname":
                    switchmode = 1;
                    break;
                case "Svalbard and Jan Mayen Islands":
                    switchmode = 1;
                    break;
                case "Swaziland":
                    switchmode = 1;
                    break;
                case "Sweden":
                    switchmode = 1;
                    break;
                case "Switzerland":
                    switchmode = 1;
                    break;
                case "Syria":
                    switchmode = 1;
                    break;
                case "Tajikistan":
                    switchmode = 1;
                    break;
                case "Tanzania":
                    switchmode = 1;
                    break;
                case "Thailand":
                    switchmode = 1;
                    break;
                case "Tokelau":
                    switchmode = 1;
                    break;
                case "Tonga":
                    switchmode = 1;
                    break;
                case "Trinidad and Tobago":
                    switchmode = 1;
                    break;
                case "Tunisia":
                    switchmode = 1;
                    break;
                case "Turkey":
                    switchmode = 1;
                    break;
                case "Turkmenistan":
                    switchmode = 1;
                    break;
                case "Turks and Caicos Islands":
                    switchmode = 1;
                    break;
                case "Tuvalu":
                    switchmode = 1;
                    break;
                case "U.S. Virgin Islands":
                    switchmode = 1;
                    break;
                case "Uganda":
                    switchmode = 1;
                    break;
                case "Ukraine":
                    switchmode = 1;
                    break;
                case "United Arab Emirates":
                    switchmode = 1;
                    break;
                case "United Kingdom":
                    switchmode = 0;
                    break;
                case "United States":
                    switchmode = 2;
                    break;
                case "United States Minor Outlying Islands":
                    switchmode = 1;
                    break;
                case "Uruguay":
                    switchmode = 1;
                    break;
                case "Uzbekistan":
                    switchmode = 1;
                    break;
                case "Vanuatu":
                    switchmode = 1;
                    break;
                case "Vatican City":
                    switchmode = 1;
                    break;
                case "Venezuela":
                    switchmode = 1;
                    break;
                case "Vietnam":
                    switchmode = 1;
                    break;
                case "Wallis and Futuna Islands":
                    switchmode = 1;
                    break;
                case "Western Sahara":
                    switchmode = 1;
                    break;
                case "Yemen":
                    switchmode = 1;
                    break;
                case "Yugoslavia":
                    switchmode = 1;
                    break;
                case "Zambia":
                    switchmode = 1;
                    break;

                default:

                    break;
            }

            if (switchmode == 0)
            {
                return FormatUK(deladdress, returnhtml);
            }
            if (switchmode == 1)
            {
                return FormatPostCodeFirst(deladdress, returnhtml);
            }
            if (switchmode == 2)
            {
                return FormatPostCodeLast(deladdress, returnhtml);
            }

            return "";
        }

        string FormatUK(PostalAddress deladdress, bool returnhtml)
        {
            StringBuilder sb = new StringBuilder();

            if (deladdress.CustomerName.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.CustomerName + Environment.NewLine);
            }
            if (deladdress.Organisation.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Organisation + Environment.NewLine);
            }
            if (deladdress.Address1.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address1 + Environment.NewLine);
            }
            if (deladdress.Address2.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address2 + Environment.NewLine);
            }
            if (deladdress.Address3.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address3 + Environment.NewLine);
            }
            if (deladdress.Address4.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address4 + Environment.NewLine);
            }
            if (deladdress.Address5.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address5 + Environment.NewLine);
            }
            if (deladdress.Town.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Town.ToUpper() + Environment.NewLine);
            }
            if (deladdress.County.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.County.ToUpper() + Environment.NewLine);
            }
            if (deladdress.Postcode.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Postcode.ToUpper());
            }
            if (returnhtml)
            {
                return sb.Replace(Environment.NewLine, "<br>").ToString();
            }
            else
            {
                return sb.ToString();
            }


        }
        string FormatPostCodeLast(PostalAddress deladdress, bool returnhtml)
        {

            StringBuilder sb = new StringBuilder();

            if (deladdress.CustomerName.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.CustomerName + Environment.NewLine);
            }
            if (deladdress.Organisation.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Organisation + Environment.NewLine);
            }
            if (deladdress.Address1.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address1 + Environment.NewLine);
            }
            if (deladdress.Address2.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address2 + Environment.NewLine);
            }
            if (deladdress.Address3.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address3 + Environment.NewLine);
            }
            if (deladdress.Address4.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address4 + Environment.NewLine);
            }
            if (deladdress.Address5.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address5 + Environment.NewLine);
            }
           

            if (deladdress.Town.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Town.ToUpper() + " " );
            }
            if (deladdress.County.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.County.ToUpper() + " " );
            }
            if (deladdress.Postcode.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Postcode.ToUpper() + " " );
            }
            sb.Append(Environment.NewLine + deladdress.Country.ToUpper().ToString());

            if (returnhtml)
            {
                return sb.Replace(Environment.NewLine, "<br>").ToString();
            }
            else
            {
                return sb.ToString();
            }

        }
        string FormatPostCodeFirst(PostalAddress deladdress, bool returnhtml)
        {
            StringBuilder sb = new StringBuilder();

            if (deladdress.CustomerName.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.CustomerName + Environment.NewLine);
            }
            if (deladdress.Organisation.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Organisation + Environment.NewLine);
            }
            if (deladdress.Address1.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address1 + Environment.NewLine);
            }
            if (deladdress.Address2.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address2 + Environment.NewLine);
            }
            if (deladdress.Address3.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address3 + Environment.NewLine);
            }
            if (deladdress.Address4.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address4 + Environment.NewLine);
            }
            if (deladdress.Address5.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Address5 + Environment.NewLine);
            }
            if (deladdress.Postcode.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Postcode.ToUpper() + " ");
            }

            if (deladdress.Town.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.Town.ToUpper() + " ");
            }
            if (deladdress.County.ToString().Trim().Length > 0)
            {
                sb.Append(deladdress.County.ToUpper() + " ");
            }

            sb.Append(Environment.NewLine + deladdress.Country.ToUpper().ToString() + Environment.NewLine);

            if (returnhtml)
            {
                return sb.Replace(Environment.NewLine, "<br>").ToString();
            }
            else
            {
                 return sb.ToString();
            }

        }

    }

    public class PostalAddress
    {
        // PostalAddress object getters and setters
        public string CustomerName { get; set; }
        public string Organisation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }

        public PostalAddress(string customername, string organisation, string address1, string address2, string address3, string address4, string address5, string town, string county, string postcode, string country)
        {
            CustomerName = customername;
            Organisation = organisation;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            Address4 = address4;
            Address5 = address5;
            Town = town;
            County = county;
            Postcode = postcode;
            Country = country;
        }
    }
}