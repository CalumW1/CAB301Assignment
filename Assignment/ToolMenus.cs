using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ToolMenus
    {
        // tool menu for all the 9 categories
        public void ToolCategory()
        {
            Console.WriteLine("Please select a Tool Category: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Gardening Tools");
            Console.WriteLine(" 2. Flooring Tools");
            Console.WriteLine(" 3. Fencing Tools");
            Console.WriteLine(" 4. Measuring Tools");
            Console.WriteLine(" 5. Cleaning Tools");
            Console.WriteLine(" 6. Painting Tools");
            Console.WriteLine(" 7. Electronic Tools");
            Console.WriteLine(" 8. Electricity Tools");
            Console.WriteLine(" 9. Automotive Tools");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-9, or 0 to return to staff menu):");
        }

        // menu for gardening tool type
        public void Gardeningtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Line Trimmers");
            Console.WriteLine(" 2. Lawn Mowers");
            Console.WriteLine(" 3. Hand Tools");
            Console.WriteLine(" 4. Wheel Barrows");
            Console.WriteLine(" 5. Garden Power Tools");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-5):");
        }

        // menu for flooring tool type
        public void Flooringtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Scrapers");
            Console.WriteLine(" 2. floor Lasers");
            Console.WriteLine(" 3. Floor Levelling Tools");
            Console.WriteLine(" 4. Floor Levelling Materials");
            Console.WriteLine(" 5. Floor hand tools");
            Console.WriteLine(" 6. Tiling Tools");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6):");
        }

        // menu for Fencing tool type
        public void Fencingtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Hand Tools");
            Console.WriteLine(" 2. Electric Fencing");
            Console.WriteLine(" 3. Steel Fencing Tools ");
            Console.WriteLine(" 4. Power Tools");
            Console.WriteLine(" 5. Fencing Accessories");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-5):");
        }

        // menu for measuring tool type
        public void measuringtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Distance Tools");
            Console.WriteLine(" 2. Laser Measurer");
            Console.WriteLine(" 3. Measuring Jugs");
            Console.WriteLine(" 4. Temperature & Humidity Tools");
            Console.WriteLine(" 5. Levelling Tools");
            Console.WriteLine(" 6. Markers");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6):");
        }

        // menu for cleaning tool type
        public void cleaningtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Draining");
            Console.WriteLine(" 2. Car Cleaning");
            Console.WriteLine(" 3. Vacuum");
            Console.WriteLine(" 4. Pressure Cleaners");
            Console.WriteLine(" 5. Pool Cleaning");
            Console.WriteLine(" 6. Floor Cleaning");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6):");
        }
        // menu for Painting tool type
        public void paintingtools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Sanding Tools");
            Console.WriteLine(" 2. Brushes");
            Console.WriteLine(" 3. Rollers");
            Console.WriteLine(" 4. Paint removal Tools");
            Console.WriteLine(" 5. Paint Scrapers");
            Console.WriteLine(" 6. Sprayers");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6):");
        }

        // menu for Electronic tool type
        public void electronictools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Voltage Test");
            Console.WriteLine(" 2. Oscilloscopes");
            Console.WriteLine(" 3. Thermal Imaging");
            Console.WriteLine(" 4. Data Test Tool");
            Console.WriteLine(" 5. Insulation Tester");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-5):");
        }

        // menu for Electricty tool type
        public void electricitytools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Test Equipment");
            Console.WriteLine(" 2. Saftey Equipment");
            Console.WriteLine(" 3. Basic Hand tools");
            Console.WriteLine(" 4. Circuit Protection");
            Console.WriteLine(" 5. Cable Tools");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-5):");
        }

        // menu for Automotive tool type
        public void automotivetools()
        {
            Console.WriteLine("Please select a Tool Type: ");
            Console.Write("\n");
            Console.WriteLine(" 1. Jacks");
            Console.WriteLine(" 2. Air Compressors");
            Console.WriteLine(" 3. Battery Chargers");
            Console.WriteLine(" 4. Socket Tools");
            Console.WriteLine(" 5. Braking");
            Console.WriteLine(" 6. Drivetrain");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6):");
        }
    }
}
