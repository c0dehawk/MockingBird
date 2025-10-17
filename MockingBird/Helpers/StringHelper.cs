using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MockingBird.Helpers
{

    internal static class StringHelper
    {
        private static readonly Random _random = new Random();

        private static readonly List<string> FirstNames = new List<string>
        {
            "James", "Maria", "Léa", "José", "Mārtiņš",
            "Anna", "John", "Émile", "Søren", "Zoë",
            "Michael", "Chloé", "Renée", "Björn", "Łukasz",
            "Emily", "David", "François", "Álvaro", "Isla",
            "Daniel", "Sofia", "André", "Mikaël", "Tímea",
            "William", "Emma", "Ömer", "Lucía", "Nina",
            "Matthew", "Olivia", "Jürgen", "Tobías", "Eléna",
            "Christopher", "Amélie", "Stefán", "Noémie", "Göran",
            "Joshua", "Camille", "Dávid", "Inés", "Márta",
            "Andrew", "Ariane", "Róbert", "Yasmin", "Zoltán"
        };

        private static readonly List<string> LastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones",
            "García", "Müller", "O’Connor", "López", "Dvořák",
            "Martínez", "Nguyen", "Kovačić", "Anderson", "Thomas",
            "Taylor", "Moore", "Jackson", "Martin", "Lee",
            "Pérez", "Sánchez", "Dubois", "Núñez", "Grønning",
            "Schröder", "Hernández", "Kowalski", "Silva", "Rossi",
            "Novák", "Smirnov", "Björk", "Takahashi", "Kim",
            "Chen", "Patel", "Singh", "Kumar", "Ali",
            "Åström", "Jónsdóttir", "Šimůnek", "Łukaszewski", "Živković",
            "François", "Miyamoto", "Öztürk", "Černý", "Håkansson"
        };

        private static readonly List<string> Domains = new List<string>
        {
            "gmail.com", "yahoo.com", "outlook.com", "hotmail.com", "aol.com",
            "icloud.com", "mail.com", "protonmail.com", "zoho.com", "gmx.com",
            "yandex.com", "live.com", "msn.com", "comcast.net", "verizon.net",
            "att.net", "sbcglobal.net", "cox.net", "bellsouth.net", "earthlink.net",
            "me.com", "mac.com", "fastmail.com", "hushmail.com", "tutanota.com",
            "rocketmail.com", "inbox.com", "mail.ru", "rediffmail.com", "naver.com",
            "163.com", "qq.com", "web.de", "btinternet.com", "blueyonder.co.uk",
            "virginmedia.com", "sky.com", "talktalk.net", "ntlworld.com", "wanadoo.fr",
            "orange.fr", "free.fr", "laposte.net", "t-online.de", "seznam.cz",
            "mail.kz", "mail.bg", "mail.ua", "mail.pl", "mail.gr"
        };

        private static readonly List<string> Streets = new List<string>
       {
            "Maple Street", "Oak Avenue", "Pine Lane", "Cedar Road", "Elm Street",
            "Birch Way", "Willow Drive", "Spruce Court", "Cherry Lane", "Ash Street",
            "Hickory Drive", "Sycamore Road", "Magnolia Avenue", "Walnut Street", "Poplar Way",
            "Dogwood Lane", "Juniper Street", "Redwood Drive", "Beech Avenue", "Chestnut Court",
            "River Road", "Sunset Boulevard", "Hilltop Drive", "Highland Avenue", "Valley Road",
            "Mountain View Lane", "Forest Trail", "Canyon Drive", "Creekside Way", "Lakeview Road",
            "Lakeshore Drive", "Seaside Boulevard", "Ocean Avenue", "Bay Street", "Harbor Drive",
            "Marina Way", "Coral Street", "Palm Lane", "Driftwood Road", "Sand Dune Court",
            "Bayside Drive", "North Avenue", "South Street", "East Road", "West Boulevard",
            "Main Street", "Broadway", "Center Avenue", "Central Street", "Park Lane",
            "Parkside Drive", "Greenwood Avenue", "Riverbend Road", "Hillcrest Drive", "Glenview Street",
            "Brookside Lane", "Spring Street", "Autumn Avenue", "Winter Road", "Summer Lane",
            "Windy Ridge Drive", "Snowcap Road", "Thunder Lane", "Lightning Drive", "Stormy Way",
            "Clearwater Drive", "Bluebird Lane", "Eagle Ridge Road", "Falcon Street", "Deerfield Avenue",
            "Foxglove Lane", "Hawthorn Way", "Rosewood Drive", "Ivy Court", "Lily Street",
            "Daisy Lane", "Orchid Way", "Violet Avenue", "Lavender Road", "Tulip Street",
            "Goldenrod Drive", "Buttercup Lane", "Clover Court", "Thistle Way", "Meadow Street",
            "Briarwood Drive", "Ridgeway Road", "Stonebridge Lane", "Copperfield Street", "Ironwood Drive",
            "Granite Court", "Silver Lake Road", "Golden Hill Drive", "Crystal Avenue", "Pearl Street",
            "Amber Lane", "Emerald Drive", "Sapphire Way", "Topaz Street", "Diamond Boulevard"
        };

        private static readonly List<string> Cities = new List<string>
            {
            "New York", "Los Angeles", "Chicago", "Houston", "Phoenix",
            "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose",
            "Austin", "Jacksonville", "Fort Worth", "Columbus", "Charlotte",
            "San Francisco", "Indianapolis", "Seattle", "Denver", "Washington",
            "Boston", "El Paso", "Nashville", "Detroit", "Oklahoma City",
            "Portland", "Las Vegas", "Memphis", "Louisville", "Baltimore",
            "Milwaukee", "Albuquerque", "Tucson", "Fresno", "Sacramento",
            "Mesa", "Kansas City", "Atlanta", "Omaha", "Colorado Springs",
            "Raleigh", "Miami", "Long Beach", "Virginia Beach", "Oakland",
            "Minneapolis", "Tulsa", "Tampa", "Arlington", "New Orleans",
            "Wichita", "Cleveland", "Bakersfield", "Aurora", "Anaheim",
            "Honolulu", "Santa Ana", "Riverside", "Corpus Christi", "Lexington",
            "Henderson", "Stockton", "Saint Paul", "Cincinnati", "St. Louis",
            "Pittsburgh", "Greensboro", "Anchorage", "Plano", "Lincoln",
            "Orlando", "Irvine", "Newark", "Toledo", "Durham",
            "Chula Vista", "Fort Wayne", "Jersey City", "St. Petersburg", "Laredo",
            "Madison", "Chandler", "Buffalo", "Lubbock", "Scottsdale",
            "Reno", "Glendale", "Gilbert", "Winston-Salem", "North Las Vegas",
            "Norfolk", "Chesapeake", "Garland", "Irving", "Hialeah",
            "Fremont", "Boise", "Richmond", "Baton Rouge", "Spokane"
        };

        private static readonly List<string> States = new List<string>
       {
            "AL", "AK", "AZ", "AR", "CA",
            "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA",
            "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO",
            "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH",
            "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT",
            "VA", "WA", "WV", "WI", "WY"
        };

        private static readonly List<string> Companies = new List<string>
       {
            "Silverline Analytics",
            "NextGen Labs",
            "FusionCore Industries",
            "BrightPath Consulting",
            "Skyward Ventures",
            "EchoPoint Media",
            "Zenith Robotics",
            "NovaEdge Group",
            "Cloudspire Networks",
            "Radiant Logic",
            "StratusWorks",
            "OmniBridge Corp",
            "PulseTech Systems",
            "Vanguard Metrics",
            "Elemental Designs",
            "TrueNorth Digital",
            "Hyperion Data",
            "Catalyst Interactive",
            "Orbitronix",
            "Solstice AI",
            "Crimson Creek Studios",
            "NeonFrame Solutions",
            "TeraNova Systems",
            "BluePeak Software",
            "Lumenix Group",
            "CoreAxis Technologies",
            "Infinite Loop Inc.",
            "BrightForge Labs",
            "EchoNova Enterprises",
            "Skyline Dynamics",
            "Nexora Solutions",
            "Firefly Innovations",
            "ZenCore Technologies",
            "CloudNest Systems",
            "IronPeak Analytics",
            "Streamline Logic",
            "Aurora Metrics",
            "DataHaven Corp",
            "QuantumNest",
            "BrightMatter Inc.",
            "NimbusCore",
            "ElevateX Solutions",
            "FusionGrid",
            "TrueSight Systems"
        };

        private static readonly List<string> JobTitles = new List<string>
        {
            "Software Engineer",
                "Data Analyst",
                "Project Manager",
                "Product Owner",
                "UX Designer",
                "DevOps Engineer",
                "Business Analyst",
                "QA Tester",
                "IT Support Specialist",
                "Systems Architect",
                "Network Administrator",
                "Database Administrator",
                "Security Analyst",
                "Cloud Engineer",
                "AI Researcher",
                "Machine Learning Engineer",
                "Frontend Developer",
                "Backend Developer",
                "Full Stack Developer",
                "Mobile App Developer",
                "Technical Writer",
                "Scrum Master",
                "Solutions Architect",
                "Enterprise Architect",
                "Technical Account Manager",
                "Sales Engineer",
                "Customer Success Manager",
                "Marketing Manager",
                "Digital Strategist",
                "Content Manager",
                "SEO Specialist",
                "Social Media Manager",
                "Finance Analyst",
                "HR Manager",
                "Recruiter",
                "Operations Manager",
                "Legal Counsel",
                "Compliance Officer",
                "Risk Manager",
                "Procurement Specialist",
                "Supply Chain Analyst",
                "Logistics Coordinator",
                "Training Specialist",
                "Innovation Manager",
                "R&D Engineer",
                "Quality Assurance Manager",
                "Facilities Manager",
                "IT Director",
                "Chief Technology Officer"
        };

        private static readonly List<string> Countries = new List<string>
         {
            "United States",
            "Canada",
            "Germany",
            "Brazil",
            "India",
            "Australia",
            "Japan",
            "South Africa",
            "United Kingdom",
            "France"
         };

        private static readonly string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static readonly string digits = "0123456789";
        private static readonly string special = "!@#$%^&*()_-+=<>?/[]{}|";
        private static readonly string diacritics = "áàäâãåçéèêëíìîïñóòôöõúùûüýÿžøœšğşłßćń";

        internal static string GetRandomString(MBStringProperty property)
        {
            int length = property.Length;
            switch (property.Format)
            {
                case MBStringFormat.None:
                    return GetUnformattedString(property);
                case MBStringFormat.Guid:
                    return Guid.NewGuid().ToString();
                case MBStringFormat.AddressLine1:
                    return GetAddress1();
                case MBStringFormat.AddressLine2:
                    return GetAddress2();
                case MBStringFormat.City:
                    return GetCity();
                case MBStringFormat.State:
                    return GetState();
                case MBStringFormat.Zip:
                    return GetZipCode();
                case MBStringFormat.Country:
                    return GetCountry();
                case MBStringFormat.FirstName:
                    return GetFirstName();
                case MBStringFormat.LastName:
                    return GetLastName();
                case MBStringFormat.FullName:
                    return GetFullName();
                case MBStringFormat.Email:
                    return GetEmail(property);
                case MBStringFormat.Phone:
                    return GetPhoneNumber();
                case MBStringFormat.SSN:
                    return GetSSN();
                case MBStringFormat.Sex:
                    return GetSex();
                case MBStringFormat.JobTitle:
                    return GetJobTitle();
                case MBStringFormat.CompanyName:
                    return GetCompanyName();
                default:
                    throw new Exception($"Not a supported String Format for '{property.Name}'");
            }
        }

        internal static List<string> GetRandomStringList(MBStringProperty property)
        {
            var list = new List<string>();
            int count = _random.Next(3, 10);
            for (int i = 0; i < count; i++)
            {
                list.Add(GetRandomString(property));
            }
            return list;
        }

        internal static string GetUnformattedString(MBStringProperty property)
        {
            MBStringFormat format = property.Format;
            string allChars = letters;

            if (property.IncludeSpecialCharacters)
            {
                allChars += special;
            }

            if (property.IncludeDiacritics)
            {
                allChars += diacritics;
            }

            if (property.IncludeNumeric)
            {
                allChars += digits;
            }

            if (property.IncludeSpaces)
            {
                allChars += "                    ";
            }

            if (property.IncludeNullValues && _random.Next(2) == 0)
            {
                return null;
            }
            else
            {
                return new string(Enumerable.Repeat(allChars, property.Length)
            .Select(s => s[_random.Next(s.Length)]).ToArray());
            }
        }

        internal static string GetFirstName()
        {
            int index = _random.Next(FirstNames.Count);
            return FirstNames[index];
        }

        internal static string GetLastName()
        {
            int index = _random.Next(LastNames.Count);
            return LastNames[index];
        }

        internal static string GetFullName()
        {
            return GetFirstName() + " " + GetLastName();
        }

        internal static string GetEmail(MBStringProperty property)
        {
            int index = _random.Next(Domains.Count);
            string domain = Domains[index];
            return $"{GetUnformattedString(property)}@{domain}";
        }

        internal static string GetPhoneNumber()
        {
            int areaCode = _random.Next(200, 999);
            int centralOfficeCode = _random.Next(200, 999);
            int lineNumber = _random.Next(1000, 9999);
            return $"{areaCode}-{centralOfficeCode}-{lineNumber}";
        }

        internal static string GetSSN()
        {
            int prefix = 555;
            int center = _random.Next(99);
            int post = _random.Next(0000, 9999);
            return $"{prefix}-{center}-{post}";
        }

        internal static string GetAddress1()
        {
            int number = _random.Next(100, 9999);
            int index = _random.Next(Streets.Count);
            string street = Streets[index];
            return $"{number} {street}";
        }
        internal static string GetAddress2()
        {
            return "Apt " + _random.Next(1, 999).ToString();
        }
        internal static string GetCity()
        {
            int index = _random.Next(Cities.Count);
            return Cities[index];
        }
        internal static string GetState()
        {
            int index = _random.Next(States.Count);
            return States[index];
        }

        internal static string GetZipCode()
        {
            int zip = _random.Next(00000, 99999);
            return zip.ToString("00000");
        }

        internal static string GetCountry()
        {
             int index = _random.Next(Countries.Count);
            return Countries[index];
        }

        internal static string GetSex()
        {
            return _random.Next(2) == 0 ? "M" : "F";
        }

        internal static string GetJobTitle()
        {
            int index = _random.Next(JobTitles.Count);
            return JobTitles[index];
        }

        internal static string GetCompanyName()
        {
            int index = _random.Next(Companies.Count);
            return Companies[index];
        }
    }
}
