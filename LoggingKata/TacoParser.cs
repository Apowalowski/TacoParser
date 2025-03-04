﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            string[] cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                logger.LogError("failed to Parse");
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2
            var name = cells[2];
            // Your going to need to parse your string as a `double` DONE

            // which is similar to parsing a string as an `int` DONE

            // You'll need to create a TacoBell class DONE
            // that conforms to ITrackable DONE

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var tacoBell1 = new TacoBell();
            Point location = new Point();
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            location.Latitude = latitude;
            location.Longitude = longitude;
            tacoBell1.Name = name;
            tacoBell1.Location = location;



            return tacoBell1;
        }
    }
}