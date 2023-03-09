using AptekProject.Models;

Pharmacy pharmacy = new Pharmacy();


bool status  = true;

while(status)
{

    Console.WriteLine("Please enter step number...");
    Console.WriteLine("1. Add Medicine: ");
    Console.WriteLine("2. Show Medicines: ");
    Console.WriteLine("3. View Category: ");
    Console.WriteLine("q. Quit");
    Console.WriteLine("-------------------");
    Console.Write("Step number : ");

    string steps = Console.ReadLine();

    switch (steps)
	{
		case "1":
			pharmacy.AddMedicine();
			Console.WriteLine("Medicine is added...");
			break;
		case "2":
			if(pharmacy.MedicineCount == 0)
			{
				Console.WriteLine("You don't have any medicine. Please add medicine");
				break;
			}
			else
			{
				
				pharmacy.MedicineCount++;
				pharmacy.ShowMedicines();
				break;
			}
		case "3":
			if(pharmacy.MedicineCount == 0)
			{
				Console.WriteLine("You don't have any medicines. Please add medicine");
				break;
			}
			else
			{
				Console.WriteLine("Please enter category");
				string category = Console.ReadLine();
				pharmacy.ShowMedicines();
				break;
			}
		case "q":
			Console.WriteLine("Quiting...");
			status = false;
			break;
		default:
			break;

	}
}