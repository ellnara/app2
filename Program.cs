using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine drug1 = new Medicine("drug1", 320, 500);
            Medicine drug2 = new Medicine("drug2", 30, 200);
            Medicine drug3 = new Medicine("drug3", 10, 500);
            Medicine drug4 = new Medicine("drug4", 28, 1100);
            Pharmacy pharmacy = new Pharmacy(27);
            pharmacy.AddMedicine(drug1);
            pharmacy.AddMedicine(drug2);
            pharmacy.AddMedicine(drug3);
            pharmacy.AddMedicine(drug4);

            pharmacy.EditMedicineEmail(1, "fgdhghg");
            pharmacy.GetAllMedicines();

        }
    }
}
