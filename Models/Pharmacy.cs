using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekProject.Models
{
    internal class Pharmacy
    {
        public string Name;
        public int MedicineCount = 0;
        public Medicine[] medicines = { };

        public Medicine[] AddMedicine()
        {
            Array.Resize(ref medicines, MedicineCount+1);
            Console.WriteLine("Enter medicine name: ");
            string name =  Console.ReadLine();
            Console.WriteLine("Enter which category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter medicine price: ");
            double price = 0;
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
                //price = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Price should be only digits!");
            }

            while(!CheckNamePrice(name,price))
            {
                Console.WriteLine("Enter medicine name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter which category: ");
                category = Console.ReadLine();

                Console.WriteLine("Enter medicine price: ");
                price = Convert.ToDouble(Console.ReadLine());

            }
            medicines[MedicineCount] = new Medicine(name, category, price);
            MedicineCount++;
            return medicines;
        }


        public void ShowMedicines()
        {
            foreach (Medicine medicine in medicines)
            {
                if (MedicineCount != 0)
                {
                    Console.WriteLine($"Medicine name: {medicine.Name}, Medicine category:  {medicine.Category} Medicine Price: {medicine.Price} ");
                }
                else
                {
                    Console.WriteLine("Medicine can not find in base");

                }

            }
           
            
        }

        bool CheckNamePrice(string name, double price)
        {
            if(name.Length < 3)
            {
                return false;
            }
            if(price < 0)
            {
                return false;
            }
            return true;
        }
    }
}
